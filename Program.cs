using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModelRFiD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(cls_main.frm_model1 = new frm_model());
            //Application.Run(new frm_mdi());
        }
    }
}
