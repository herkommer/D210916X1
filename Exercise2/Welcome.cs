using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            i = int.Parse(textBox1.Text);   //C#
            j = Int32.Parse(textBox2.Text); //Common Type System

            //MessageBox.Show($"{i} + {j} = {i+j}");    //Modal
            listBox1.Items.Add($"{i} + {j} = {i + j}");
        }
    }
}
