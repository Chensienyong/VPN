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
    public partial class Form3 : Form
    {
        SoundPlayer choose = new SoundPlayer(@"D:\Alwin\Snake Multiplayer\Snake Multiplayer\Resources\up-down.wav");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            choose.Play();
        }
    }
}
