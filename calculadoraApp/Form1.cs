using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Calculadora para Tarea01 de Desarrollo de Interfaces.
/// </summary>

namespace calculadoraApp
{
    public partial class FrmCalculadora : Form
    {
        // variables para las operaciones
        private double? operando1 = null;
        private double? operando2 = null;
        private string operacion = "";
        private bool realizandoOperacion = false;
        private bool borrarPantalla = false;

        // variable para botones de memoria
        private double memoria = 0;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se desencadena al hacer Click en un botón de operación.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Argumentos del evento</param>
        /// <remarks>
        /// El método modifica el TxtResultado y además el TxtAuxiliar que va mostrando las operaciones.
        /// </remarks>
        private void BtnOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //  Operaciones contiguas
            if (operando1 != null)
            {
                BtnIgual_Click(null, null);
            }

            operando1 = Double.Parse(TxtResultado.Text);
            operacion = btn.Text;

            // Para que la pantalla auxiliar siempre fuera visible, he tenido que ir borrando líneas según fuera necesario
            if (TxtAux.Lines.Length >= 3)
            {
                List<string> lineas = new List<string>(TxtAux.Lines);
                lineas.RemoveAt(0);
                TxtAux.Lines = lineas.ToArray();
                TxtAux.Text += TxtResultado.Text + " " + btn.Text + " ";
            } else TxtAux.Text += TxtResultado.Text + " " + btn.Text + " ";

            TxtResultado.Text = "0";
            realizandoOperacion = true;
           
        }

        /// <summary>
        /// Método que se desencadena al hacer Click en cualquier botón numérico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (TxtResultado.Text.Equals("0") || borrarPantalla) {
                TxtResultado.Text = btn.Text;
                borrarPantalla = false;
            } else TxtResultado.Text += btn.Text;         
        }

        /// <summary>
        /// Método que se desencadena cuando se hace Click en el botón igual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Se comprueba la variable operacion para realizar una acción u otra con los operandos</remarks>
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (realizandoOperacion == false)
            {
                return;
            }

            operando2 = Double.Parse(TxtResultado.Text);
            double resultado = RealizarOperacion(operando1, operando2, operacion);

            TxtAux.Text += TxtResultado.Text + " = " + resultado.ToString() + Environment.NewLine;
            TxtResultado.Text = resultado.ToString();

            operando1 = null;
            operando2 = null;
            operacion = "";
            realizandoOperacion = false;
            borrarPantalla = true;
        }

        /// <summary>
        /// Método para borrar el operando del TxtResultado al hacer Click en el botón CE (Clear Entry).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "0";
        }

        /// <summary>
        /// Método que se desencadena al hacer Click en el botón C (Clear).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Borra toda la operación en curso</remarks>
        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "0";
            List<string> lineas = TxtAux.Lines.ToList();

            if (lineas.Count <= 0) return;
            lineas[lineas.Count - 1] = "";
            TxtAux.Lines = lineas.ToArray();

            operacion = "";
            operando1 = null;
            realizandoOperacion = false;
        }

        /// <summary>
        /// Método para añadir la coma a la operación. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComa_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text.Contains(",")) return;

            if (borrarPantalla)
            {
                TxtResultado.Text = "0,";
                borrarPantalla = false;
            }
            else TxtResultado.Text += ",";            
        }

        /// <summary>
        /// Método para guardar el resultado en memoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            memoria = Double.Parse(TxtResultado.Text);
        }

        /// <summary>
        /// Método para sumar un resultado a la memoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSumarMemoria_Click(object sender, EventArgs e)
        {
            memoria += Double.Parse(TxtResultado.Text);
        }

        /// <summary>
        /// Método para borrar la memoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBorrarMemoria_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        /// <summary>
        /// Método para recuperar el valor almacenado en la memoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecuperarMemoria_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = memoria.ToString();
        }

        /// <summary>
        /// Método que se desencade al hacer Click en el botón 1/X.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Realiza la inversa del valor de TxtResultado</remarks>
        private void BtnInvert_Click(object sender, EventArgs e)
        {
            double resultado = (1 / (Double.Parse(TxtResultado.Text)));
            TxtResultado.Text = resultado.ToString();
        }


        /// <summary>
        /// Método para realizar una operación y devuelve el resultado.
        /// </summary>
        /// <param name="operando1">Primer operando</param>
        /// <param name="operando2">Segundo operando</param>
        /// <param name="operacion">La operación ha realizar. Admite los simbolo +, -, * y /</param>
        /// <returns>double del resultado de la operación</returns>
        private double RealizarOperacion(double? operando1, double? operando2, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = (double)(operando1 + operando2);
                    break;
                case "-":
                    resultado = (double)(operando1 - operando2);
                    break;
                case "*":
                    resultado = (double)(operando1 * operando2);
                    break;
                case "/":
                    resultado = (double)(operando1 / operando2);
                    break;
            }

            return resultado;
        }

    }
}
