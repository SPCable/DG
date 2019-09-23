namespace Demo
{
    partial class GiaoDienGame
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayA = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.txtAnswer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHighS = new System.Windows.Forms.Label();
            this.picHeart3 = new System.Windows.Forms.PictureBox();
            this.picHeart2 = new System.Windows.Forms.PictureBox();
            this.picHeart1 = new System.Windows.Forms.PictureBox();
            this.Hinh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 37);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.error_1_;
            this.pictureBox1.Location = new System.Drawing.Point(631, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Orange;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(618, 59);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(32, 24);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "60";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnPlayA
            // 
            this.btnPlayA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(215)))), ((int)(((byte)(196)))));
            this.btnPlayA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayA.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayA.ForeColor = System.Drawing.Color.Black;
            this.btnPlayA.Location = new System.Drawing.Point(479, 338);
            this.btnPlayA.Name = "btnPlayA";
            this.btnPlayA.Size = new System.Drawing.Size(177, 48);
            this.btnPlayA.TabIndex = 4;
            this.btnPlayA.Text = "Play Again?";
            this.btnPlayA.UseVisualStyleBackColor = false;
            this.btnPlayA.Click += new System.EventHandler(this.BtnPlayA_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(248, 338);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(177, 48);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score: ";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(556, 53);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(16, 16);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "0";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAnswer.HintForeColor = System.Drawing.Color.Empty;
            this.txtAnswer.HintText = "";
            this.txtAnswer.isPassword = false;
            this.txtAnswer.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAnswer.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAnswer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAnswer.LineThickness = 6;
            this.txtAnswer.Location = new System.Drawing.Point(145, 248);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(398, 60);
            this.txtAnswer.TabIndex = 11;
            this.txtAnswer.Text = "Your Answer";
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Highscore: ";
            // 
            // lbHighS
            // 
            this.lbHighS.AutoSize = true;
            this.lbHighS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighS.Location = new System.Drawing.Point(556, 74);
            this.lbHighS.Name = "lbHighS";
            this.lbHighS.Size = new System.Drawing.Size(16, 16);
            this.lbHighS.TabIndex = 16;
            this.lbHighS.Text = "0";
            // 
            // picHeart3
            // 
            this.picHeart3.Image = global::Demo.Properties.Resources.icons8_pastel_64;
            this.picHeart3.Location = new System.Drawing.Point(120, 37);
            this.picHeart3.Name = "picHeart3";
            this.picHeart3.Size = new System.Drawing.Size(60, 64);
            this.picHeart3.TabIndex = 14;
            this.picHeart3.TabStop = false;
            // 
            // picHeart2
            // 
            this.picHeart2.Image = global::Demo.Properties.Resources.icons8_pastel_64;
            this.picHeart2.Location = new System.Drawing.Point(60, 37);
            this.picHeart2.Name = "picHeart2";
            this.picHeart2.Size = new System.Drawing.Size(60, 64);
            this.picHeart2.TabIndex = 13;
            this.picHeart2.TabStop = false;
            // 
            // picHeart1
            // 
            this.picHeart1.Image = global::Demo.Properties.Resources.icons8_pastel_64;
            this.picHeart1.Location = new System.Drawing.Point(0, 37);
            this.picHeart1.Name = "picHeart1";
            this.picHeart1.Size = new System.Drawing.Size(60, 64);
            this.picHeart1.TabIndex = 12;
            this.picHeart1.TabStop = false;
            // 
            // Hinh
            // 
            this.Hinh.Location = new System.Drawing.Point(248, 93);
            this.Hinh.Name = "Hinh";
            this.Hinh.Size = new System.Drawing.Size(177, 151);
            this.Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hinh.TabIndex = 9;
            this.Hinh.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.circle_64;
            this.pictureBox2.Location = new System.Drawing.Point(602, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // GiaoDienGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.lbHighS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHeart3);
            this.Controls.Add(this.picHeart2);
            this.Controls.Add(this.picHeart1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.Hinh);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayA);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoDienGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDienGame";
            this.Load += new System.EventHandler(this.GiaoDienGame_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayA;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAnswer;
        private System.Windows.Forms.PictureBox Hinh;
        private System.Windows.Forms.PictureBox picHeart1;
        private System.Windows.Forms.PictureBox picHeart3;
        private System.Windows.Forms.PictureBox picHeart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHighS;
    }
}