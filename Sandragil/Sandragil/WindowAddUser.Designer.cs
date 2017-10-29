namespace Sandragil
{
    partial class WindowAddUser
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
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPW = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(41, 63);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(235, 32);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Enter Username: ";
            // 
            // LabelPW
            // 
            this.LabelPW.AutoSize = true;
            this.LabelPW.Location = new System.Drawing.Point(47, 149);
            this.LabelPW.Name = "LabelPW";
            this.LabelPW.Size = new System.Drawing.Size(222, 32);
            this.LabelPW.TabIndex = 1;
            this.LabelPW.Text = "Enter Password:";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(372, 56);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(261, 38);
            this.UsernameTextbox.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(372, 149);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(261, 38);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(372, 253);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(179, 77);
            this.AddUser.TabIndex = 4;
            this.AddUser.Text = "Add User!";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // WindowAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 613);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.LabelPW);
            this.Controls.Add(this.LabelUsername);
            this.Name = "WindowAddUser";
            this.Text = "WindowAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPW;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button AddUser;
    }
}