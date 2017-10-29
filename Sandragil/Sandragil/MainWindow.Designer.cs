namespace Sandragil
{
    partial class MainWindow
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
            this.wizzard = new System.Windows.Forms.Button();
            this.herpes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LabelHerpes = new System.Windows.Forms.Label();
            this.LabelWizzard = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizzard
            // 
            this.wizzard.Location = new System.Drawing.Point(339, 329);
            this.wizzard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.wizzard.Name = "wizzard";
            this.wizzard.Size = new System.Drawing.Size(200, 55);
            this.wizzard.TabIndex = 0;
            this.wizzard.Text = "start wizzard";
            this.wizzard.UseVisualStyleBackColor = true;
            this.wizzard.Click += new System.EventHandler(this.Start_Wizzard);
            // 
            // herpes
            // 
            this.herpes.Location = new System.Drawing.Point(757, 329);
            this.herpes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.herpes.Name = "herpes";
            this.herpes.Size = new System.Drawing.Size(200, 55);
            this.herpes.TabIndex = 1;
            this.herpes.Text = "start herpes";
            this.herpes.UseVisualStyleBackColor = true;
            this.herpes.Click += new System.EventHandler(this.Start_Herpes);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1264, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LabelHerpes
            // 
            this.LabelHerpes.AutoSize = true;
            this.LabelHerpes.Location = new System.Drawing.Point(771, 169);
            this.LabelHerpes.Name = "LabelHerpes";
            this.LabelHerpes.Size = new System.Drawing.Size(169, 32);
            this.LabelHerpes.TabIndex = 3;
            this.LabelHerpes.Text = "Play Herpes";
            // 
            // LabelWizzard
            // 
            this.LabelWizzard.AutoSize = true;
            this.LabelWizzard.Location = new System.Drawing.Point(339, 167);
            this.LabelWizzard.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LabelWizzard.Name = "LabelWizzard";
            this.LabelWizzard.Size = new System.Drawing.Size(180, 32);
            this.LabelWizzard.TabIndex = 4;
            this.LabelWizzard.Text = "Play Wizzard";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1803, 52);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(136, 48);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.changePWToolStripMenuItem,
            this.changeUNToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // changePWToolStripMenuItem
            // 
            this.changePWToolStripMenuItem.Name = "changePWToolStripMenuItem";
            this.changePWToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.changePWToolStripMenuItem.Text = "Change PW";
            // 
            // changeUNToolStripMenuItem
            // 
            this.changeUNToolStripMenuItem.Name = "changeUNToolStripMenuItem";
            this.changeUNToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.changeUNToolStripMenuItem.Text = "Change UN";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 696);
            this.Controls.Add(this.LabelWizzard);
            this.Controls.Add(this.LabelHerpes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.herpes);
            this.Controls.Add(this.wizzard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wizzard;
        private System.Windows.Forms.Button herpes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelHerpes;
        private System.Windows.Forms.Label LabelWizzard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUNToolStripMenuItem;
    }
}