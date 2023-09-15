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
                    MessageBox.Show("Bienvenido al sistema");
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
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblError.Visible = false;
            this.Show();
        }
        #endregion

    }
}
