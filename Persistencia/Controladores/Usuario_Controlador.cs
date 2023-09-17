using MySql.Data.MySqlClient;
using Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Controladores
{
    public class Usuario_Controlador: Conexion_db
    {
        //CLASE EN LA QUE SE APLICA EL PATRON DE DISEÑO SINGLETON
        //https://refactoring.guru/es/design-patterns/singleton
        public static Usuario_Controlador _instance;//Crea una instancia de la clase "Usuario_Controlador" (la cual inicialmente es nula)

        //Através del siguiente método se puede tener acceso a los otros métodos, ya que utiliza la instancia de la clase
        //creada anteriormente. Primero verifica si la instancia es nula, si es así, inicializa la instancia y luego
        //la retorna, en caso contrario, solo la retona (EVITA CREAR MULTIPLES INSTANCIAS)
        public static Usuario_Controlador Instance => _instance ??= new();

        public int LogIn(string usuario, string password)
        {
            //-1 SIGNIFICA QUE NO SE PUDO ESTABLECER LA CONEXION A LA BASE DE DATOS
            //0 SIGNIFICA QUE SI HAY CONEXION PERO EL USUARIO Y CONTRASEÑA NO EXISTEN EN LA BASE DE DATOS
            //1 SIGNIFICA QUE SI HAY CONEXION Y SI SE ENCONTRO EL USUARIO
            //Inicialmente tiene el valor de "-1" lo que significa que no hay conexión a la db, cambiará sí y solo sí
            //la conexión NO es nula
            int result = -1;
            //Se utiliza el bloque "Using" ya que este desecha automáticamente todos los objetos creados dentro del bloque,
            //es decir que cierra todas las instancias de forma automática.
            using (MySqlConnection connection = GetConexion())
            {
                //Verifica si la conexión es NULA, lo que significaría que no se puede acceder a la base de datos
                if (connection != null)
                {
                    //Consulta a ejecutar, los valores que están con un "@" significa que son parámetros
                    //a los cuales se les asigan el valor después
                    string query = "SELECT * FROM `tbl_empleados` INNER JOIN `tbl_usuarios` ON " +
                                   "tbl_usuarios.id_empleado = tbl_empleados.id_empleado AND" +
                                   " tbl_empleados.usuario = @Usuario AND `password` = @Password";

                    //Crea el comando y se le indica la consulta a ejecutar y la conexión a la base de datos
                    MySqlCommand cmd = new(query, connection);

                    //Le asigna el valor a los parámetros de la consulta
                    cmd.Parameters.Add(new MySqlParameter("@Usuario", usuario));
                    cmd.Parameters.Add(new MySqlParameter("@Password", password));

                    //Se le indica el tipo de comando
                    cmd.CommandType = System.Data.CommandType.Text;

                    //Ejecuta el comando y almacena lo retornado en un DataReader.
                    using MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Verifica si el DataReader contiene filas
                    if (dataReader.HasRows)
                    {
                        //Si contiene filas, se lee cada una de ellas a través de un ciclo "While"
                        while (dataReader.Read())
                        {
                            //Almacena en caché cada uno de los campos (ya que serán necesarios mientras el programa siga en ejecución)
                            Usuario_Cache.Id = int.Parse(dataReader.GetString("id_empleado"));
                            Usuario_Cache.Nombres = dataReader.GetString("nombres");
                            Usuario_Cache.Apellidos = dataReader.GetString("apellidos");
                            Usuario_Cache.Nacimiento = DateTime.Parse(dataReader.GetString("fecha_nacimiento"));
                            Usuario_Cache.Usuario = dataReader.GetString("usuario");
                            Usuario_Cache.Cargo = dataReader.GetString("cargo");
                            Usuario_Cache.Direccion = dataReader.GetString("direccion");
                            Usuario_Cache.Email = dataReader.GetString("email");
                            Usuario_Cache.Sexo = dataReader.GetString("sexo");
                        }
                        result = 1;//Le asigna el valor de "1" lo cual indica que SI se econtró el usuario en la db
                    }
                    else
                    {
                        result = 0;//Le asigna el valor de "0" lo cual indica que NO se econtró el usuario en la db
                    }
                }
            }
            return result;

        }
    }
}
