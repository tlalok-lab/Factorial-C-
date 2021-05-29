using System;
using System.Windows.Forms;

namespace U4_A7
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private  double fact(double num)
        {
            
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                num = num * fact(num - 1);
                return num;
            }



            /* Console.WriteLine(num);*/
            /*return num;*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* fact(num);*/
            double num;
            num = double.Parse(textBox1.Text);
            label2.Text = fact(num).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Validacion de solo numeros*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) )
            {
                MessageBox.Show("Ingresa solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
