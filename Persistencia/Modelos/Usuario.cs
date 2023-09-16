using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
    //La clase "Usuario" permite almacenar los datos de un registro de/para la tabla "tbl_usuarios"
    public class Usuario
    {
        public Usuario() { }

        //Atributos de la clase o campos de la tabla "tbl_usuarios"
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
