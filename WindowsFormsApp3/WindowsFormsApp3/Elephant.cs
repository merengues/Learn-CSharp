using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Elephant
    {
        public string name;
        public int earSize;
        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + earSize + " inches tall.", name + " says...");
        }
    }
}
