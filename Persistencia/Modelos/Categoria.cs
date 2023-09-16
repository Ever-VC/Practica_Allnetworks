using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
    //La clase "Categoria" permite almacenar los datos de un registro de/para la tabla "tbl_categorias"
    public class Categoria
    {
        //Método constructor
        public Categoria() { }

        //Atributos de la clase o campos de la tabla "tbl_categorias"
        private int id;

        public int Id { 
            get {  return id; } 
            set {  id = value; } 
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
