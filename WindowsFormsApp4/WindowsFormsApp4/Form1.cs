using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MakeMenue menu = new MakeMenue() { Randomizer = new Random() };
            button1.Text = menu.GetMenuItem();
            button2.Text = menu.GetMenuItem();
            button3.Text = menu.GetMenuItem();
            button4.Text = menu.GetMenuItem();
            button5.Text = menu.GetMenuItem();
            button6.Text = menu.GetMenuItem();
        }
    }
}
