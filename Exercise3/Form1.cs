﻿using System;
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


        }

        //Add
        private void button1_Click(object sender, EventArgs e)
        {
            //1-hitta indata
            //2-beräkna
            //3-presentera resultatet

            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);

            int answer = MyEngine.Add(i, j);

            //Button b = sender as Button; //Omvandlar sender från object -> button
            //b.Text

            PresentResult(i, j, answer, (sender as Button).Text);
        }

        private static void PresentResult(int i, int j, int answer, string operation)
        {
            MessageBox.Show($"{i} {operation} {j} = {answer}");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);

            int answer = MyEngine.Multiply(i, j);

            PresentResult(i, j, answer, (sender as Button).Text);
        }
    }
}