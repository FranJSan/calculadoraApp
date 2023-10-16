using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * TODO: 
 * Repasar la escritura de la coma, después de realizar una operación no funciona del todo como se espera.
 * Repasar la introducción de los dígitos. En escenarios concretos no se digitan como debe.
 * Repensar y revisar el establecimiento de la operación que se está llevando a cabo.
 * Poner areatexto adicional que vaya mostrando la operación? -> solo si da tiempo. Primero acabar con la funcionalidad básica y eliminar posibles errores.
 */

namespace calculadoraApp
{
    public partial class Form1 : Form
    {
        // variables para las operaciones
        double operando1 = 0;
        double operando2 = 0;
        string operacion = "";
        bool realizandoOperacion = false;


        // variable para botones de memoria
        double memoria = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            operando1 = Double.Parse(textAreaResultado.Text);
            textAreaResultado.Text = "0";
            realizandoOperacion = true;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textAreaResultado.Text.Equals("0")) {
                textAreaResultado.Text = btn.Text; 
            } else
            {
                textAreaResultado.Text += btn.Text;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (realizandoOperacion == false)
            {
                return;
            }
            operando2 = Double.Parse(textAreaResultado.Text);
            double resultado = 0;
            switch (operacion)
            {
                case "/":
                    resultado = operando1 / operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
            }

            textAreaResultado.Text = resultado.ToString();
            operando1 = 0;
            operando2 = 0;
            operacion = "";
            realizandoOperacion = false;
        }

        private void btnBorrarOperando_Click(object sender, EventArgs e)
        {
            textAreaResultado.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textAreaResultado.Text = "0";
            operacion = "";
            realizandoOperacion = false;
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (textAreaResultado.Text.Contains(",")) return;
            else textAreaResultado.Text += ",";

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            memoria = Double.Parse(textAreaResultado.Text);
        }

        private void btnSumarMemoria_Click(object sender, EventArgs e)
        {
            memoria += Double.Parse(textAreaResultado.Text);
        }

        private void btnBorrarMemoria_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btnRecuperarMemoria_Click(object sender, EventArgs e)
        {
            textAreaResultado.Text = memoria.ToString();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            double resultado = (1 / (Double.Parse(textAreaResultado.Text)));
            textAreaResultado.Text = resultado.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
