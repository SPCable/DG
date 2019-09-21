using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Demo
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int dem = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            SoundMannager.PlaySoundEF("CorrectSFX.wav");
            GiaoDienGame uig = new GiaoDienGame();       
            if(string.IsNullOrWhiteSpace(txtTenNguoiChoi.Text))
            {
                txtLoicuathay.Text = "Em chưa nhập tên kìa!";        
                if(dem==3)
                {
                    txtLoicuathay.Font = new Font(txtLoicuathay.Font.FontFamily, 12);
                    txtLoicuathay.Text = "Chưa nhập tên kìa con đĩ lồn!";
                }
                else
                {
                    dem++;
                }
            }
            else
            {
                this.Hide();
                uig.Show();
            }
        }
        void Back()
        {
      
        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {
            picmusicmute.Hide();
            PlayMusic();
            picmute.Hide();
            txtLoicuathay.Text = "Thầy chào các em!";
            txtLoicuathay.Enabled = false;
        }

        private void BtnPlayA_Click(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        WindowsMediaPlayer sound = new WindowsMediaPlayer() ;

        public void PlayMusic()
        {  
            sound.URL = "coconut_song.wav"; 
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (SoundMannager.soundef.enabled)
            {
                picmute.Show();
                SoundMannager.soundef.controls.pause();
                SoundMannager.soundef.enabled = !SoundMannager.soundef.enabled;
            }
        }
        
        private void PictureBox4_Click(object sender, EventArgs e) //xử lý nhạc nền
        {
            if (sound.enabled)
            {
                picmusicmute.Show();
                sound.controls.pause();
                sound.enabled = !sound.enabled;
            }
        }

        private void Picmute_Click(object sender, EventArgs e)
        {
            if (!SoundMannager.soundef.enabled)
            {
                picmute.Hide();
                SoundMannager.soundef.controls.play();
                SoundMannager.soundef.enabled = !SoundMannager.soundef.enabled;
            }
        }

        private void Picmusicmute_Click(object sender, EventArgs e)
        {
            if (!sound.enabled)
            {
                picmusicmute.Hide();
                sound.controls.play();
                sound.enabled = !sound.enabled;
            }
        }

        private void TxtLoicuathay_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
