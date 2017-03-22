using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startingMileage = (int)numericUpDown1.Value;
            int EndingMileage = (int)numericUpDown2.Value;
            double mileTraved = EndingMileage- startingMileage;
            double reimburseRate = 0.39;
            double amountOwed = mileTraved * reimburseRate;

            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.", "Cannot calculate");
            }
            else
            {
                label4.Text = amountOwed.ToString();
                MessageBox.Show((numericUpDown1.Value).GetType().ToString());
            }
        }
    }
}
