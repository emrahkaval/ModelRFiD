using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModelRFiD
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (cls_main.login(txt_sicil.Text.ToString(), txt_sifre.Text.ToString()))
            {
                this.Dispose();
                cls_main.frm_model1.Enabled = true;
                cls_main.frm_model1.BringToFront();
            }
            else
            {
                MessageBox.Show("Şifrenizi yanlış girdiniz tekrar deneyin!");
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_sicil.Text = "";
            txt_sifre.Text = "";
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void txt_sifre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cls_main.login(txt_sicil.Text.ToString(), txt_sifre.Text.ToString()))
                {
                    this.Dispose();
                    cls_main.frm_model1.Enabled = true;
                    cls_main.frm_model1.BringToFront();
                }
                else
                {
                    MessageBox.Show("Şifrenizi yanlış girdiniz tekrar deneyin!");
                }
            }
        }
    }
}
