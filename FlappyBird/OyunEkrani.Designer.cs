namespace FlappyBird
{
    partial class OyunEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunEkrani));
            this.skorText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.hightScore = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.boruTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.boruBottom = new System.Windows.Forms.PictureBox();
            this.restartImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boruTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // skorText
            // 
            this.skorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skorText.BackColor = System.Drawing.Color.Transparent;
            this.skorText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorText.Location = new System.Drawing.Point(-6, 590);
            this.skorText.Name = "skorText";
            this.skorText.Size = new System.Drawing.Size(383, 42);
            this.skorText.TabIndex = 4;
            this.skorText.Text = "Skor: 0";
            this.skorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // hightScore
            // 
            this.hightScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hightScore.BackColor = System.Drawing.Color.Transparent;
            this.hightScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hightScore.Location = new System.Drawing.Point(349, 590);
            this.hightScore.Name = "hightScore";
            this.hightScore.Size = new System.Drawing.Size(153, 42);
            this.hightScore.TabIndex = 5;
            this.hightScore.Text = "En Yüksek Skor: ";
            this.hightScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_value
            // 
            this.lbl_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_value.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value.Location = new System.Drawing.Point(494, 590);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(141, 42);
            this.lbl_value.TabIndex = 6;
            this.lbl_value.Text = "0";
            this.lbl_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boruTop
            // 
            this.boruTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boruTop.BackColor = System.Drawing.Color.Cyan;
            this.boruTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.boruTop.Location = new System.Drawing.Point(521, -2);
            this.boruTop.Name = "boruTop";
            this.boruTop.Size = new System.Drawing.Size(79, 218);
            this.boruTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruTop.TabIndex = 0;
            this.boruTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(95, 213);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(57, 44);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zemin.BackColor = System.Drawing.Color.Transparent;
            this.zemin.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(-2, 564);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(637, 79);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // boruBottom
            // 
            this.boruBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boruBottom.BackColor = System.Drawing.Color.Cyan;
            this.boruBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.boruBottom.Location = new System.Drawing.Point(455, 351);
            this.boruBottom.Name = "boruBottom";
            this.boruBottom.Size = new System.Drawing.Size(79, 223);
            this.boruBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruBottom.TabIndex = 2;
            this.boruBottom.TabStop = false;
            // 
            // restartImage
            // 
            this.restartImage.Image = ((System.Drawing.Image)(resources.GetObject("restartImage.Image")));
            this.restartImage.Location = new System.Drawing.Point(212, 180);
            this.restartImage.Name = "restartImage";
            this.restartImage.Size = new System.Drawing.Size(212, 187);
            this.restartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartImage.TabIndex = 7;
            this.restartImage.TabStop = false;
            this.restartImage.Click += new System.EventHandler(this.RestartClik);
            // 
            // OyunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(634, 641);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.restartImage);
            this.Controls.Add(this.hightScore);
            this.Controls.Add(this.boruTop);
            this.Controls.Add(this.skorText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruBottom);
            this.Name = "OyunEkrani";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OyunEkrani_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.boruTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boruTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox boruBottom;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label skorText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label hightScore;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.PictureBox restartImage;
    }
}

