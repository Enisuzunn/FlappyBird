namespace FlappyBird
{
    partial class Form1
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
            this.boruTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.boruBottom = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.skorText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boruTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // boruTop
            // 
            this.boruTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boruTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.boruTop.Location = new System.Drawing.Point(439, -13);
            this.boruTop.Name = "boruTop";
            this.boruTop.Size = new System.Drawing.Size(95, 248);
            this.boruTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruTop.TabIndex = 0;
            this.boruTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(49, 241);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(71, 52);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // boruBottom
            // 
            this.boruBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boruBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.boruBottom.Location = new System.Drawing.Point(527, 361);
            this.boruBottom.Name = "boruBottom";
            this.boruBottom.Size = new System.Drawing.Size(95, 278);
            this.boruBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruBottom.TabIndex = 2;
            this.boruBottom.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zemin.Image = global::FlappyBird.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(-2, 560);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(677, 79);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // skorText
            // 
            this.skorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skorText.BackColor = System.Drawing.SystemColors.Info;
            this.skorText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorText.Location = new System.Drawing.Point(21, 579);
            this.skorText.Name = "skorText";
            this.skorText.Size = new System.Drawing.Size(326, 42);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(674, 639);
            this.Controls.Add(this.boruTop);
            this.Controls.Add(this.skorText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.boruTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boruTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox boruBottom;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label skorText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

