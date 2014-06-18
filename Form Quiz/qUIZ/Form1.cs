using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qUIZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox input = new TextBox();
        Button krg = new Button();
        Button tbh = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            input.Location = new Point(20, 20);
            input.Size = new Size(100,20);
            krg.Location = new Point(20, 40);
            tbh.Location = new Point(20, 100);
            krg.Text = "Hapus";
            tbh.Text = "Tambah";
            tbh.Click += new EventHandler(tambah);
            krg.Enabled = false;
            krg.Click += new EventHandler(hapus);
            this.Controls.AddRange(new Control[] {input,krg,tbh});
        }

        private void hapus(object sender, EventArgs e)
        {
           /* foreach(Control i in this.Controls)
            {
                if (i.Name.Length > 0)
                {
                    //if (i.Name.Substring(0, 2) == "tb")
                    {
                        Controls.Remove(i);
                    }
                }

            }*/
            Controls.Clear();
            Form1_Load(sender,e);
            krg.Enabled = false;
            tbh.Enabled = true;
            input.Enabled = true;
        }
        TextBox[] tb = new TextBox[0];
        private void tambah(object sender, EventArgs e)
        {
            int a=int.Parse(input.Text);
            Array.Resize(ref tb, tb.Length + (a*a));
            for (int i = 0; i < a; i++)
            {
                for(int j=0; j<a;j++)
                {
                    tb[a*i+j] = new TextBox();
                    tb[a * i + j].Name = "tb" + (a * i + j).ToString();
                    tb[a * i + j].Size = new Size(20, 20);
                    tb[a * i + j].Location = new Point(200 + (j * 21), 20 + (i * 21));
                    //tb[a * i + j].Text = (a * i + j).ToString();
                    this.Controls.Add(tb[a*i+ j]);
                }
            }
            krg.Enabled = true;
            tbh.Enabled = false;
            input.Enabled = false;

        }
    }
}
