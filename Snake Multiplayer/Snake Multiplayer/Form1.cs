﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Media;

namespace Snake_Multiplayer
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        SoundPlayer choose = new SoundPlayer(@"D:\Alwin\Snake Multiplayer\Snake Multiplayer\Resources\up-down.wav");
=======
        SoundPlayer choose = new SoundPlayer("D:/Flashdisk/up-down");
>>>>>>> 642e015509c9f180041690db24add3d0ee00ca0b
        public Form1()
        {
            InitializeComponent();
            toolStripProgressBar1.Value = 0;
        }
        public bool button4click = false;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripProgressBar1.Visible = true;
        }
<<<<<<< HEAD

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            form2.FormClosed += new FormClosedEventHandler(muncul);
        }

=======
>>>>>>> 642e015509c9f180041690db24add3d0ee00ca0b
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            form3.FormClosed += new FormClosedEventHandler(muncul);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value += 1;
            toolStripStatusLabel2.Text = toolStripProgressBar1.Value + "%";
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                timer1.Enabled = false;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel2.Text = "Complete";
                this.Hide();
<<<<<<< HEAD
                Process.Start("Console Snake.exe").WaitForExit();
                this.Show();
=======
                if (button4click)
                {
                    button4click = false;
                    Process.Start("Console Snake.exe", "2").WaitForExit();
                }
                else
                {
                    Process.Start("Console Snake.exe", "1").WaitForExit();
                    if (new FileInfo("score.dat").Exists)
                        label1.Text = "Hi-Score : " + File.ReadAllText("score.dat");
                    else
                        label1.Text = "Hi-Score : 0";
                }
                this.Show();                
>>>>>>> 642e015509c9f180041690db24add3d0ee00ca0b
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Start the game";
            choose.Play();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "See How to Play snake";
            choose.Play();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "See the credit of the snake multiplayer";
            choose.Play();
        }

        private void muncul(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            form2.FormClosed+=new FormClosedEventHandler(muncul);
        }

        private void muncul(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4click = true;
            timer1.Enabled = true;
            toolStripProgressBar1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (new FileInfo("score.dat").Exists)
                label1.Text ="Hi-Score : "+ File.ReadAllText("score.dat");
            else
                label1.Text = "Hi-Score : 0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FileInfo("score.dat").Delete();
            label1.Text ="Hi-Score : 0";
        }
    }
}
