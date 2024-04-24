namespace School_Management_System
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelContent);
            this.panel1.Controls.Add(this.PanelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Size = new System.Drawing.Size(375, 423);
            this.panel1.TabIndex = 0;
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.btExit);
            this.PanelContent.Controls.Add(this.btLogin);
            this.PanelContent.Controls.Add(this.txtPassword);
            this.PanelContent.Controls.Add(this.txtUsername);
            this.PanelContent.Controls.Add(this.picPass);
            this.PanelContent.Controls.Add(this.picUser);
            this.PanelContent.Controls.Add(this.label1);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(2, 30);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(371, 392);
            this.PanelContent.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(73, 124);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(73, 80);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(231, 30);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            // 
            // picPass
            // 
            this.picPass.Image = global::School_Management_System.Properties.Resources.padlock;
            this.picPass.Location = new System.Drawing.Point(44, 129);
            this.picPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(23, 22);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 2;
            this.picPass.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::School_Management_System.Properties.Resources.user;
            this.picUser.Location = new System.Drawing.Point(44, 84);
            this.picUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(23, 22);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Silver;
            this.PanelHeader.Controls.Add(this.btMinimize);
            this.PanelHeader.Controls.Add(this.btClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(2, 1);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(371, 29);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.White;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimize.ForeColor = System.Drawing.Color.Black;
            this.btMinimize.Location = new System.Drawing.Point(270, -2);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(50, 30);
            this.btMinimize.TabIndex = 1;
            this.btMinimize.Text = "-";
            this.btMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Red;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(321, -2);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(50, 30);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "x";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(83, 220);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(184, 32);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Blue;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(83, 180);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(184, 32);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 431);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
    }
}

