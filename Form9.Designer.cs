namespace project001
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxInsta = new System.Windows.Forms.PictureBox();
            this.pictureBoxYouTube = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYouTube)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(144, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebook.Image")));
            this.pictureBoxFacebook.Location = new System.Drawing.Point(397, 597);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(64, 50);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 3;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // pictureBoxInsta
            // 
            this.pictureBoxInsta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInsta.Image")));
            this.pictureBoxInsta.Location = new System.Drawing.Point(284, 597);
            this.pictureBoxInsta.Name = "pictureBoxInsta";
            this.pictureBoxInsta.Size = new System.Drawing.Size(62, 50);
            this.pictureBoxInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInsta.TabIndex = 4;
            this.pictureBoxInsta.TabStop = false;
            this.pictureBoxInsta.Click += new System.EventHandler(this.pictureBoxInsta_Click);
            // 
            // pictureBoxYouTube
            // 
            this.pictureBoxYouTube.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYouTube.Image")));
            this.pictureBoxYouTube.Location = new System.Drawing.Point(171, 597);
            this.pictureBoxYouTube.Name = "pictureBoxYouTube";
            this.pictureBoxYouTube.Size = new System.Drawing.Size(64, 50);
            this.pictureBoxYouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYouTube.TabIndex = 5;
            this.pictureBoxYouTube.TabStop = false;
            this.pictureBoxYouTube.Click += new System.EventHandler(this.pictureBoxYouTube_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxFacebook);
            this.panel1.Controls.Add(this.pictureBoxInsta);
            this.panel1.Controls.Add(this.pictureBoxYouTube);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 2000);
            this.panel1.TabIndex = 6;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(177)))), ((int)(((byte)(220)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1554, 953);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GUN 4 PEACE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYouTube)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxInsta;
        private System.Windows.Forms.PictureBox pictureBoxYouTube;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}