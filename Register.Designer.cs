namespace FazanProiect
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelNickname = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonHide2 = new System.Windows.Forms.Button();
            this.buttonShow2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.White;
            this.labelLogin.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(158, 65);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(273, 63);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Register";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 160);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(93, 31);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(111, 160);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(274, 31);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(12, 284);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(153, 31);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(12, 346);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(280, 31);
            this.labelConfirmPassword.TabIndex = 7;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(171, 284);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(274, 31);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(298, 346);
            this.textBoxCPassword.Multiline = true;
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.PasswordChar = '*';
            this.textBoxCPassword.Size = new System.Drawing.Size(232, 31);
            this.textBoxCPassword.TabIndex = 9;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.White;
            this.buttonEnter.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(215, 442);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(126, 45);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.BackColor = System.Drawing.Color.White;
            this.labelNickname.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNickname.Location = new System.Drawing.Point(12, 222);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(151, 31);
            this.labelNickname.TabIndex = 11;
            this.labelNickname.Text = "Nickname";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(169, 222);
            this.textBoxNickname.Multiline = true;
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(274, 31);
            this.textBoxNickname.TabIndex = 12;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.White;
            this.buttonShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShow.BackgroundImage")));
            this.buttonShow.Location = new System.Drawing.Point(451, 284);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(31, 31);
            this.buttonShow.TabIndex = 13;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.White;
            this.buttonHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHide.BackgroundImage")));
            this.buttonHide.Location = new System.Drawing.Point(451, 284);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(31, 31);
            this.buttonHide.TabIndex = 14;
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Visible = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonHide2
            // 
            this.buttonHide2.BackColor = System.Drawing.Color.White;
            this.buttonHide2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHide2.BackgroundImage")));
            this.buttonHide2.Location = new System.Drawing.Point(536, 346);
            this.buttonHide2.Name = "buttonHide2";
            this.buttonHide2.Size = new System.Drawing.Size(31, 31);
            this.buttonHide2.TabIndex = 15;
            this.buttonHide2.UseVisualStyleBackColor = false;
            this.buttonHide2.Visible = false;
            this.buttonHide2.Click += new System.EventHandler(this.buttonHide2_Click);
            // 
            // buttonShow2
            // 
            this.buttonShow2.BackColor = System.Drawing.Color.White;
            this.buttonShow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShow2.BackgroundImage")));
            this.buttonShow2.Location = new System.Drawing.Point(536, 346);
            this.buttonShow2.Name = "buttonShow2";
            this.buttonShow2.Size = new System.Drawing.Size(31, 31);
            this.buttonShow2.TabIndex = 16;
            this.buttonShow2.UseVisualStyleBackColor = false;
            this.buttonShow2.Click += new System.EventHandler(this.buttonShow2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.buttonShow2);
            this.Controls.Add(this.buttonHide2);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxCPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonHide2;
        private System.Windows.Forms.Button buttonShow2;
    }
}