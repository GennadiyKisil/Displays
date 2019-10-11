using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Displays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("List of displays:");
            foreach (Screen scr in Screen.AllScreens)
            {
                listBox1.Items.Add("Name" + scr.DeviceName);
                listBox1.Items.Add("Bounds" + scr.Bounds.ToString());
                listBox1.Items.Add("Working area" + scr.WorkingArea.ToString());
                listBox1.Items.Add("Primary screen" + scr.Primary.ToString());
                listBox1.Items.Add("End definitions.");
                listBox1.Items.Add("");
            }
        }
    }
}
