using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FtpClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            f_login f_login = new f_login();
            f_login.ShowDialog();

            if (f_login.DialogResult == DialogResult.OK)
            {
                f_login.Dispose();
                Application.Run(new f_main_app());
            }
            else if (f_login.DialogResult == DialogResult.Cancel)
            {
                f_login.Dispose();
                return;
            }

        }

    }
}
