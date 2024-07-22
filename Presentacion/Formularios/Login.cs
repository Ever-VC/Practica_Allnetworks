using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Enter & Leave txt
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {//Si el texto del cadro es "USUARIO"
                txtUsuario.Text = "";//Limpia el texto
                txtUsuario.ForeColor = Color.LightGray;//Da un color gris claro a lo que el usuario digite
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {//Si el usuario no insertó ningún caracter
                txtUsuario.Text = "USUARIO";//Se asigna "USUARIO" a la propiedad de texto
                txtUsuario.ForeColor = Color.DimGray;//Cambia el color de texto al color inicial
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {//Si el texto del cadro es "CONTRASEÑA"
                txtPassword.Text = "";//Limpia el texto
                txtPassword.ForeColor = Color.LightGray;//Da un color gris claro a lo que el usuario digite
                txtPassword.UseSystemPasswordChar = true;//Asigna el formato de contraseña al texto que inserte el usuario
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {//Si el usuario no insertó ningún caracter
                txtPassword.Text = "CONTRASEÑA";//Se asigna "CONTRASEÑA" a la propiedad de texto
                txtPassword.ForeColor = Color.DimGray;//Cambia el color de texto al color inicial
                txtPassword.UseSystemPasswordChar = false;//Indica que NO es un formato de contraseña
            }
        }
        #endregion

        #region Mover el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Cerrar & Minimizar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierra la aplicación
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Acceder & Salir
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")//Verifica si se ha ingresado un usuario
            {
                if (txtPassword.Text != "CONTRASEÑA")//Verifica si se ha ingresado una contraseña
                {
                    Modelo_Usuario usuario = new();//Se accede a la capa de Dominio y se crea un objeto de la clase "Modelo_Usuario"

                    //A través del objeto de la capa de dominio se verifica si existe el usuario que desea acceder al programa
                    //La funcio "LogInEmpleado" retorna verdadero en caso que el usuario y contraseña existan en la base de datos

                    this.Cursor = Cursors.WaitCursor;

                    //-1 SIGNIFICA QUE NO SE PUDO ESTABLECER LA CONEXION A LA BASE DE DATOS (EN ESTE CASO NO PASA NADA)
                    //0 SIGNIFICA QUE SI HAY CONEXION PERO EL USUARIO Y CONTRASEÑA NO EXISTEN EN LA BASE DE DATOS
                    //1 SIGNIFICA QUE SI HAY CONEXION Y SI SE ENCONTRO EL USUARIO
                    int resul = usuario.LogIn(txtUsuario.Text, txtPassword.Text);

                    //VERIFICA EL ESTADO (SI ES -1, 0 O 1)
                    if (resul == 1)
                    {
                        this.Hide();//Oculta el formulario de login
                        Principal frmPrincipal = new();//Crea un objeto del formulario de inicio

                        frmPrincipal.Show();//Muestra el formulario de inicio

                        frmPrincipal.FormClosed += Salir;//Cuando se cierre el formulario de inicio se ejecuta la función "Salir"
                    }
                    else if (resul == 0)
                    {
                        //En caso que "resul" tenga el valor de "0" (lo cual significa que el usuario no existe o están mal escritos los datos)
                        MessageBox.Show("NOMBRE DE USUARIO O CONTRASEÑA INCORRECTO.\nPOR FAVOR INTENTELO NUEVAMENTE.", "ERROR.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        LimpiarEntradas();
                        linkPassword.Focus();
                    }
                    this.Cursor = Cursors.Default;

                }
                else MensajeError("POR FAVOR INGRESE SU CONTRASEÑA.");
            }
            else MensajeError("POR FAVOR INGRESE SU NOMBRE DE USUARIO.");
        }

        private void MensajeError(string msg)
        {
            //Recibe el mensaje de errror que se desea mostrar el la etiqueta
            lblError.Text = "     " + msg;
            lblError.Visible = true;
        }

        private void Salir(Object sender, FormClosedEventArgs e)
        {
            LimpiarEntradas();
            this.Show();
        }

        private void LimpiarEntradas()
        {
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblError.Visible = false;
            txtPassword.ForeColor = Color.DimGray;//Cambia el color de texto al color inicial
            txtUsuario.ForeColor = Color.DimGray;//Cambia el color de texto al color inicial
        }
        #endregion

    }
}
