using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Controladores;

namespace Dominio
{
    public class Modelo_Empleado
    {
        /// <summary>
        /// Retorna verdadero si el correo no existe en la base de datos.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidarCorreo(string email)
        {
            return Empleado_Controlador.Instancia.ValidarCorreo(email);
        }

        /// <summary>
        /// Retorna verdadero si el usuario no existe en la base de datos.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarUsuario(string usuario)
        {
            return Empleado_Controlador.Instancia.ValidarUsuario(usuario);
        }
    }
}
