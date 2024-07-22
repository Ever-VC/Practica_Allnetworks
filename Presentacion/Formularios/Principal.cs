using Presentacion.Logica;
using Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            OcultarSubMenu();//Oculta los sub-menus
            btnInicio.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado

            //Abre el formulario de "Inicio" para que se muestre en el panel principal al momento de iniciar el programa
            FabFormularios.AbrirFormulariosHijos(new Inicio(), pnlPContenedor);
        }

        private void CargarDatosPerfil()
        {
            //Verifica si el cargo del usuario que ha iniciado sesión es "Encargado de Fiananzas" ya que 
            //este no tiene los privilegios que tiene el "Encargado de Proyectos"
            if (Usuario_Cache.Cargo == Cargos.EncargadoFinanzas)
            {
                /*
                //Establece el color de los botones a los que no tendrá acceso en color gris claro
                btnAdministrarProyectos.BackColor = Color.LightGray;
                btnAdministrarRecursos.BackColor = Color.LightGray;
                btnAdministrarUsuarios.BackColor = Color.LightGray;
                btnRecursos.BackColor = Color.LightGray;
                btnCategoria.BackColor = Color.LightGray;

                //Desabilita los botones a los que no tendrá acceso el Encargado de Finanzas
                btnAdministrarProyectos.Enabled = false;
                btnAdministrarRecursos.Enabled = false;
                btnAdministrarUsuarios.Enabled = false;
                btnRecursos.Enabled = false;
                btnCategoria.Enabled = false;
                */
                //Establece la propiedad "Visible" de los botones a los que no tendrá acceso en "False"
                btnAdministrarProyectos.Visible = false;
                btnAdministrarRecursos.Visible = false;
                btnAdministrarUsuarios.Visible = false;
                btnRecursos.Visible = false;
                btnCategoria.Visible = false;
            }
            else if (Usuario_Cache.Cargo == Cargos.EncargadoProyecto)
            {
                btnAdministrarUsuarios.Visible = false;
            }

            //Verifica el sexo de la persona que ha iniciado sesión para así mostrar el avatar adecuado
            //para el caso del avatar masculino no se verifica ya que es el que se muestra inicialmente
            //por lo tanto para mostrar el del sexo femenino se tiene que hacer la siguiente verificación
            if (Usuario_Cache.Sexo == "Femenino")
            {
                //Indica la ruta de donde extrae el avatar femenino
                imgPerfil.Image = Presentacion.Properties.Resources.avatarUserF;
            }

            lblNombreUsuario.Text = NombreApellidoUsuario();//Muestra el primero nombre y primer apellido en el label
            lblNombreUsuario.Location = new Point((pnlPerfil.Width - lblNombreUsuario.Width) / 2, lblNombreUsuario.Location.Y);//Centra el label en el panel
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnInicio.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            OcultarSubMenu();//Oculta los sub-menus
            FabFormularios.AbrirFormulariosHijos(new Inicio(), pnlPContenedor);
        }

        private void btnAdministrarProyectos_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            //Verifica si el sub-menu de "Administrar Proyectos" es visible
            if (pnlAdministrarProyectos.Visible)
            {
                OcultarSubMenu();//Oculta los sub-menus
            }
            else
            {
                OcultarSubMenu();//Oculta los sub-menus
                btnAdministrarProyectos.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
                pnlAdministrarProyectos.Visible = true;//Muestra el sub-menu correspondiente
            }
        }

        private void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            //Abre el formulario de "InsertarProyecto" para que se muestre en el panel principal
            btnAgregarProyecto.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            FabFormularios.AbrirFormulariosHijos(new InsertarProyecto(), pnlPContenedor);
        }

        private void btnEditarProyecto_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEditarProyecto.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EditarProyecto(), pnlPContenedor);
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEliminarProyecto.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EliminarProyecto(), pnlPContenedor);
        }

        private void btnAdministrarRecursos_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnAdministrarRecursos.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            OcultarSubMenu();//Oculta los sub-menus si estan abiertos
            //FabFormularios.AbrirFormulariosHijos(new AdministrarRecursos(), pnlPContenedor);
        }

        private void btnVerProyectos_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnVerProyectos.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            OcultarSubMenu();//Oculta los sub-menus si estan abiertos
            //FabFormularios.AbrirFormulariosHijos(new VerProyectos(), pnlPContenedor);
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            //Verifica si el sub-menu de "Administrar Usuarios" es visible
            if (pnlAdministrarUsuarios.Visible)
            {
                OcultarSubMenu();//Oculta los sub-menus
            }
            else
            {
                OcultarSubMenu();//Oculta los sub-menus
                btnAdministrarUsuarios.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
                pnlAdministrarUsuarios.Visible = true;//Muestra el sub-menu correspondiente
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnAgregarUsuario.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            FabFormularios.AbrirFormulariosHijos(new InsertarEmpleado(), pnlPContenedor);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEditarUsuario.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EditarUsuario(), pnlPContenedor);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEliminarUsuario.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EliminarUsuario(), pnlPContenedor);
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            //Verifica si el sub-menu de "Recursos" es visible
            if (pnlRecursos.Visible)
            {
                OcultarSubMenu();//Oculta los sub-menus
            }
            else
            {
                OcultarSubMenu();//Oculta los sub-menus
                btnRecursos.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
                pnlRecursos.Visible = true;//Muestra el sub-menu correspondiente
            }
        }

        private void btnAgregarRecurso_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnAgregarRecurso.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new InsertarRecurso(), pnlPContenedor);
        }

        private void btnEditarRecurso_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEditarRecurso.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EditarRecurso(), pnlPContenedor);
        }

        private void btnEliminarRecurso_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEliminarRecurso.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.Instancia.AbrirFormulariosHijos(new EliminarRecurso(), pnlPContenedor);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            //Verifica si el sub-menu de "Recursos" es visible
            if (pnlAdministrarCategorias.Visible)
            {
                OcultarSubMenu();//Oculta los sub-menus
            }
            else
            {
                OcultarSubMenu();//Oculta los sub-menus
                btnCategoria.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
                pnlAdministrarCategorias.Visible = true;//Muestra el sub-menu correspondiente
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnAgregarCategoria.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new InsertarCategoria(), pnlPContenedor);
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEditarCategoria.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EditarCategoria(), pnlPContenedor);
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            cambiarColorBotones();//Pone los botones de color rgb(13, 93, 142) como sino estuviesen seleccionados
            btnEliminarCategoria.BackColor = Color.FromArgb(13, 93, 142);//Cambia el color del boton simulando que está seleccionado
            //FabFormularios.AbrirFormulariosHijos(new EliminarCategoria(), pnlPContenedor);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Consulta y pide al usuario que confirme que desea cerrar del todo la aplicaicón
            if (DialogResult.Yes == MessageBox.Show("¿ESTA SEGURO QUE DESEA CERRAR SESIÓN?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.Close();//Si es usuario preciona el botón de "Yes", cierra el formulario, caso contrario no pasa nada (osea que se queda abierto)
            }
        }

        private void OcultarSubMenu()
        {
            //Oculta todos los sub-menus
            pnlAdministrarProyectos.Visible = false;
            pnlAdministrarUsuarios.Visible = false;
            pnlRecursos.Visible = false;
            pnlAdministrarCategorias.Visible = false;
        }

        private void cambiarColorBotones()
        {
            //Establece el color de los botones como sino estuviesen seleccionados
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
            btnAdministrarProyectos.BackColor = Color.FromArgb(24, 30, 54);
            btnAgregarProyecto.BackColor = Color.FromArgb(24, 30, 54);
            btnEditarProyecto.BackColor = Color.FromArgb(24, 30, 54);
            btnEliminarProyecto.BackColor = Color.FromArgb(24, 30, 54);
            btnAdministrarRecursos.BackColor = Color.FromArgb(24, 30, 54);
            btnVerProyectos.BackColor = Color.FromArgb(24, 30, 54);
            btnAdministrarUsuarios.BackColor = Color.FromArgb(24, 30, 54);
            btnAgregarUsuario.BackColor = Color.FromArgb(24, 30, 54);
            btnEditarUsuario.BackColor = Color.FromArgb(24, 30, 54);
            btnEliminarUsuario.BackColor = Color.FromArgb(24, 30, 54);
            btnRecursos.BackColor = Color.FromArgb(24, 30, 54);
            btnAgregarRecurso.BackColor = Color.FromArgb(24, 30, 54);
            btnEditarRecurso.BackColor = Color.FromArgb(24, 30, 54);
            btnEliminarRecurso.BackColor = Color.FromArgb(24, 30, 54);
            btnCategoria.BackColor = Color.FromArgb(24, 30, 54);
            btnAgregarCategoria.BackColor = Color.FromArgb(24, 30, 54);
            btnEditarCategoria.BackColor = Color.FromArgb(24, 30, 54);
            btnEditarCategoria.BackColor = Color.FromArgb(24, 30, 54);

            CargarDatosPerfil();

        }

        private string NombreApellidoUsuario()
        {
            string nombre = "", apellido = "";
            //verifica si exixte un ' ' (espacio en blanco) dentro del nombre
            if (Usuario_Cache.Nombres.Contains(' '))
            {
                //Almacena el índice en donde se encuentra el primer espacio en blanco (Ya que solo quiero el primer nombre)
                int indice1 = Usuario_Cache.Nombres.IndexOf(' ');
                nombre = Usuario_Cache.Nombres.Remove(indice1);//Remueve el resto de la cadena
            }
            else
            {
                nombre = Usuario_Cache.Nombres;//En caso que no exista un espacio (tiene nombre único), deja tal cual el nombre
            }

            //verifica si exixte un ' ' (espacio en blanco) dentro del apellid
            if (Usuario_Cache.Apellidos.Contains(' '))
            {
                //Almacena el índice en donde se encuentra el primer espacio en blanco (Ya que solo quiero el primer apellido)
                int indice2 = Usuario_Cache.Apellidos.IndexOf(' ');
                apellido = Usuario_Cache.Apellidos.Remove(indice2);//Remueve el resto de la cadena

                //Si el "apellido" es "de", significa que es una preposición (por ejemplo: De Hernándes)
                if (apellido.ToLower() == "de")
                {
                    apellido = Usuario_Cache.Apellidos;//Deja todo el apellido
                }

            }
            else
            {
                apellido = Usuario_Cache.Apellidos;//En caso que no exista un espacio (tiene apellido único), deja tal cual el aepllido
            }

            //Concatena el nombre recortado hasta el "indice1", así mismo el apellido recortado hasta el "indice2"
            return "" + nombre + " " + apellido;        
        }
    }
}
