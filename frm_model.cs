using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.RFID3;

namespace ModelRFiD
{
    public partial class frm_model : Form
    {
        //List<string> gt_tags = new List<string>();
        cls_rfid rfid;
        int counter = 0;
        public frm_model()
        {
                InitializeComponent();
        }

        private void frm_mdi_Load(object sender, EventArgs e)
        {
            if (cls_main.ini_read("config.ini"))
            {
                cls_main.frm_model1.Enabled = false;
                cls_main.frm_model1.Enabled = true;
                //frm_login frm_login1 = new frm_login();
                //frm_login1.Show();
                //frm_login1.StartPosition = FormStartPosition.CenterScreen;
            }
            cls_main.gv_hat = "M500200";
            rfid = new cls_rfid(cls_main.rdrip);
            rfid.NewTagEvent += rfid_NewTagEvent;
            rfid.ConnectionStatusEvent += rfid_ConnectionStatusEvent;
            tssb_reconnect.Visible = false;
            asama(1);
        }

        void rfid_ConnectionStatusEvent(bool status)
        {
            if (!status)
            {
                ti_rfid_reconnect.Enabled = true;
            }
            else
            {
                ti_rfid_reconnect.Enabled = false;
            }
        }
        private void rfid_NewTagEvent(string lv_tag)
        {
            dgv_tags.Invoke(new EventHandler(delegate
            {
                bool lv_found = false;

                foreach (DataGridViewRow dgvr_tag in dgv_tags.Rows)
                {
                    if (dgvr_tag.Cells[0].Value.ToString() == lv_tag)
                    {
                        lv_found = true;
                        dgvr_tag.Cells[1].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dgvr_tag.Cells[2].Value = (Convert.ToInt32(dgvr_tag.Cells[2].Value) + 1).ToString();
                    }
                }
                if (lv_found == false)
                {
                    dgv_tags.Rows.Add(lv_tag, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "1");

                }
            }));
        }
        

