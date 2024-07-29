using Dominio;
using Persistencia.Modelos;
using Presentacion.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class InsertarEmpleado : Form
    {
        private ValidarEntrada validar = new();
        Modelo_Empleado empleado_m = new();


        public InsertarEmpleado()
        {
            InitializeComponent();
        }

        private void InsertarEmpleado_Load(object sender, EventArgs e)
        {
            //Modifica el estilo de los ComboBox a DropDownList para evitar errores de escritura
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Valida que los campos no estén vacíos
            if (txtNombres.Text == "" || txtApellidos.Text == "" || txtUsuario.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "" || cmbSexo.Text == "" || cmbCargos.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Valida que la fecha de nacimiento sea menor a la fecha de hace 18 años (mayoría de edad)
                if (dtpFechaNacimiento.Value.AddYears(18) > DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no es válida.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Valida que el correo tenga un formato válido
                    if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                    {
                        MessageBox.Show("El correo no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string expresion = "^[_a-z0-9]+(.[_a-z0-9-])*@[a-z0-9]+(.[a-z0-9-]+)*\\.(.[a-z]{2,4})$";//juanjo27.Hernandez@gmail.com.sv
                        //string expresion = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

                        if (Regex.IsMatch(txtCorreo.Text, expresion))//Si el mail ingresado tiene el formato especificado
                        {
                            if (Regex.Replace(txtCorreo.Text, expresion, string.Empty).Length == 0)
                            {
                                //Validar que el correo no exista
                                if (empleado_m.ValidarCorreo(txtCorreo.Text))
                                {
                                    //Validar que el usuario no exista
                                    if (empleado_m.ValidarUsuario(txtUsuario.Text))
                                    {
                                        //Crea un nuevo objeto de tipo Empleado
                                        Empleado empleado = new Empleado
                                        {
                                            Nombres = txtNombres.Text,
                                            Apellidos = txtApellidos.Text,
                                            Usuario = txtUsuario.Text,
                                            Email = txtCorreo.Text,
                                            Direccion = txtDireccion.Text,
                                            Nacimiento = dtpFechaNacimiento.Value,
                                            Sexo = cmbSexo.Text,
                                            Cargo = cmbCargos.Text
                                        };

                                        //Inserta el empleado en la base de datos

                                        MessageBox.Show("Empleado insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("El usuario ya esta en uso, por favor ingrese un usuario diferente.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("El correo ya esta en uso, por favor ingrese un correo diferente.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                erpValidar.SetError(txtCorreo, "Correo inválido.");
                            }
                        }
                        else
                        {
                            erpValidar.SetError(txtCorreo, "Correo inválido");
                        }
                        /*
                        //Valida que el usuario no exista
                        if (Negocio.Empleado.ValidarUsuario(txtUsuario.Text))
                        {
                            MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Valida que el correo no exista
                            if (Negocio.Empleado.ValidarCorreo(txtCorreo.Text))
                            {
                                MessageBox.Show("El correo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Crea un nuevo objeto de tipo Empleado
                                Entidades.Empleado empleado = new Entidades.Empleado();
                                empleado.Nombres = txtNombres.Text;
                                empleado.Apellidos = txtApellidos.Text;
                                empleado.Usuario = txtUsuario.Text;
                                empleado.Correo = txtCorreo.Text;
                                empleado.Direccion = txtDireccion.Text;
                                empleado.FechaNacimiento = dtpFechaNacimiento.Value;
                                empleado.Sexo = cmbSexo.Text;
                                empleado.Cargo = cmbCargos.Text;

                                //Inserta el empleado en la base de datos
                                Negocio.Empleado.InsertarEmpleado(empleado);

                                MessageBox.Show("Empleado insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }*/
                    }
                }

            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetras(sender, e, erpValidar);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetras(sender, e, erpValidar);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida que el usuario no contenga espacios
            validar.ValidarEspacios(sender, e, erpValidar);
        }
    }
}
