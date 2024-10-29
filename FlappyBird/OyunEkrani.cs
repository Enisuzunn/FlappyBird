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
    public partial class OyunEkrani : Form
    {
        int boruHızı = 8;
        int yerÇekimi = 8;
        int skor = 0;
        bool gameOver = false;
        
        public OyunEkrani()
        {
            InitializeComponent();
            zemin.Controls.Add(skorText);
            skorText.Left = 20;
            skorText.Top = 25;
            zemin.Controls.Add(hightScore);
            hightScore.Left = 450;
            hightScore.Top = 25;
            zemin.Controls.Add(lbl_value);
            lbl_value.Left = 600;
            lbl_value.Top = 25;
            RestartGame();
            lbl_value.Text = Properties.Settings.Default.h_score;

        }
         
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += yerÇekimi;
            boruBottom.Left -= boruHızı;    
            boruTop.Left -= boruHızı;
            skorText.Text = "Skor: " + skor;

            if(boruBottom.Left < -150)
            {
                boruBottom.Left = 650;
                skor++;
            }
            if (boruTop.Left < -170)
            {
                boruTop.Left = 800;
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
            if (skor > 20)
            {
                boruHızı = 17;
            }
            if (skor > 25)
            {
                boruHızı = 20;
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
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }
        public void oyunSonu()
        {
           
            gameTimer.Stop();
            skorText.Text += "  Oyun Bitti ";
            gameOver = true;
            restartImage.Enabled = true;
            restartImage.Visible = true;
            int a = Int32.Parse(lbl_value.Text);
            if(skor > a)
            {
                lbl_value.Text = skor.ToString();
                Properties.Settings.Default.h_score = lbl_value.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            
        }
        private void RestartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(95, 213);
            boruTop.Left = 800;
            boruBottom.Left = 650;
            skor = 0;
            boruHızı = 8;
            skorText.Text = "Skor: 0";
            restartImage.Enabled = false;
            restartImage.Visible = false;
            gameTimer.Start();
        }

        private void OyunEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RestartClik(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
/* Giriş: Skorun 0 olması, boru hızının 8 olması
 * Çıkış: Skorun geçtiği boru sayısı kadar artması, boru hızının skor sayılarına göre hızlanması
 * Kontrol: Skor x sayısından büyükse boru hızını şuna çıkar
 * Tekrar: Herhangi bir döngü yok
 * Matematik: i = i+1 */