        private void ti_time_Tick(object sender, EventArgs e)
        {
            tss_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void ti_rfid_status_Tick(object sender, EventArgs e)
        {
            
            if (rfid.rfid3 != null)
            {
                if (!rfid.rfid3.IsConnected)
                {
                    if (rfid.connecting)
                    {
                        tss_status.BackColor = Color.Yellow;
                    }
                    else
                    {
                        tss_status.BackColor = Color.Red;
                        tssb_reconnect.Visible = true;
                    }
                }
                else
                {
                    tss_status.BackColor = Color.Green;
                    tssb_reconnect.Visible = false;
                }
            }
            else
            {
                tss_status.BackColor = Color.Blue;
            }
        }

        private void ti_rfid_reconnect_Tick(object sender, EventArgs e)
        {
                if (!rfid.connecting)
                {
                    rfid.connect();
                }
        }

        private void frm_model_EnabledChanged(object sender, EventArgs e)
        {
            ti_rfid_status.Enabled = this.Enabled;
        }

        private void fill_dgv_mdl()
        {
            string lv_matnr = "";
            string lv_maktx = "";
            dgv_mdl.Rows.Clear();
            if (dgv_tags.SelectedRows.Count > 1)
            {
                cls_main.GET_MDL_MATNR(dgv_tags.SelectedRows[0].Cells[0].Value.ToString(), dgv_tags.SelectedRows[1].Cells[0].Value.ToString(), out lv_matnr,out lv_maktx);
                dgv_mdl.Rows.Add(lv_matnr,lv_maktx);
            }
            else if (dgv_tags.SelectedRows.Count == 0)
            {
                dgv_mdl.Rows.Clear();    
            }
            else
            {
                foreach(DataRow dr in cls_main.GET_MDL_LIST(dgv_tags.SelectedRows[0].Cells[0].Value.ToString()).Rows)
                {
                    dgv_mdl.Rows.Add(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString());
                }

            }                    
            
        }

        private bool fill_dgv_matnr()
        {
            dgv_mlz.Rows.Clear();
            DataTable lv_dt_matnr = new DataTable();
            lv_dt_matnr = cls_main.GET_MATNR_LIST(dgv_mdl.Rows[0].Cells[0].Value.ToString(), cls_main.gv_hat.ToString());
            if (lv_dt_matnr.Rows.Count > 0)
            {
                foreach( DataRow dr in lv_dt_matnr.Rows)
                {
                    dgv_mlz.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString().Replace(".000", ""), dr[2].ToString().Replace(".000", ""), "▼", "▲");
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_mdl_Click(object sender, EventArgs e)
        {
            if (dgv_mdl.Rows.Count == 1)
            {
                if (dgv_mdl.Rows[0].Cells[0].Value.ToString() != "DNM")
                {
                    asama(2);
                    fill_dgv_matnr();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz taglara karşılık bir model bulunamadı ana veri bakımı yapınız!!!");
                }
                
            }
            else if (dgv_mdl.Rows.Count > 1)
	        {
                MessageBox.Show("Model Listesinde birden fazla model bulunamaz bir tag daha seçin!!!");
	        }
            else
            {
                MessageBox.Show("Model Listesinde en az bir model bulunmalı!!!");
            }
            
        }

        
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            asama(1);
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_d_1.Checked)
            {
                cls_main.gv_hat = "M500200";
            }
            else if (rb_d_2.Checked)
            {
                cls_main.gv_hat = "M510200";
            }
            else if (rb_d_3.Checked)
            {
                cls_main.gv_hat = "M520200";
            }
            else if (rb_d_4.Checked)
            {
                cls_main.gv_hat = "M530200";
            }
            else if (rb_d_5.Checked)
            {
                cls_main.gv_hat = "M540200";
            }
            else
            {
                cls_main.gv_hat = "M500200";
            }
            fill_dgv_matnr();
        }

        private void dgv_tags_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void asama(int sayi)
        {
            switch (sayi)
            {
                case 1:
                    gb_tags.Enabled = true;
                    gb_mdl.Enabled = true;
                    btn_mdl.Enabled = true;
                    gb_mlz.Enabled = false;
                    btn_devam.Enabled = false;
                    dgv_mlz.Rows.Clear();
                    break;
                case 2:
                    gb_tags.Enabled = false;
                    gb_mdl.Enabled = false;
                    btn_mdl.Enabled = false;
                    gb_mlz.Enabled = true;
                    btn_devam.Enabled = true;
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        private void dgv_tags_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tags.SelectedRows.Count > 2)
            {
                dgv_tags.SelectedRows[0].Selected = false;
            }
            fill_dgv_mdl();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            dgv_tags.Rows.Clear();      
        }

        private void btn_secilenleri_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgv_tags.SelectedRows)
            {
                dgv_tags.Rows.RemoveAt(item.Index);
            }
        }

        private void dgv_mlz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    if ((Convert.ToInt32(dgv_mlz.Rows[e.RowIndex].Cells[3].Value) - 1) >= 1)
                    {
                        dgv_mlz.Rows[e.RowIndex].Cells[3].Value = Convert.ToInt32(dgv_mlz.Rows[e.RowIndex].Cells[3].Value) - 1;    
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    if (Convert.ToInt32(dgv_mlz.Rows[e.RowIndex].Cells[2].Value) >= (Convert.ToInt32(dgv_mlz.Rows[e.RowIndex].Cells[3].Value) + 1))
                    {
                        dgv_mlz.Rows[e.RowIndex].Cells[3].Value = Convert.ToInt32(dgv_mlz.Rows[e.RowIndex].Cells[3].Value) + 1;    
                    }
                    
                }
                else
                {

                }
            }
        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            if (dgv_mlz.Rows.Count > 0)
            {
                call_control_screen();
            }
        }
        private void call_control_screen()
        {
            cls_main.mdl_kntl_dt.Clear();
            cls_main.mdl_kntl_dt = cls_main.GET_MDL_KONTROL_LIST();
            if (cls_main.mdl_kntl_dt.Rows.Count > 0)
            {
                cls_main.frm_kontrol1 = new frm_kontrol();
                cls_main.frm_kontrol1.Show();
                cls_main.frm_kontrol1.StartPosition = FormStartPosition.CenterScreen;
                this.Enabled = false;
            }
        }

        private void tssb_reconnect_ButtonClick(object sender, EventArgs e)
        {
            rfid.connect();
        }


    }
}
