using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_grasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPeso.Text = "";
            textBoxAltura.Text = "";
           
        }

        private void buttonCalcula_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(textBoxPeso.Text);
            double altura = Convert.ToDouble(textBoxAltura.Text)/100;//dividimos entre 100 para pasar de cm a m
            double imc = peso / (altura*altura);
            double edad = Convert.ToDouble(textBoxEdad.Text);
            if (radioButtonDeurenberg.Checked == true)
            {
                //Deurenberg %GC (% Grasa corporal) = 1,2 x (IMC) + 0,23 x (Nuestra edad) – 10,8 x (sexo) – 5,4 H=0 M=1
                if (radioButtonHombre.Checked == true)
                {
                    double igc = ((1.2 * imc) + (0.23 * edad) - (10.8 * 0) - 5.4);
                    labelResultado.Text = Convert.ToString(igc);
                }
                if (radioButtonMujer.Checked == true)
                {
                    double igc = ((1.2 * imc) + (0.23 * edad) - (10.8 * 1) - 5.4);
                    labelResultado.Text = Convert.ToString(igc);

                }
            }

          
            
        }
    }
}
