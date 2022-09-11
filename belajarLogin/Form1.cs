using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belajarLogin
{
    public partial class Form1 : Form
    {
        readonly string Username = "admin";
        readonly string Password = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //fungsi agar textbox password jadi karakter bullet
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }


        //fungsi agar saat checkbox (show password) diklik, kondisi textbox password yg awalnya bullet = true, menjadi false, dan menjadi karakter huruf lagi
        private void CCBPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CCBPassword.Checked == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == Password && TxtUsername.Text == Username)
            {
                MessageBox.Show("Kamu berhasil login");

                //fungsi untuk pindah ke form berikutnya jika kondisi pertama true
                Form2 a = new Form2();
                a.Show();
                this.Hide();
            }
            else if (TxtPassword.Text == "" || TxtUsername.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }

        }
    }
}
