using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Net;
using System.Xml;
using System.Web;
using System.IO;
using System.Windows.Forms;
using Symbol.RFID3;
using Symbol;
using System.Web.Services.Protocols;
using IniParser;
namespace ModelRFiD
{
    public static class cls_main
    {
        #region formlar
        public static frm_model frm_model1;
        public static frm_kontrol frm_kontrol1;
        #endregion formlar

        #region kullanıcı
        public static string sicil = "";
        public static string cname = "";
        public static string passw = "";
        public static string sapid = "";
        #endregion kullanıcı


        public static string rdrip = "";


        public static DataTable mdl_list_dt = new DataTable();
        public static DataTable mdl_chng_dt = new DataTable();
        public static DataTable mdl_kntl_dt = new DataTable();
        public static string gv_hat = "M500200";
        private static DataTable XmlParse(string xmlData, int tabl)
        {
            DataSet theDataSet = new DataSet();
            try
            {
                xmlData = HttpUtility.HtmlDecode(xmlData);
                StringReader theReader = new StringReader(xmlData);
                theDataSet.ReadXml(theReader);
            }
            catch (Exception)
            {
            }
            return theDataSet.Tables[tabl];
        }
        public static bool ini_read(string inifile)
        {
            bool rt = false;
            try
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData config_data = parser.LoadFile(inifile);
                rdrip = config_data["ini"]["reader_ip"].ToString();
                rt = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program ayarları okunamadı, Bilgi İşlem'e haber veriniz!!!\n" + ex.Message.ToString());
                rt = false;
                Application.Exit();
            }
            return rt;
            
        }
        public static Boolean login(string user, string pass)
        {
            Boolean rt = false;
            try
            {
                ModelRFiD.LOGIN.XacuteWS ws_login = new ModelRFiD.LOGIN.XacuteWS();
                ModelRFiD.LOGIN.InputParams iparams = new ModelRFiD.LOGIN.InputParams();
                ModelRFiD.LOGIN.Rowset rowset = new ModelRFiD.LOGIN.Rowset();
                iparams.USERNAME = user;
                iparams.PASSWORD = pass;
                rowset = ws_login.Xacute("disarfid", "abcd1234+", iparams);
                if (rowset.Row[0].RETURN.ToString() == "0")
                {
                    sicil = user;
                    passw = pass;
                    cname = rowset.Row[0].PA_CNAME.ToString();
                    rt = true;
                }
                else
                {
                    sicil = "";
                    passw = "";
                    cname = "";
                    rt = false;
                }
                ws_login.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rt;
        }
        public static DataTable get_dkm()
        {
            DataTable dt = new DataTable();
            try
            {
                /*
                DKM_GET.XacuteWS dkm_get1 = new DKM_GET.XacuteWS();
                DKM_GET.InputParams iparams = new DKM_GET.InputParams();
                DKM_GET.Rowset rowset = new ModelRFiD.DKM_GET.Rowset();
                dt = XmlParse(dkm_get1.Xacute("disarfid", "abcd1234+", iparams).Row[0].Output, 4);
                dkm_get1.Dispose();
                */ 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static DataTable GET_MDL_LIST(string tag)
        {
            DataTable dt = new DataTable();
            try
            {
                ModelRFiD.GET_MATERIAL_FROM_TAG.XacuteWS mdl_inf1 = new ModelRFiD.GET_MATERIAL_FROM_TAG.XacuteWS();
                ModelRFiD.GET_MATERIAL_FROM_TAG.InputParams iparams = new ModelRFiD.GET_MATERIAL_FROM_TAG.InputParams();
                ModelRFiD.GET_MATERIAL_FROM_TAG.Rowset rowset = new ModelRFiD.GET_MATERIAL_FROM_TAG.Rowset();
                iparams.TAGID = tag;
                dt = XmlParse(mdl_inf1.Xacute("disarfid", "abcd1234+", iparams).Row[0].RETURN, 3);
                mdl_inf1.Dispose();   
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static void GET_MDL_MATNR(string tag1,string tag2, out string rt, out string rt2)
        {
            rt = "";
            rt2 = "";
            try
            {
                ModelRFiD.GET_MATERIAL_FROM_TAG2.XacuteWS mdl_inf2 = new ModelRFiD.GET_MATERIAL_FROM_TAG2.XacuteWS();
                ModelRFiD.GET_MATERIAL_FROM_TAG2.InputParams iparams = new ModelRFiD.GET_MATERIAL_FROM_TAG2.InputParams();
                ModelRFiD.GET_MATERIAL_FROM_TAG2.Rowset rowset = new ModelRFiD.GET_MATERIAL_FROM_TAG2.Rowset();
                iparams.TAGID = tag1;
                iparams.TAGID2 = tag2;
                rowset = mdl_inf2.Xacute("disarfid", "abcd1234+", iparams);
                rt = rowset.Row[0].RETURN.ToString();
                rt2 = rowset.Row[0].RETURN2.ToString();
                mdl_inf2.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            
        }
        public static DataTable GET_MATNR_LIST(string matnr,string arbpl)
        {
            DataTable dt = new DataTable();
            try
            {
                ModelRFiD.GET_MATERIAL_FROM_MODEL.XacuteWS mdl_inf1 = new ModelRFiD.GET_MATERIAL_FROM_MODEL.XacuteWS();
                ModelRFiD.GET_MATERIAL_FROM_MODEL.InputParams iparams = new ModelRFiD.GET_MATERIAL_FROM_MODEL.InputParams();
                ModelRFiD.GET_MATERIAL_FROM_MODEL.Rowset rowset = new ModelRFiD.GET_MATERIAL_FROM_MODEL.Rowset();
                iparams.MATNR = matnr;
                iparams.ARBPL = arbpl;
                dt = XmlParse(mdl_inf1.Xacute("disarfid", "abcd1234+", iparams).Row[0].RETURN, 3);
                mdl_inf1.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static DataTable GET_MDL_KONTROL_LIST()
        {
            DataTable dt = new DataTable();
            try
            {
                ModelRFiD.GET_MODEL_KONTROL_LIST.XacuteWS mdl_kntrl1 = new ModelRFiD.GET_MODEL_KONTROL_LIST.XacuteWS();
                ModelRFiD.GET_MODEL_KONTROL_LIST.InputParams iparams = new ModelRFiD.GET_MODEL_KONTROL_LIST.InputParams();
                ModelRFiD.GET_MODEL_KONTROL_LIST.Rowset rowset = new ModelRFiD.GET_MODEL_KONTROL_LIST.Rowset();
                dt = XmlParse(mdl_kntrl1.Xacute("disarfid", "abcd1234+", iparams).Row[0].RETURN, 2);
                mdl_kntrl1.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static void SET_MDL_KONTROL_LIST(DataTable dt_in,string pa_matnr)
        {
            DataTable dt = new DataTable();
            try
            {
                ModelRFiD.SET_MODEL_KONTROL_LIST.XacuteWS mdl_kntrl1 = new ModelRFiD.SET_MODEL_KONTROL_LIST.XacuteWS();
                ModelRFiD.SET_MODEL_KONTROL_LIST.InputParams iparams = new ModelRFiD.SET_MODEL_KONTROL_LIST.InputParams();
                ModelRFiD.SET_MODEL_KONTROL_LIST.Rowset rowset = new ModelRFiD.SET_MODEL_KONTROL_LIST.Rowset();
                iparams.TB_LISTE = "";
                foreach (DataRow dr in dt_in.Rows)
                {
                    for(int i = 0 ; i < dt_in.Columns.Count; i++)
                    {
                            iparams.TB_LISTE += dr.ItemArray[i].ToString().Replace(',',' ').Replace(';',' ') + ',';
                    }
                    iparams.TB_LISTE = iparams.TB_LISTE.Substring(0, iparams.TB_LISTE.Length-1) + ';';
                }
                iparams.PA_MATNR = pa_matnr;
                iparams.TB_LISTE = iparams.TB_LISTE.Substring(0, iparams.TB_LISTE.Length - 1);
                MessageBox.Show(HttpUtility.HtmlDecode(mdl_kntrl1.Xacute("disarfid", "abcd1234+", iparams).Row[0].RETURN.ToString()));
                mdl_kntrl1.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public static DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
    }
}
