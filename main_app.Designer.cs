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
            this.components = new System.ComponentModel.Container();
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
            this.fileicon = new System.Windows.Forms.ImageList(this.components);
            this.lb_speed = new MaterialSkin.Controls.MaterialLabel();
            this.lb_percentage = new MaterialSkin.Controls.MaterialLabel();
            this.lv_files = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_path
            // 
            this.tb_path.Depth = 0;
            this.tb_path.Hint = "";
            this.tb_path.Location = new System.Drawing.Point(190, 81);
            this.tb_path.MaxLength = 32767;
            this.tb_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_path.Name = "tb_path";
            this.tb_path.PasswordChar = '\0';
            this.tb_path.SelectedText = "";
            this.tb_path.SelectionLength = 0;
            this.tb_path.SelectionStart = 0;
            this.tb_path.Size = new System.Drawing.Size(600, 23);
            this.tb_path.TabIndex = 1;
            this.tb_path.TabStop = false;
            this.tb_path.Text = "/";
            this.tb_path.UseSystemPasswordChar = false;
            this.tb_path.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_path_KeyDown);
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Image = global::FtpClient.Properties.Resources.home;
            this.bt_home.Location = new System.Drawing.Point(138, 64);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(40, 40);
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
            this.bt_refresh.Location = new System.Drawing.Point(92, 64);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(40, 40);
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
            this.bt_forward.Location = new System.Drawing.Point(46, 64);
            this.bt_forward.Name = "bt_forward";
            this.bt_forward.Size = new System.Drawing.Size(40, 40);
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
            this.bt_delete.Location = new System.Drawing.Point(638, 24);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(40, 40);
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
            this.bt_download.Location = new System.Drawing.Point(592, 24);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(40, 40);
            this.bt_download.TabIndex = 0;
            this.bt_download.TabStop = false;
            this.bt_download.UseVisualStyleBackColor = false;
            this.bt_download.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // bt_upload
            // 
            this.bt_upload.BackColor = System.Drawing.Color.Transparent;
            this.bt_upload.FlatAppearance.BorderSize = 0;
            this.bt_upload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bt_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_upload.Image = global::FtpClient.Properties.Resources.upload;
            this.bt_upload.Location = new System.Drawing.Point(546, 24);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(40, 40);
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
            this.bt_create_directories.Location = new System.Drawing.Point(500, 24);
            this.bt_create_directories.Name = "bt_create_directories";
            this.bt_create_directories.Size = new System.Drawing.Size(40, 40);
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
            this.bt_back.Location = new System.Drawing.Point(0, 64);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(40, 40);
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
            this.logo.Location = new System.Drawing.Point(90, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(40, 40);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // fileicon
            // 
            this.fileicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileicon.ImageStream")));
            this.fileicon.TransparentColor = System.Drawing.Color.Transparent;
            this.fileicon.Images.SetKeyName(0, "directory");
            this.fileicon.Images.SetKeyName(1, "doc");
            this.fileicon.Images.SetKeyName(2, "others");
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Depth = 0;
            this.lb_speed.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_speed.Location = new System.Drawing.Point(20, 470);
            this.lb_speed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(66, 19);
            this.lb_speed.TabIndex = 4;
            this.lb_speed.Text = "xxx KB/s";
            // 
            // lb_percentage
            // 
            this.lb_percentage.AutoSize = true;
            this.lb_percentage.Depth = 0;
            this.lb_percentage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_percentage.Location = new System.Drawing.Point(134, 470);
            this.lb_percentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_percentage.Name = "lb_percentage";
            this.lb_percentage.Size = new System.Drawing.Size(91, 19);
            this.lb_percentage.TabIndex = 6;
            this.lb_percentage.Text = "a MB / b MB";
            // 
            // lv_files
            // 
            this.lv_files.FullRowSelect = true;
            this.lv_files.HideSelection = false;
            this.lv_files.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_files.Location = new System.Drawing.Point(24, 128);
            this.lv_files.Name = "lv_files";
            this.lv_files.Size = new System.Drawing.Size(752, 323);
            this.lv_files.TabIndex = 7;
            this.lv_files.UseCompatibleStateImageBehavior = false;
            // 
            // f_main_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lv_files);
            this.Controls.Add(this.lb_percentage);
            this.Controls.Add(this.lb_speed);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "f_main_app";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FtpClient";
            this.Load += new System.EventHandler(this.f_main_app_Load);
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
        private MaterialSkin.Controls.MaterialLabel lb_speed;
        private MaterialSkin.Controls.MaterialLabel lb_percentage;
        private System.Windows.Forms.ImageList fileicon;
        private System.Windows.Forms.ListView lv_files;
    }
}

