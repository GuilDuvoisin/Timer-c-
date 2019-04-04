using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int secondInt = Convert.ToInt32(second.Text);
            if (secondInt < 59)
            {
                second.Text = Convert.ToString(secondInt + 1); 
            }
            else
            {
                second.Text = "0";
                int minutesInt = Convert.ToInt32(Minutes.Text);
                if (minutesInt < 59)
                {
                    Minutes.Text = Convert.ToString(minutesInt + 1);
                }
                else
                {
                    Minutes.Text = "0";
                    int HeureInt = Convert.ToInt32(Heure.Text);
                    if (HeureInt < 59)
                    {
                        Heure.Text = Convert.ToString(HeureInt + 1);
                    }
                    else
                    {
                        Heure.Text = "0";
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }
    }

