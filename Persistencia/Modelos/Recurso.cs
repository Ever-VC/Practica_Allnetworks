using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
    //La clase "Recurso" permite almacenar los datos de un registro de/para la tabla "tbl_recursos"
    public class Recurso
    {
        //Método constructor
        public Recurso() { }

        //Atributos de la clase o campos de la tabla "tbl_recursos"
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
        private float costoUnitario;

        public float CostoUnitario
        {
            get { return costoUnitario; }
            set { costoUnitario = value; }
        }

        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}
