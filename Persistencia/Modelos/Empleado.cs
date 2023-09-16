using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
    //La clase "Empleado" permite almacenar los datos de un registro de/para la tabla "tbl_empleados"
    public class Empleado
    {
        //Método constructor
        public Empleado() { }

        //Atributos de la clase o campos de la tabla "tbl_empleados"
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime Nacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
