namespace MIS
{
    partial class Login
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
            this.ButtonAdministrator = new System.Windows.Forms.Button();
            this.ButtonNormalUser = new System.Windows.Forms.Button();
            this.Admin_logkey_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAdministrator
            // 
            this.ButtonAdministrator.Location = new System.Drawing.Point(40, 50);
            this.ButtonAdministrator.Name = "ButtonAdministrator";
            this.ButtonAdministrator.Size = new System.Drawing.Size(106, 41);
            this.ButtonAdministrator.TabIndex = 0;
            this.ButtonAdministrator.Text = "管理员登录";
            this.ButtonAdministrator.UseVisualStyleBackColor = true;
            this.ButtonAdministrator.Click += new System.EventHandler(this.ButtonAdministrator_Click);
            // 
            // ButtonNormalUser
            // 
            this.ButtonNormalUser.Location = new System.Drawing.Point(212, 50);
            this.ButtonNormalUser.Name = "ButtonNormalUser";
            this.ButtonNormalUser.Size = new System.Drawing.Size(105, 40);
            this.ButtonNormalUser.TabIndex = 1;
            this.ButtonNormalUser.Text = "用户登录";
            this.ButtonNormalUser.UseVisualStyleBackColor = true;
            this.ButtonNormalUser.Click += new System.EventHandler(this.ButtonNormalUser_Click);
            // 
            // Admin_logkey_TextBox
            // 
            this.Admin_logkey_TextBox.Location = new System.Drawing.Point(172, 123);
            this.Admin_logkey_TextBox.Name = "Admin_logkey_TextBox";
            this.Admin_logkey_TextBox.PasswordChar = '*';
            this.Admin_logkey_TextBox.Size = new System.Drawing.Size(145, 25);
            this.Admin_logkey_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(26, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "管理员密码";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin_logkey_TextBox);
            this.Controls.Add(this.ButtonNormalUser);
            this.Controls.Add(this.ButtonAdministrator);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdministrator;
        private System.Windows.Forms.Button ButtonNormalUser;
        private System.Windows.Forms.TextBox Admin_logkey_TextBox;
        private System.Windows.Forms.Label label1;
    }
}