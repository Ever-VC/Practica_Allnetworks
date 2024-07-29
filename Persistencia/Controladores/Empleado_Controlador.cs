using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Controladores
{
    public class Empleado_Controlador: Conexion_db
    {
        private static Empleado_Controlador _instancia;

        public static Empleado_Controlador Instancia => _instancia ??= new();

        /// <summary>
        /// Retorna verdadero si el correo no existe en la base de datos.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidarCorreo(string email)
        {
            bool resultado = true;

            using (MySqlConnection connection = GetConexion())
            {
                string query = "SELECT * FROM tbl_empleados WHERE email = @email";

                MySqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@email", email);

                if (command.ExecuteScalar() != null)
                {
                    resultado = false;
                }
                else
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        /// <summary>
        /// Retorna verdadero si el usuario no existe en la base de datos.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarUsuario(string usuario)
        {
            bool resultado = true;

            using (MySqlConnection connection = GetConexion())
            {
                string query = "SELECT * FROM tbl_empleados WHERE usuario = @usuario";

                MySqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@usuario", usuario);

                if (command.ExecuteScalar() != null)
                {
                    resultado = false;
                }
                else
                {
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}
