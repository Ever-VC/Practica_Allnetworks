using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte
{
    public class Usuario_Cache
    {
        public Usuario_Cache() { }

        //Almacena en caché los datos que serán necesarios durante la ejecución del programa
        //La palabra reservada "static" indica que permanecerán en memoria caché desde que se les asigna el valor
        //hasta que el programa se cierre
        public static int Id { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static DateTime Nacimiento { get; set; }
        public static string Usuario { get; set; }
        public static string Cargo { get; set; }
        public static string Direccion { get; set; }
        public static string Email { get; set; }
        public static string Sexo { get; set; }
    }
}
