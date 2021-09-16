using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        //Constructor
        //dvs, denna kod körs vid NEW
        public Form1()
        {
            //Denna metod, kommer nu se till att 
            //köra kod för att skapa alla UI komponenter
            InitializeComponent();

            //Nu är vårt formulär klart och redo att användas
            button1.Text = "Click me!";
        }

        private void button1_Clickk(object sender, EventArgs e)
        {
            //MessageBox.Show("Vem var det som kasta! " + sender.GetType());
            textBox1.Text = "Kilroy was here";
        }

        private void Klicker(object sender, EventArgs e)
        {
            textBox1.Text = "Kilroy was here";
        }
    }
}
