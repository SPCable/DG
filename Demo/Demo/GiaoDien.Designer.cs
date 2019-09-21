namespace Demo
{
    partial class GiaoDien
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNguoiChoi = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picmusicmute = new System.Windows.Forms.PictureBox();
            this.picmute = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtLoicuathay = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmusicmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 37);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "DoubleE";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FVF Fernando 08", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(181, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mời em nhập tên:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtTenNguoiChoi
            // 
            this.txtTenNguoiChoi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTenNguoiChoi.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiChoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenNguoiChoi.Location = new System.Drawing.Point(193, 163);
            this.txtTenNguoiChoi.Multiline = true;
            this.txtTenNguoiChoi.Name = "txtTenNguoiChoi";
            this.txtTenNguoiChoi.Size = new System.Drawing.Size(300, 53);
            this.txtTenNguoiChoi.TabIndex = 2;
            this.txtTenNguoiChoi.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(215)))), ((int)(((byte)(196)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.Font = new System.Drawing.Font("FVF Fernando 08", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(251, 229);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(177, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Let\'s Play";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // picmusicmute
            // 
            this.picmusicmute.Image = global::Demo.Properties.Resources._478857_200;
            this.picmusicmute.Location = new System.Drawing.Point(592, 362);
            this.picmusicmute.Name = "picmusicmute";
            this.picmusicmute.Size = new System.Drawing.Size(37, 37);
            this.picmusicmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmusicmute.TabIndex = 9;
            this.picmusicmute.TabStop = false;
            this.picmusicmute.Click += new System.EventHandler(this.Picmusicmute_Click);
            // 
            // picmute
            // 
            this.picmute.Image = global::Demo.Properties.Resources.mute_icon_29_jpg;
            this.picmute.Location = new System.Drawing.Point(560, 365);
            this.picmute.Name = "picmute";
            this.picmute.Size = new System.Drawing.Size(30, 30);
            this.picmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmute.TabIndex = 8;
            this.picmute.TabStop = false;
            this.picmute.Click += new System.EventHandler(this.Picmute_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Demo.Properties.Resources._2;
            this.pictureBox5.Location = new System.Drawing.Point(0, 219);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(186, 186);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Demo.Properties.Resources._122320;
            this.pictureBox4.Location = new System.Drawing.Point(596, 365);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Demo.Properties.Resources.volume_512;
            this.pictureBox3.Location = new System.Drawing.Point(560, 365);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources._27304b9b14ce9bd8a28ca637ed92070e_blue_circle_question_mark_icon_by_vexels;
            this.pictureBox2.Location = new System.Drawing.Point(632, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txtLoicuathay
            // 
            this.txtLoicuathay.BackColor = System.Drawing.Color.White;
            this.txtLoicuathay.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLoicuathay.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoicuathay.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLoicuathay.BorderThickness = 3;
            this.txtLoicuathay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoicuathay.Font = new System.Drawing.Font("FVF Fernando 08", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoicuathay.ForeColor = System.Drawing.Color.Black;
            this.txtLoicuathay.isPassword = false;
            this.txtLoicuathay.Location = new System.Drawing.Point(193, 297);
            this.txtLoicuathay.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoicuathay.Name = "txtLoicuathay";
            this.txtLoicuathay.Size = new System.Drawing.Size(300, 77);
            this.txtLoicuathay.TabIndex = 11;
            this.txtLoicuathay.Text = "Thầy chào các em!";
            this.txtLoicuathay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoicuathay.OnValueChanged += new System.EventHandler(this.TxtLoicuathay_OnValueChanged);
            // 
            // GiaoDien
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.txtLoicuathay);
            this.Controls.Add(this.picmusicmute);
            this.Controls.Add(this.picmute);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTenNguoiChoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmusicmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenNguoiChoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picmute;
        private System.Windows.Forms.PictureBox picmusicmute;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLoicuathay;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

