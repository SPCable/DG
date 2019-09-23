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
        String[] list;
        int index;
        int[] listusedindex;
        int usedindex;
        private void GiaoDienGame_Load(object sender, EventArgs e)
        {
            btnPlayA.Hide();
            time1.Enabled = !time1.Enabled;
            DapAn();
            list = new String[15];

            listusedindex = new int[15];

            for (int i = 1; i <= list.Length; ++i)
            {
                list[i - 1] = "Hinh/" + i + ".png";
            }
            Random rd = new Random();
            index = rd.Next(0, list.Length);

            usedindex = 0;
            listusedindex[usedindex] = index;

            Hinh.BackgroundImage = Image.FromFile(list[index]);
            Hinh.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void BtnPlayA_Click(object sender, EventArgs e)
        {
            GiaoDien gd = new GiaoDien();
            gd.Show();
            this.Hide();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            bool check;
            do
            {
                Random rd = new Random();
                index = rd.Next(0, list.Length);
                check = true;
                for (int i = 0; i <= usedindex; ++i)
                {
                    if (listusedindex[i] == index)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Hinh.BackgroundImage = Image.FromFile(list[index]);
                    Hinh.BackgroundImageLayout = ImageLayout.Stretch;
                    listusedindex[++usedindex] = index;
                }
            } while (check == false);
            if (usedindex == listusedindex.Length - 1)
            {
                MessageBox.Show("Hết hình rồi em!!!");
            }

        }

        private void LbQuestion_Click(object sender, EventArgs e)
        {

        }

        int i = 60; //Thoi gian cua game
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i--;
            lbTime.Text = i.ToString();
            if (lbTime.Text == "0")
            {
                btnPlayA.Show();
                time1.Enabled = !time1.Enabled;
            }
        }

        //--------------------------------------------------------------

        public void DapAn()
        {

        }
        String[] ketqua;
        public void KetQua()
        {
            ketqua = new String[15];
            for (int i = 0; i < ketqua.Length; ++i)
            {
                ketqua[i - 1] = "Ket_qua/" + i + ".txt";
            }
        }

        private void txtAnswer_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Hinh_Click(object sender, EventArgs e)
        {

        }

        private void Hinh_Click_1(object sender, EventArgs e)
        {

        }
    }
}
