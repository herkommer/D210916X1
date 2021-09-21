using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.Text = "+";
            button3.Text = "-";

            button2.Click += new EventHandler(ButtonHandler);
            button2.Click += new EventHandler(ButtonHandler);
            button3.Click += new EventHandler(ButtonHandler);

            //Anonym metod, dvs vi har kod direkt utan funktionsnamn
            //via en delegate så får vi tag på pekaren direkt
            button4.Click += new EventHandler(
                    delegate 
                    { 
                        MessageBox.Show($"Du klickade!!");
                        //Tar bort prenumerationen för Button2
                        button2.Click -= new EventHandler(ButtonHandler);

                    });

            //Anonym metod, men nu med Lambda/Arrow Syntax
            button5.Click += new EventHandler(
                    (anka, swan) =>
                    {
                        MessageBox.Show($"{(anka as Button).Text} Clicked!");
                    }
                );

        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show($"Du klickade {btn.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Du klickade {(sender as Button).Text}");
        }
    }
}
