namespace Login_App
{
    partial class UserRegistration
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
            this.New_Username = new System.Windows.Forms.Label();
            this.New_Password = new System.Windows.Forms.Label();
            this.Repeat_Password = new System.Windows.Forms.Label();
            this.NewUsername = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.RepeatPassword = new System.Windows.Forms.TextBox();
            this.HidePassword = new System.Windows.Forms.CheckBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Username
            // 
            this.New_Username.AutoSize = true;
            this.New_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Username.Location = new System.Drawing.Point(36, 21);
            this.New_Username.Name = "New_Username";
            this.New_Username.Size = new System.Drawing.Size(141, 24);
            this.New_Username.TabIndex = 0;
            this.New_Username.Text = "New Username";
            // 
            // New_Password
            // 
            this.New_Password.AutoSize = true;
            this.New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Password.Location = new System.Drawing.Point(36, 45);
            this.New_Password.Name = "New_Password";
            this.New_Password.Size = new System.Drawing.Size(136, 24);
            this.New_Password.TabIndex = 1;
            this.New_Password.Text = "New Password";
            // 
            // Repeat_Password
            // 
            this.Repeat_Password.AutoSize = true;
            this.Repeat_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_Password.Location = new System.Drawing.Point(36, 69);
            this.Repeat_Password.Name = "Repeat_Password";
            this.Repeat_Password.Size = new System.Drawing.Size(157, 24);
            this.Repeat_Password.TabIndex = 2;
            this.Repeat_Password.Text = "Repeat Password";
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(221, 24);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(141, 20);
            this.NewUsername.TabIndex = 3;
            this.NewUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginByEnter);
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(221, 50);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(141, 20);
            this.NewPassword.TabIndex = 4;
            this.NewPassword.UseSystemPasswordChar = true;
            this.NewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginByEnter);
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.Location = new System.Drawing.Point(221, 76);
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Size = new System.Drawing.Size(141, 20);
            this.RepeatPassword.TabIndex = 5;
            this.RepeatPassword.UseSystemPasswordChar = true;
            this.RepeatPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginByEnter);
            // 
            // HidePassword
            // 
            this.HidePassword.AutoSize = true;
            this.HidePassword.Checked = true;
            this.HidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HidePassword.Location = new System.Drawing.Point(241, 102);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(103, 17);
            this.HidePassword.TabIndex = 6;
            this.HidePassword.Text = "Hide Password?";
            this.HidePassword.UseVisualStyleBackColor = true;
            this.HidePassword.CheckedChanged += new System.EventHandler(this.HidePasswordCheck);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(241, 125);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(95, 36);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 180);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.RepeatPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewUsername);
            this.Controls.Add(this.Repeat_Password);
            this.Controls.Add(this.New_Password);
            this.Controls.Add(this.New_Username);
            this.Name = "UserRegistration";
            this.Text = "UserRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label New_Username;
        private System.Windows.Forms.Label New_Password;
        private System.Windows.Forms.Label Repeat_Password;
        private System.Windows.Forms.TextBox NewUsername;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox RepeatPassword;
        private System.Windows.Forms.CheckBox HidePassword;
        private System.Windows.Forms.Button ConfirmButton;
    }
}