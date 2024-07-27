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
    public partial class InsertarEmpleado : Form
    {
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
            if (txtNombres.Text == "" || txtApellidos.Text == "" || txtUsuario.Text == "" || txtCorreo.Text == "" ||  txtDireccion.Text == "" || cmbSexo.Text == "" || cmbCargos.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Valida que la fecha de nacimiento sea menor a la fecha de hace 18 años (mayoría de edad)
                if (dtpFechaNacimiento.Value.AddYears(18) > DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Empleado insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
