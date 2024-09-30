namespace ProjectClassicModels
{
    partial class login
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
            this.lgnBtn = new ReaLTaiizor.Controls.FoxButton();
            this.Cancel = new ReaLTaiizor.Controls.FoxButton();
            this.password = new ReaLTaiizor.Controls.SmallTextBox();
            this.userName = new ReaLTaiizor.Controls.SmallTextBox();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel2 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            this.SuspendLayout();
            // 
            // lgnBtn
            // 
            this.lgnBtn.BackColor = System.Drawing.Color.Transparent;
            this.lgnBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lgnBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lgnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgnBtn.DisabledBaseColor = System.Drawing.Color.Silver;
            this.lgnBtn.DisabledBorderColor = System.Drawing.Color.Silver;
            this.lgnBtn.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.lgnBtn.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lgnBtn.EnabledCalc = true;
            this.lgnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lgnBtn.Location = new System.Drawing.Point(505, 301);
            this.lgnBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lgnBtn.Size = new System.Drawing.Size(105, 38);
            this.lgnBtn.TabIndex = 0;
            this.lgnBtn.Text = "Login";
            this.lgnBtn.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.foxButton1_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DisabledBaseColor = System.Drawing.Color.Silver;
            this.Cancel.DisabledBorderColor = System.Drawing.Color.Silver;
            this.Cancel.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.Cancel.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cancel.EnabledCalc = true;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cancel.Location = new System.Drawing.Point(617, 301);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Cancel.Size = new System.Drawing.Size(105, 38);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.White;
            this.password.CustomBGColor = System.Drawing.Color.Silver;
            this.password.Font = new System.Drawing.Font("Tahoma", 11F);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(349, 267);
            this.password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(373, 28);
            this.password.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.password.TabIndex = 2;
            this.password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.UseSystemPasswordChar = false;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.BorderColor = System.Drawing.Color.White;
            this.userName.CustomBGColor = System.Drawing.Color.Silver;
            this.userName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.userName.ForeColor = System.Drawing.Color.DimGray;
            this.userName.Location = new System.Drawing.Point(349, 233);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userName.MaxLength = 32767;
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.ReadOnly = false;
            this.userName.Size = new System.Drawing.Size(373, 28);
            this.userName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.userName.TabIndex = 3;
            this.userName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.UseSystemPasswordChar = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel1.Location = new System.Drawing.Point(210, 233);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(132, 28);
            this.headerLabel1.TabIndex = 4;
            this.headerLabel1.Text = "Username";
            this.headerLabel1.Click += new System.EventHandler(this.headerLabel1_Click);
            // 
            // headerLabel2
            // 
            this.headerLabel2.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.headerLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel2.Location = new System.Drawing.Point(210, 267);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(132, 28);
            this.headerLabel2.TabIndex = 5;
            this.headerLabel2.Text = "Password";
            // 
            // headerLabel3
            // 
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.headerLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel3.Location = new System.Drawing.Point(384, 109);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(200, 63);
            this.headerLabel3.TabIndex = 7;
            this.headerLabel3.Text = "LOGIN\r\n";
            this.headerLabel3.Click += new System.EventHandler(this.headerLabel3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(933, 513);
            this.Controls.Add(this.headerLabel3);
            this.Controls.Add(this.headerLabel2);
            this.Controls.Add(this.headerLabel1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.lgnBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.FoxButton lgnBtn;
        private ReaLTaiizor.Controls.FoxButton Cancel;
        private ReaLTaiizor.Controls.SmallTextBox password;
        private ReaLTaiizor.Controls.SmallTextBox userName;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
    }
}

