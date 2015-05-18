using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModelRFiD
{
    public partial class frm_kontrol : Form
    {
        public frm_kontrol()
        {
            InitializeComponent();
        }

        private void frm_kontrol_Load(object sender, EventArgs e)
        {
            foreach ( DataRow dr in cls_main.mdl_kntl_dt.Rows)
            {
                dgv_kontrol.Rows.Add(dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), " ");
            }
        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Devam etmek istiyormusunuz?", "Tamam/Devam???", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cls_main.SET_MDL_KONTROL_LIST(cls_main.GetDataTableFromDGV(dgv_kontrol), cls_main.frm_model1.dgv_mdl.Rows[0].Cells[0].Value.ToString());
                this.Close();
                this.Dispose();
                cls_main.frm_model1.Enabled = true;
                cls_main.frm_model1.BringToFront();
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            cls_main.frm_model1.Enabled = true;
            cls_main.frm_model1.BringToFront();
        }
    }
}
