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
using System.IO;

namespace Snake_Multiplayer
{
    public partial class Form4 : Form
    {
        int speed = 5, wall = 1;
        SoundPlayer choose = new SoundPlayer("Music/up-down.wav");
        private string data()
        {
            if (new FileInfo("setting.dat").Exists)
                return File.ReadAllText("setting.dat");
            else
                return "";
        }
        public Form4()
        {
            InitializeComponent();
            if (data().Length > 0)
            {
                string[] tmp=data().Split(' ');
                speed = int.Parse(tmp[0]);
                wall = int.Parse(tmp[1]);
            }
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
            File.WriteAllText("setting.dat", speed.ToString()+" "+wall.ToString());
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown1.Maximum)
            {
                numericUpDown1.Value = numericUpDown1.Maximum;
            }
            if (numericUpDown1.Value < numericUpDown1.Minimum)
            {
                numericUpDown1.Value = numericUpDown1.Minimum;
            }
        }
    }
}
