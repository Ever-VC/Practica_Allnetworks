using Persistencia.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modelo_Usuario
    {
        public Modelo_Usuario() { }

        //Permite que la capa de Presentación se comunique con la de persistencia pero no de forma directa
        public int LogIn(string usuario, string password)
        {
            //Retorna el valor de RETORNO (-1, 0, 1) de la funsión "LogIn" que está en la clase "Usuario_Controlador"
            //que está en la capa de "Persistencia", es decir, esta función solo trabaja como intermedierio
            return Usuario_Controlador.Instance.LogIn(usuario, password);
        }
    }
}
