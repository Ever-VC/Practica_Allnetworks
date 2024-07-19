using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class Conexion_db
    {
        private readonly string url;

        public Conexion_db()
        {
            //Estblace la ruta a la base de datos
            url = "Data Source=localhost;port=3306;uid=root;pwd='';database=allnetworks_db";
        }

        protected MySqlConnection GetConexion()
        {
            //Crea la instancia de la conexion
            MySqlConnection conexion = new(url);

            try
            {
                //Abre la conexion
                conexion.Open();
            }
            catch
            {
                //En caso de haber un error en la apertura de la conexion, muestra el mensaje de error y retorna null
                MessageBox.Show("Parece que ocurrió un error al conectarnos a la base de datos, por favor inténtalo nuevamente.", "Error 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            //Si todo sale bien, retorna la conexion a la base de datos
            return conexion;

        }
    }
}
