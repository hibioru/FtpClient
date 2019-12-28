﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FtpClient
{
    public partial class f_login : MaterialForm
    {
        private FTPHelper ftpHelper;
        public f_login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);

        }

        //点击 Log in 后触发的事件
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (checktext())
                {
                    string Address = tb_address.Text.Trim();
                    string Port = tb_port.Text.Trim();
                    string UserName = tb_username.Text.Trim();
                    string Password = tb_password.Text.Trim();
                    ftpHelper = new FTPHelper( Address, UserName, Password,Port);
                
                }
            }
            catch (Exception ex)
            {
            }
            Show();

        }
        private bool checktext()//判断有没有输入地址、端口、用户名、密码
        {
            string Address = tb_address.Text.Trim();
            string Port =  tb_port.Text.Trim();
            string UserName = tb_username.Text.Trim();
            string Password = tb_password.Text.Trim();
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Port) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("请输入登录信息");
                return false;
            }
            return true;
        }
    }
}
