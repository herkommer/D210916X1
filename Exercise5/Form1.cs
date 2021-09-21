using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        List<Car> Cars;

        public Form1()
        {
            InitializeComponent();

            Cars = new List<Car>();

            Cars.Add(new Car() { Km = 100, Model = "Audi" });
            Cars.Add(new Car() { Km = 300, Model = "BMW" });
            Cars.Add(new Car() { Km = 150, Model = "Audi" });

            listBox1.Items.Add($"Vi har {Cars.Count} bilar i lager.");



            //Hur många Audi har vi i lager?
            int i = Cars.Count(x => x.Model == "Audi");
            listBox1.Items.Add($"Vi har {i} Audibilar i lager");


            //Hur långt har alla våra bilar rullat i snitt?
            double d = Cars.Average(x => x.Km);
            listBox1.Items.Add($"Våra bilar har rullat {d:0.##} km i snitt.");

            //Snittkm för Audibilarna
            double j = Cars.FindAll(x => x.Model == "Audi").Average(y => y.Km);
            listBox1.Items.Add($"Våra Audibilar har rullat {j} km i snitt.");
        }
    }

    public class Car
    {
        public int Km { get; set; }
        public string Model { get; set; }
    }
}
