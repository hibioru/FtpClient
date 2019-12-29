﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;


namespace FtpClient
{
    public partial class f_main_app : MaterialForm
    {
        public f_main_app()
        {
            InitializeComponent();
            //主界面皮肤设置
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);

        }



        #region  工具栏功能
        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_create_directories_Click(object sender, EventArgs e)
        {
            string path = tb_path.Text;
            if (!Directory.Exists(path))      //判断它是否在文件夹内
            {
                Directory.CreateDirectory(path);      //若无则新建一个文件夹
            }
            else
            {
                MessageBox.Show("该文件已存在！");
            }
            return;
        }
    }

    
   


    #endregion
}


