using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Calculator : Form
    {
        CalculationEngine MyEngine = new CalculationEngine();

        public Calculator()
        {
            InitializeComponent();

            button1.Text = "+";
            btnMultiply.Text = "*";

            btnDivide.Text = "/";
            btnDivide.Click += new EventHandler(CalculationHandler);

            //Vi vill kontrollera textboxen, så att endast 0-9 kan accepteras
            textBox1.KeyPress += new KeyPressEventHandler(KeyPressControl);
        }

        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                //Not a number
                //hmm we need to handle Backspace

                //Handled avbryter flödet till textboxen,
                //genom att lura den att det redan är hanterat
                if (((short)e.KeyChar) != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void CalculationHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string operation = btn.Text;
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);
            double answer = 0;

            try
            {
                switch (operation)
                {
                    case "/":
                        answer = MyEngine.Divide(number1, number2);
                        break;

                    default:
                        break;
                }

                PresentResult(number1, number2, answer, operation);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Oops, 0 är inte tillåtet");
                textBox2.Focus();
            }
            catch (Exception anka)
            {
                MessageBox.Show("Annat fel: " + anka.Message);
            }
        }

        //Add
        private void button1_Click(object sender, EventArgs e)
        {
            //1-hitta indata
            //2-beräkna
            //3-presentera resultatet

            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = MyEngine.Add(i, j);

            //Button b = sender as Button; //Omvandlar sender från object -> button
            //b.Text

            PresentResult(i, j, answer, (sender as Button).Text);
        }

        private static void PresentResult(double i, double j, double answer, string operation)
        {
            MessageBox.Show($"{i} {operation} {j} = {answer}");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = MyEngine.Multiply(i, j);

            PresentResult(i, j, answer, (sender as Button).Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = MyEngine.Divide(i, j);

            PresentResult(i, j, answer, (sender as Button).Text);
        }

    }
}
