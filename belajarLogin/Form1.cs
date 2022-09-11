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
        readonly string Password = "12345";

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


        //Membuat Placeholder untuk textbox username
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if(TxtUsername.Text == "Username")
            {
                TxtUsername.Text = "";

                TxtUsername.ForeColor = Color.Black;
            }
        }

        //saat textbox username ditinggalkan dalam kondisi kosong, text username yg sebagai placeholder akan berubah menjadi warna silver
        private void TxtUsername_Leave(object sender, EventArgs e)
        {

            if (TxtUsername.Text == "")
            {
                TxtUsername.Text = "Username";

                TxtUsername.ForeColor = Color.Silver;
            }

        }


        //Membuat Placeholder untuk textbox password
        private void TxtPassword_Enter(object sender, EventArgs e)
        {

            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";

                TxtPassword.ForeColor = Color.Black;
            }

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {

            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";

                TxtPassword.ForeColor = Color.Silver;
            }

        }
    }
}
