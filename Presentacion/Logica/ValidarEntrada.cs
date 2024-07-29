using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Logica
{
    public class ValidarEntrada
    {
        /// <summary>
        /// Valida que el campo solo acepte números enteros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="erpValidar"></param>
        public void ValidarDigitos(object sender, KeyPressEventArgs e, ErrorProvider erpValidar)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                erpValidar.SetError((Control)sender, "Este campo solo acepta números.");
            }
        }

        /// <summary>
        /// Valida que el campo solo acepte letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="erpValidar"></param>
        public void ValidarLetras(object sender, KeyPressEventArgs e, ErrorProvider erpValidar)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                erpValidar.SetError((Control)sender, "Este campo solo acepta letras.");
            }
        }

        /// <summary>
        /// Valida que el campo no acepte espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="erpValidar"></param>
        public void ValidarEspacios(object sender, KeyPressEventArgs e, ErrorProvider erpValidar)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                erpValidar.SetError((Control)sender, "Este campo no acepta espacios.");
            }
        }
    }
}
