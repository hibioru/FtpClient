namespace FtpClient
{
    partial class main_app
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
            "1",
            "abc.txt"}, -1);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_app));
            this.path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.home = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.create_directories = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.progressbar = new FtpClient.MyProgressBar();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speed = new MaterialSkin.Controls.MaterialLabel();
            this.percentage = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Depth = 0;
            this.path.Hint = "";
            this.path.Location = new System.Drawing.Point(190, 81);
            this.path.MaxLength = 32767;
            this.path.MouseState = MaterialSkin.MouseState.HOVER;
            this.path.Name = "path";
            this.path.PasswordChar = '\0';
            this.path.SelectedText = "";
            this.path.SelectionLength = 0;
            this.path.SelectionStart = 0;
            this.path.Size = new System.Drawing.Size(600, 23);
            this.path.TabIndex = 1;
            this.path.TabStop = false;
            this.path.Text = "\\";
            this.path.UseSystemPasswordChar = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Image = global::FtpClient.Properties.Resources.home;
            this.home.Location = new System.Drawing.Point(138, 64);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(40, 40);
            this.home.TabIndex = 0;
            this.home.TabStop = false;
            this.home.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Image = global::FtpClient.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(92, 64);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(40, 40);
            this.refresh.TabIndex = 0;
            this.refresh.TabStop = false;
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.Color.Transparent;
            this.forward.FlatAppearance.BorderSize = 0;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward.Image = global::FtpClient.Properties.Resources.forward;
            this.forward.Location = new System.Drawing.Point(46, 64);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(40, 40);
            this.forward.TabIndex = 0;
            this.forward.TabStop = false;
            this.forward.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Image = global::FtpClient.Properties.Resources.delete;
            this.delete.Location = new System.Drawing.Point(638, 24);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(40, 40);
            this.delete.TabIndex = 0;
            this.delete.TabStop = false;
            this.delete.UseVisualStyleBackColor = false;
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.Transparent;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Image = global::FtpClient.Properties.Resources.download;
            this.download.Location = new System.Drawing.Point(592, 24);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(40, 40);
            this.download.TabIndex = 0;
            this.download.TabStop = false;
            this.download.UseVisualStyleBackColor = false;
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.Transparent;
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Image = global::FtpClient.Properties.Resources.upload;
            this.upload.Location = new System.Drawing.Point(546, 24);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(40, 40);
            this.upload.TabIndex = 0;
            this.upload.TabStop = false;
            this.upload.UseVisualStyleBackColor = false;
            // 
            // create_directories
            // 
            this.create_directories.BackColor = System.Drawing.Color.Transparent;
            this.create_directories.FlatAppearance.BorderSize = 0;
            this.create_directories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.create_directories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.create_directories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_directories.Image = global::FtpClient.Properties.Resources.create_directories;
            this.create_directories.Location = new System.Drawing.Point(500, 24);
            this.create_directories.Name = "create_directories";
            this.create_directories.Size = new System.Drawing.Size(40, 40);
            this.create_directories.TabIndex = 0;
            this.create_directories.TabStop = false;
            this.create_directories.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = global::FtpClient.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(0, 64);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 40);
            this.back.TabIndex = 0;
            this.back.TabStop = false;
            this.back.UseVisualStyleBackColor = false;
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
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.progressbar.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.progressbar.Location = new System.Drawing.Point(98, 470);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(244, 17);
            this.progressbar.TabIndex = 0;
            this.progressbar.Value = 80;
            // 
            // materialListView1
            // 
            this.materialListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.materialListView1.AllowColumnReorder = true;
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.HoverSelection = true;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.materialListView1.Location = new System.Drawing.Point(30, 122);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(732, 305);
            this.materialListView1.TabIndex = 3;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文件名";
            this.columnHeader2.Width = 337;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件类型";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "文件大小";
            this.columnHeader4.Width = 145;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Depth = 0;
            this.speed.Font = new System.Drawing.Font("Roboto", 11F);
            this.speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speed.Location = new System.Drawing.Point(26, 470);
            this.speed.MouseState = MaterialSkin.MouseState.HOVER;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(66, 19);
            this.speed.TabIndex = 4;
            this.speed.Text = "xxx KB/s";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Depth = 0;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.percentage.Location = new System.Drawing.Point(589, 469);
            this.percentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(90, 18);
            this.percentage.TabIndex = 6;
            this.percentage.Text = "a MB / b MB";
            // 
            // main_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.path);
            this.Controls.Add(this.home);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.download);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.create_directories);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "main_app";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FtpClient";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button home;
        private MaterialSkin.Controls.MaterialSingleLineTextField path;
        private System.Windows.Forms.Button create_directories;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.PictureBox logo;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MyProgressBar progressbar;
        private MaterialSkin.Controls.MaterialLabel speed;
        private MaterialSkin.Controls.MaterialLabel percentage;
    }
}

