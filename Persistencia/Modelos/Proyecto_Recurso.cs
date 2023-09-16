using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
    //La clase "Proyecto_Recurso" permite almacenar los datos de un registro de/para la tabla "tbl_proyecto_recurso"
    public class Proyecto_Recurso
    {
        //Método constructor
        public Proyecto_Recurso() { }

        //Atributos de la clase o campos de la tabla "tbl_proyecto_recurso"
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idProyecto;

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }

        private int idRecurso;

        public int IdRecurso
        {
            get { return idRecurso; }
            set { idRecurso = value; }
        }

        private int cantidadRecurso;

        public int CantidadRecurso
        {
            get { return cantidadRecurso; }
            set { cantidadRecurso = value; }
        }
    }
}
