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
    public partial class BaslangicEkrani : Form
    {
        public BaslangicEkrani()
        {
            InitializeComponent();
            
           
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            OyunEkrani oyunekrani = new OyunEkrani();
            oyunekrani.Show();
            this.Hide();
      
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            helpEkrani helpEkrani = new helpEkrani();
            helpEkrani.ShowDialog();
        }

        
    }
}
