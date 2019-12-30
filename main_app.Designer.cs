namespace FtpClient
{
    partial class f_main_app
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "abc.txt",
            "文件夹",
            "1kb"}, 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "ef.doc",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "hahaha.xls",
            "xls"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main_app));
            this.tb_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_forward = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_download = new System.Windows.Forms.Button();
            this.bt_upload = new System.Windows.Forms.Button();
            this.bt_create_directories = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lv_files = new MaterialSkin.Controls.MaterialListView();
            this.list_fileicon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_filetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_filesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_speed = new MaterialSkin.Controls.MaterialLabel();
            this.lb_percentage = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_path
            // 
            this.tb_path.Depth = 0;
            this.tb_path.Hint = "";
            this.tb_path.Location = new System.Drawing.Point(253, 101);
            this.tb_path.Margin = new System.Windows.Forms.Padding(4);
            this.tb_path.MaxLength = 32767;
            this.tb_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_path.Name = "tb_path";
            this.tb_path.PasswordChar = '\0';
            this.tb_path.SelectedText = "";
            this.tb_path.SelectionLength = 0;
            this.tb_path.SelectionStart = 0;
            this.tb_path.Size = new System.Drawing.Size(800, 28);
            this.tb_path.TabIndex = 1;
            this.tb_path.TabStop = false;
            this.tb_path.Text = "\\";
            this.tb_path.UseSystemPasswordChar = false;
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Image = global::FtpClient.Properties.Resources.home;
            this.bt_home.Location = new System.Drawing.Point(184, 80);
            this.bt_home.Margin = new System.Windows.Forms.Padding(4);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(53, 50);
            this.bt_home.TabIndex = 0;
            this.bt_home.TabStop = false;
            this.bt_home.UseVisualStyleBackColor = false;
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.Transparent;
            this.bt_refresh.FlatAppearance.BorderSize = 0;
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.Image = global::FtpClient.Properties.Resources.refresh;
            this.bt_refresh.Location = new System.Drawing.Point(123, 80);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(53, 50);
            this.bt_refresh.TabIndex = 0;
            this.bt_refresh.TabStop = false;
            this.bt_refresh.UseVisualStyleBackColor = false;
            // 
            // bt_forward
            // 
            this.bt_forward.BackColor = System.Drawing.Color.Transparent;
            this.bt_forward.FlatAppearance.BorderSize = 0;
            this.bt_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_forward.Image = global::FtpClient.Properties.Resources.forward;
            this.bt_forward.Location = new System.Drawing.Point(61, 80);
            this.bt_forward.Margin = new System.Windows.Forms.Padding(4);
            this.bt_forward.Name = "bt_forward";
            this.bt_forward.Size = new System.Drawing.Size(53, 50);
            this.bt_forward.TabIndex = 0;
            this.bt_forward.TabStop = false;
            this.bt_forward.UseVisualStyleBackColor = false;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Transparent;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Image = global::FtpClient.Properties.Resources.delete;
            this.bt_delete.Location = new System.Drawing.Point(851, 30);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(4);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(53, 50);
            this.bt_delete.TabIndex = 0;
            this.bt_delete.TabStop = false;
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_download
            // 
            this.bt_download.BackColor = System.Drawing.Color.Transparent;
            this.bt_download.FlatAppearance.BorderSize = 0;
            this.bt_download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bt_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_download.Image = global::FtpClient.Properties.Resources.download;
            this.bt_download.Location = new System.Drawing.Point(789, 30);
            this.bt_download.Margin = new System.Windows.Forms.Padding(4);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(53, 50);
            this.bt_download.TabIndex = 0;
            this.bt_download.TabStop = false;
            this.bt_download.UseVisualStyleBackColor = false;
            // 
            // bt_upload
            // 
            this.bt_upload.BackColor = System.Drawing.Color.Transparent;
            this.bt_upload.FlatAppearance.BorderSize = 0;
            this.bt_upload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bt_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_upload.Image = global::FtpClient.Properties.Resources.upload;
            this.bt_upload.Location = new System.Drawing.Point(728, 30);
            this.bt_upload.Margin = new System.Windows.Forms.Padding(4);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(53, 50);
            this.bt_upload.TabIndex = 0;
            this.bt_upload.TabStop = false;
            this.bt_upload.UseVisualStyleBackColor = false;
            // 
            // bt_create_directories
            // 
            this.bt_create_directories.BackColor = System.Drawing.Color.Transparent;
            this.bt_create_directories.FlatAppearance.BorderSize = 0;
            this.bt_create_directories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_create_directories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bt_create_directories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_create_directories.Image = global::FtpClient.Properties.Resources.create_directories;
            this.bt_create_directories.Location = new System.Drawing.Point(667, 30);
            this.bt_create_directories.Margin = new System.Windows.Forms.Padding(4);
            this.bt_create_directories.Name = "bt_create_directories";
            this.bt_create_directories.Size = new System.Drawing.Size(53, 50);
            this.bt_create_directories.TabIndex = 0;
            this.bt_create_directories.TabStop = false;
            this.bt_create_directories.UseVisualStyleBackColor = false;
            this.bt_create_directories.Click += new System.EventHandler(this.bt_create_directories_Click);
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Transparent;
            this.bt_back.FlatAppearance.BorderSize = 0;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Image = global::FtpClient.Properties.Resources.back;
            this.bt_back.Location = new System.Drawing.Point(0, 80);
            this.bt_back.Margin = new System.Windows.Forms.Padding(4);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(53, 50);
            this.bt_back.TabIndex = 0;
            this.bt_back.TabStop = false;
            this.bt_back.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.ErrorImage = global::FtpClient.Properties.Resources.FtpClient;
            this.logo.Image = global::FtpClient.Properties.Resources.FtpClient;
            this.logo.InitialImage = global::FtpClient.Properties.Resources.FtpClient;
            this.logo.Location = new System.Drawing.Point(120, 30);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(53, 50);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // lv_files
            // 
            this.lv_files.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_files.AllowColumnReorder = true;
            this.lv_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_fileicon,
            this.list_filename,
            this.list_filetype,
            this.list_filesize});
            this.lv_files.Depth = 0;
            this.lv_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lv_files.FullRowSelect = true;
            this.lv_files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_files.HideSelection = false;
            this.lv_files.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            this.lv_files.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lv_files.Location = new System.Drawing.Point(40, 152);
            this.lv_files.Margin = new System.Windows.Forms.Padding(4);
            this.lv_files.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_files.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_files.Name = "lv_files";
            this.lv_files.OwnerDraw = true;
            this.lv_files.Size = new System.Drawing.Size(976, 386);
            this.lv_files.TabIndex = 3;
            this.lv_files.UseCompatibleStateImageBehavior = false;
            this.lv_files.View = System.Windows.Forms.View.Details;
            // 
            // list_fileicon
            // 
            this.list_fileicon.Text = "fileicon";
            this.list_fileicon.Width = 120;
            // 
            // list_filename
            // 
            this.list_filename.Text = "文件名";
            this.list_filename.Width = 313;
            // 
            // list_filetype
            // 
            this.list_filetype.Text = "文件类型";
            this.list_filetype.Width = 148;
            // 
            // list_filesize
            // 
            this.list_filesize.Text = "文件大小";
            this.list_filesize.Width = 145;
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Depth = 0;
            this.lb_speed.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_speed.Location = new System.Drawing.Point(27, 588);
            this.lb_speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_speed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(84, 24);
            this.lb_speed.TabIndex = 4;
            this.lb_speed.Text = "xxx KB/s";
            // 
            // lb_percentage
            // 
            this.lb_percentage.AutoSize = true;
            this.lb_percentage.Depth = 0;
            this.lb_percentage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_percentage.Location = new System.Drawing.Point(179, 588);
            this.lb_percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_percentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_percentage.Name = "lb_percentage";
            this.lb_percentage.Size = new System.Drawing.Size(117, 24);
            this.lb_percentage.TabIndex = 6;
            this.lb_percentage.Text = "a MB / b MB";
            // 
            // f_main_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.lb_percentage);
            this.Controls.Add(this.lb_speed);
            this.Controls.Add(this.lv_files);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_forward);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.bt_create_directories);
            this.Controls.Add(this.bt_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1067, 625);
            this.MinimumSize = new System.Drawing.Size(1067, 625);
            this.Name = "f_main_app";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FtpClient";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_forward;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_home;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_path;
        private System.Windows.Forms.Button bt_create_directories;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.Button bt_download;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.PictureBox logo;
        private MaterialSkin.Controls.MaterialListView lv_files;
        private System.Windows.Forms.ColumnHeader list_filename;
        private System.Windows.Forms.ColumnHeader list_filetype;
        private System.Windows.Forms.ColumnHeader list_filesize;
        private MaterialSkin.Controls.MaterialLabel lb_speed;
        private MaterialSkin.Controls.MaterialLabel lb_percentage;
        private System.Windows.Forms.ColumnHeader list_fileicon;
    }
}

