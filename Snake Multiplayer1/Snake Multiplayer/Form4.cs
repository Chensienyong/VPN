using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Snake_Multiplayer
{
    public partial class Form4 : Form
    {
        int speed = 5 , wall = 1;
        SoundPlayer choose = new SoundPlayer(@"D:\Alwin\Snake Multiplayer\Snake Multiplayer\Resources\up-down.wav");
        public Form4()
        {
            InitializeComponent();
            numericUpDown1.Value = speed;
            if (wall == 0)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            choose.Play();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            choose.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speed = (int)numericUpDown1.Value;
            if (radioButton1.Checked == true)
            {
                wall = 0;
            }
            else if(radioButton2.Checked == true)
            {
                wall = 1;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = speed;
            if (wall == 0)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wall = 1;
            speed = 5;
            numericUpDown1.Value = 5;
            radioButton2.Checked = true;
        }
    }
}
