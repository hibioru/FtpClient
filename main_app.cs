using System;
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
using System.Net;

namespace FtpClient
{
    public partial class f_main_app : MaterialForm
    {
        //public string remoteFileName { get;  set; }
        //public object updateProgress { get;  set; }
        //private Address ipaddress;

        public f_main_app()
        {
            InitializeComponent();

            //加载自定义皮肤
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);

        }


        private void f_main_app_Load(object sender, EventArgs e)
        {

            lv_files_load();

        }

        private static string filename;
        private static string filetype;

        private void lv_files_load()
        {
            tb_path.Text = FTPHelper.ftpRemotePath;

            //在listview中加载目录
            lv_files.View = View.Details;

            lv_files.Columns.Clear();

            lv_files.Columns.Add("No.");
            lv_files.Columns.Add("文件名");
            lv_files.Columns.Add("文件类型");
            lv_files.Columns[0].Width = 30;
            lv_files.Columns[1].Width = 400;
            lv_files.Columns[2].Width = 100;

            lv_files.Items.Clear();

            String[] files = FTPHelper.GetFilesDetailList();
            ListViewItem item = null;
            int id = 1;
            foreach (String file in files)
            {
                item = new ListViewItem(id.ToString());
                item.SubItems.Add(Path.GetFileName(file));
                item.SubItems.Add(Path.GetExtension(file));
                lv_files.Items.Add(item);
                id++;
            }
        }


        #region  工具栏功能
        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_create_directories_Click(object sender, EventArgs e)
        {

            FTPHelper ftphelper = new FTPHelper();

            if (ftphelper.DirectoryExist("新建文件夹") == false)
            {
                ftphelper.MakeDir("新建文件夹");
                lv_files_load();
            }
            else
            {
                MessageBox.Show("该文件已存在！");
            }

        }


        ///summary
        ///删除文件夹
        ///summary
        private void bt_delete_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.lv_files.SelectedIndices;
            if (indexes.Count > 0)
            {
                int index = indexes[0];
                filename = this.lv_files.Items[index].SubItems[1].Text;//获取第二列的值（获取所选项的名称）
                filetype = this.lv_files.Items[index].SubItems[2].Text;//获取第三列的值（获取所选项的类型）
            }

            if (filetype == "")
            {
                FTPHelper.RemoveDirectory(tb_path.Text + "/" + filename);
            }
            else
            {
                FTPHelper.Delete(filename);
            }
            
            lv_files_load();
        }


        ///summary
        ///下载文件
        ///summary
        private void bt_download_Click(object sender, EventArgs e)
        {

            ListView.SelectedIndexCollection indexes = this.lv_files.SelectedIndices;
            if (indexes.Count > 0)
            {
                int index = indexes[0];
                filename = this.lv_files.Items[index].SubItems[1].Text;//获取第二列的值（获取文件名）
            }

            FTPHelper.FtpDownload(tb_path.Text + "/" + filename, @"C:\Users\Public\Downloads\" + filename, true);

            System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Public\Downloads");//下载完成后弹出下载路径

        }

        #endregion


        #region  导航栏功能

        private void bt_forward_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.lv_files.SelectedIndices;
            if (indexes.Count > 0)
            {
                int index = indexes[0];
                filename = this.lv_files.Items[index].SubItems[1].Text;//获取第二列的值（获取文件名）
            }

            FTPHelper ftphelper = new FTPHelper();
            ftphelper.GotoDirectory(filename.ToString(), false);
            lv_files_load();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            FTPHelper ftphelper = new FTPHelper();
            ftphelper.GotoDirectory(FTPHelper.LastftpRemotePath.ToString(), true);
            lv_files_load();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            lv_files_load();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            FTPHelper ftphelper = new FTPHelper();
            ftphelper.GotoDirectory("/", true);
            lv_files_load();
        }

        #endregion


        private void tb_path_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FTPHelper ftphelper = new FTPHelper();
                ftphelper.GotoDirectory(tb_path.Text.ToString(), true); 
                lv_files_load();
            }

        }

     
    }

}
