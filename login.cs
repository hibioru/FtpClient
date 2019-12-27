using System;
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
    public partial class Login_Form : MaterialForm
    {
        private FTPHelper ftpHelper;
        public Login_Form()
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
                    string Address = address.Text.Trim();
                    string Port = port.Text.Trim();
                    string UserName = username.Text.Trim();
                    string Password = password.Text.Trim();
                   //ftpHelper = new FTPHelper(Address, Port, UserName, Password);
                }
            }
            catch (Exception ex)
            {
            }
            Application.Run(new main_app());//点击log in后弹出主界面
        }
        private bool checktext()//判断有没有输入地址、端口、用户名、密码
        {
            string Address = address.Text.Trim();
            string Port =  port.Text.Trim();
            string UserName = username.Text.Trim();
            string Password = password.Text.Trim();
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Port) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("请输入登录信息");
                return false;
            }
            return true;
        }
    }
}
