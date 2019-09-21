using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class GiaoDienGame : Form
    {
        Timer time1;
        public GiaoDienGame()
        {
            InitializeComponent();
            time1 = new Timer();
            time1.Tick += Timer1_Tick;
            time1.Interval = 1000;
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string[] arr = new string[3];
        
        private void GiaoDienGame_Load(object sender, EventArgs e)
        {
            btnPlayA.Hide();
            time1.Enabled = !time1.Enabled;
            DapAn();

        }

        private void BtnPlayA_Click(object sender, EventArgs e)
        {
            GiaoDien gd = new GiaoDien();
            gd.Show();
            this.Hide();
        }
    
        private void BtnNext_Click(object sender, EventArgs e)
        {
            KetQua();
        }

        private void LbQuestion_Click(object sender, EventArgs e)
        {

        }

        int i = 60; //Thoi gian cua game
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i--;
            lbTime.Text = i.ToString();
            if(lbTime.Text=="0")
            {
                btnPlayA.Show();
                time1.Enabled = !time1.Enabled;
            }
        }

        //--------------------------------------------------------------
        public void DapAn()
        {
        }
        public void KetQua()
        {
        }
    }
}
