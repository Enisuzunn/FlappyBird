using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int yerÇekimi = 15;
        int skor = 0;
        public Form1()
        {
            InitializeComponent();
        }
         
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += yerÇekimi;
            boruBottom.Left -= boruHızı;
            boruTop.Left -= boruHızı;
            skorText.Text = "Skor: " + skor;

            if(boruBottom.Left < -150)
            {
                boruBottom.Left = 700;
                skor++;
            }
            if (boruTop.Left < -170)
            {
                boruTop.Left = 850;
                skor++;
            }
            if (flappyBird.Bounds.IntersectsWith(boruBottom.Bounds)||flappyBird.Bounds.IntersectsWith(boruTop.Bounds)||flappyBird.Bounds.IntersectsWith(zemin.Bounds)|| flappyBird.Top < -25)
            {
                oyunSonu();
            }
            if(skor>5)
            {
                boruHızı = 10;
            }
            if (skor > 10)
            {
                boruHızı = 13;
            }
            if (skor > 15)
            {
                boruHızı = 15;
            }

        }

        private void gamekeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                yerÇekimi = -15;
            }
        }

        private void gamekeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerÇekimi = 5;
            }
        }
        private void oyunSonu()
        {
            gameTimer.Stop();
            skorText.Text += " Oyun Bitti";
        }
    }
}
