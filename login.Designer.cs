namespace FtpClient
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.port = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.Depth = 0;
            this.address.Hint = "Address";
            this.address.Location = new System.Drawing.Point(133, 125);
            this.address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address.MaxLength = 32767;
            this.address.MouseState = MaterialSkin.MouseState.HOVER;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.SelectedText = "";
            this.address.SelectionLength = 0;
            this.address.SelectionStart = 0;
            this.address.Size = new System.Drawing.Size(167, 28);
            this.address.TabIndex = 1;
            this.address.TabStop = false;
            this.address.UseSystemPasswordChar = false;
            // 
            // port
            // 
            this.port.Depth = 0;
            this.port.Hint = "Port";
            this.port.Location = new System.Drawing.Point(333, 125);
            this.port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.port.MaxLength = 32767;
            this.port.MouseState = MaterialSkin.MouseState.HOVER;
            this.port.Name = "port";
            this.port.PasswordChar = '\0';
            this.port.SelectedText = "";
            this.port.SelectionLength = 0;
            this.port.SelectionStart = 0;
            this.port.Size = new System.Drawing.Size(67, 28);
            this.port.TabIndex = 2;
            this.port.TabStop = false;
            this.port.UseSystemPasswordChar = false;
            // 
            // username
            // 
            this.username.Depth = 0;
            this.username.Hint = "Username";
            this.username.Location = new System.Drawing.Point(133, 175);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.MaxLength = 32767;
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(267, 28);
            this.username.TabIndex = 3;
            this.username.TabStop = false;
            this.username.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Password";
            this.password.Location = new System.Drawing.Point(133, 225);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.MaxLength = 32767;
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(267, 28);
            this.password.TabIndex = 4;
            this.password.TabStop = false;
            this.password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Depth = 0;
            this.login.Icon = null;
            this.login.Location = new System.Drawing.Point(221, 288);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.MouseState = MaterialSkin.MouseState.HOVER;
            this.login.Name = "login";
            this.login.Primary = true;
            this.login.Size = new System.Drawing.Size(80, 36);
            this.login.TabIndex = 5;
            this.login.Text = "Log  in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Login_Form
            // 
            this.AcceptButton = this.login;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 375);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.port);
            this.Controls.Add(this.address);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(533, 375);
            this.Name = "Login_Form";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Client - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField address;
        private MaterialSkin.Controls.MaterialSingleLineTextField port;
        private MaterialSkin.Controls.MaterialSingleLineTextField username;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialRaisedButton login;
    }
}