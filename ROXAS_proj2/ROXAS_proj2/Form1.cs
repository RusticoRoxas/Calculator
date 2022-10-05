using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROXAS_proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "1");
                screenIO.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "2");
                screenIO.Text = text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "3");
                screenIO.Text = text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "4");
                screenIO.Text = text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "5");
                screenIO.Text = text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "6");
                screenIO.Text = text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "7");
                screenIO.Text = text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "8");
                screenIO.Text = text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "9");
                screenIO.Text = text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "0");
                screenIO.Text = text;
            }
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, ".");
                screenIO.Text = text;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "+");
                screenIO.Text = text;
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "-");
                screenIO.Text = text;
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "*");
                screenIO.Text = text;
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if(screenIO.Text.Length >= 16)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text;
                text = String.Concat(screenIO.Text, "/");
                screenIO.Text = text;
            }

        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (screenIO.Text.Length == 0)
            {
                // do nothing
                // yes, this is intended
            }
            else
            {
                String text = screenIO.Text.Remove(screenIO.Text.Length - 1, 1);
                screenIO.Text = text;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String input = screenIO.Text;
            String output = Convert.ToString(dt.Compute(input, ""));
            screenIO.Text = output;
        }
    }
}
