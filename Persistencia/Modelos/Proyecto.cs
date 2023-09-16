using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
    //La clase "Proyecto" permite almacenar los datos de un registro de/para la tabla "tbl_proyectos"
    public class Proyecto
    {
        //Método constructor
        public Proyecto() { }

        //Atributos de la clase o campos de la tabla "tbl_proyectos"
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private string encargado;

        public string Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }
    }
}
