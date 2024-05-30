using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        int bot = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            btnTas2.BackColor = Color.White;
            btnKagit2.BackColor = Color.White;
            btnMakas2.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                btnTas2.BackColor = Color.Yellow;
                lblDurum.Text = "Berabere";
            }
            else if (deger == 2)
            {
                bot++;
                label2.Text = bot.ToString();
                btnKagit2.BackColor = Color.DarkRed;
                lblDurum.Text = "Kaybettiniz";
            }
            else if (deger == 3)
            {
                score++;
                label1.Text = score.ToString();
                btnMakas2.BackColor = Color.Green;
                lblDurum.Text = "Kazandınız";
            }
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            btnTas2.BackColor = Color.White;
            btnKagit2.BackColor = Color.White;
            btnMakas2.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                score++;
                label1.Text = score.ToString();
                btnTas2.BackColor = Color.Green;
                lblDurum.Text = "Kazandınız";
            }
            else if (deger == 2)
            {
                btnKagit2.BackColor = Color.Yellow;
                lblDurum.Text = "Berabere";
            }
            else if (deger == 3)
            {
                bot++;
                label2.Text = bot.ToString();
                btnMakas2.BackColor = Color.DarkRed;
                lblDurum.Text = "Kaybettiniz";
            }
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            btnTas2.BackColor = Color.White;
            btnKagit2.BackColor = Color.White;
            btnMakas2.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                bot++;
                label2.Text = bot.ToString();
                btnTas2.BackColor = Color.DarkRed;
                lblDurum.Text = "Kaybettiniz";
            }
            else if (deger == 2)
            {
                score++;
                label1.Text = score.ToString();
                btnKagit2.BackColor = Color.Green;
                lblDurum.Text = "Kazandınız";
            }
            else if (deger == 3)
            {
                btnMakas2.BackColor = Color.Yellow;
                lblDurum.Text = "Berabere";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score == 3)
            {
                lblDurum.Text = "Kazandınız";
                btnKagit.Enabled = false;
                btnKagit2.Enabled = false;
                btnMakas.Enabled = false;
                btnMakas2.Enabled = false;
                btnTas.Enabled = false;
                btnTas2.Enabled = false;
                
            }
            else if (bot == 3)
            {
                lblDurum.Text = "Kaybettiniz";
                btnKagit.Enabled = false;
                btnKagit2.Enabled = false;
                btnMakas.Enabled = false;
                btnMakas2.Enabled = false;
                btnTas.Enabled = false;
                btnTas2.Enabled = false;
            }
        }
    }
}
