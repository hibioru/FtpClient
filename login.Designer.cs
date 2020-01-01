namespace FtpClient
{
    partial class f_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_login));
            this.tb_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_port = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bt_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tb_address
            // 
            this.tb_address.Depth = 0;
            this.tb_address.Hint = "Address";
            this.tb_address.Location = new System.Drawing.Point(100, 100);
            this.tb_address.MaxLength = 32767;
            this.tb_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_address.Name = "tb_address";
            this.tb_address.PasswordChar = '\0';
            this.tb_address.SelectedText = "";
            this.tb_address.SelectionLength = 0;
            this.tb_address.SelectionStart = 0;
            this.tb_address.Size = new System.Drawing.Size(125, 23);
            this.tb_address.TabIndex = 1;
            this.tb_address.TabStop = false;
            this.tb_address.Text = "ftp.hibioru.com";
            this.tb_address.UseSystemPasswordChar = false;
            // 
            // tb_port
            // 
            this.tb_port.Depth = 0;
            this.tb_port.Hint = "Port";
            this.tb_port.Location = new System.Drawing.Point(250, 100);
            this.tb_port.MaxLength = 32767;
            this.tb_port.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_port.Name = "tb_port";
            this.tb_port.PasswordChar = '\0';
            this.tb_port.SelectedText = "";
            this.tb_port.SelectionLength = 0;
            this.tb_port.SelectionStart = 0;
            this.tb_port.Size = new System.Drawing.Size(50, 23);
            this.tb_port.TabIndex = 2;
            this.tb_port.TabStop = false;
            this.tb_port.Text = "21";
            this.tb_port.UseSystemPasswordChar = false;
            // 
            // tb_username
            // 
            this.tb_username.Depth = 0;
            this.tb_username.Hint = "Username";
            this.tb_username.Location = new System.Drawing.Point(100, 140);
            this.tb_username.MaxLength = 32767;
            this.tb_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.SelectedText = "";
            this.tb_username.SelectionLength = 0;
            this.tb_username.SelectionStart = 0;
            this.tb_username.Size = new System.Drawing.Size(200, 23);
            this.tb_username.TabIndex = 3;
            this.tb_username.TabStop = false;
            this.tb_username.Text = "test";
            this.tb_username.UseSystemPasswordChar = false;
            // 
            // tb_password
            // 
            this.tb_password.Depth = 0;
            this.tb_password.Hint = "Password";
            this.tb_password.Location = new System.Drawing.Point(100, 180);
            this.tb_password.MaxLength = 32767;
            this.tb_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '\0';
            this.tb_password.SelectedText = "";
            this.tb_password.SelectionLength = 0;
            this.tb_password.SelectionStart = 0;
            this.tb_password.Size = new System.Drawing.Size(200, 23);
            this.tb_password.TabIndex = 4;
            this.tb_password.TabStop = false;
            this.tb_password.Text = "hello2020";
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // bt_login
            // 
            this.bt_login.AutoSize = true;
            this.bt_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_login.Depth = 0;
            this.bt_login.Icon = null;
            this.bt_login.Location = new System.Drawing.Point(166, 230);
            this.bt_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_login.Name = "bt_login";
            this.bt_login.Primary = true;
            this.bt_login.Size = new System.Drawing.Size(68, 36);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Log  in";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.login_Click);
            // 
            // f_login
            // 
            this.AcceptButton = this.bt_login;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_address);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "f_login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Client - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tb_address;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_port;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_password;
        private MaterialSkin.Controls.MaterialRaisedButton bt_login;
    }
}