using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
    

namespace Ev_Final_4toBi
    {
        public partial class Form2 : Form
        {
            private object TextVar1;

            public object TextVar2 { get; private set; }

            public Form2()
            {
                
            }

            private void BtnProducto_Click(object sender, EventArgs e)
            {
                int Num1 = int.Parse(TextVar1.Text);
                int Num2 = int.Parse(TextVar2.Text);
                int producto = Num1 * Num2;

                MessageBox.Show("El Resultado es producto " + producto);
            }

            private void BtnSuma_Click(object sender, EventArgs e)
            {
                int Num1 = int.Parse(TextVar1.Text);
                int Num2 = int.Parse(TextVar2.Text);
                int suma = Num1 + Num2;

                MessageBox.Show("El Resultado de la Suma es " + suma);
            }

            private void BtnPotencia_Click(object sender, EventArgs e)
            {
                int n1 = int.Parse(TextVar1.Text);
                int n2 = int.Parse(TextVar2.Text);
                int n3 = 1;
                int potencia = 1;

                while (n3 != n2)
                {
                    potencia = potencia * n1;
                    n3 = n3 + 1;
                }
                MessageBox.Show("El Resultado de la potencia es " + potencia);
            }

            private void BtnDivision_Click(object sender, EventArgs e)
            {
                float Num1 = float.Parse(TextVar1.Text);
                float Num2 = float.Parse(TextVar2.Text);

                if (Num2 > 0)

                {
                    float division = Num1 / Num2;

                    MessageBox.Show("El resultado es " + division);
                }
                else
                {
                    MessageBox.Show("La Division es Indefinida");
                }
            }
        }
    }
}
