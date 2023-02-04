using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            int valor = Convert.ToInt32(ValorTextBox.Text); //variable para llamar la caja de texto
            String resultado = Convert.ToString(ResultadoTextBox); //variable para la caja de resultado 
            String resultado2 = ""; //variable para 

            resultado = ParImpar(valor); //Llamado de la función de numero Par o Impar
            resultado2 = PositivoNegativo(valor); //Llamado de la función de numero Positivo o Negativo
            ResultadoTextBox.Text = Convert.ToString("El Número Ingresado es "+resultado+" y "+resultado2); //Resultado
        }

        //FUNCIÓN para indicar si es Número Par o Impar
        private String ParImpar(int num)
        {
            //Condición simple
            if (num % 2 == 0) //Si residuo es igual a cero numero es par
            {
                ResultadoTextBox.Text = "Par";
            }
            else //Si no, numero es impar
            {
                ResultadoTextBox.Text = "Impar";
            }
            //Retorna el resultado de la condición
            return ResultadoTextBox.Text;
        }

        //FUNCIÓN para indicar si es número Positivo o Negativo
        private String PositivoNegativo(int num)
        {
            //Condición simple
            if (num >= 1) //Si numero mayor o igual a 1 es Positivo
            {
                ResultadoTextBox.Text = "Positivo";
            }
            else if (num <= -1) //Si numero menor o igual a -1 es Negativo
            {
                ResultadoTextBox.Text = "Negativo";
            }
            //Retorna el resultado de la condición 
            return ResultadoTextBox.Text;
        }
    }
}
