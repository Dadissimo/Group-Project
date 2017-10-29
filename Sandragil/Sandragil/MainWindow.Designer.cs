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
            this.SuspendLayout();
            // 
            // wizzard
            // 
            this.wizzard.Location = new System.Drawing.Point(127, 138);
            this.wizzard.Name = "wizzard";
            this.wizzard.Size = new System.Drawing.Size(75, 23);
            this.wizzard.TabIndex = 0;
            this.wizzard.Text = "start wizzard";
            this.wizzard.UseVisualStyleBackColor = true;
            this.wizzard.Click += new System.EventHandler(this.Start_Wizzard);
            // 
            // herpes
            // 
            this.herpes.Location = new System.Drawing.Point(284, 138);
            this.herpes.Name = "herpes";
            this.herpes.Size = new System.Drawing.Size(75, 23);
            this.herpes.TabIndex = 1;
            this.herpes.Text = "start herpes";
            this.herpes.UseVisualStyleBackColor = true;
            this.herpes.Click += new System.EventHandler(this.Start_Herpes);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LabelHerpes
            // 
            this.LabelHerpes.AutoSize = true;
            this.LabelHerpes.Location = new System.Drawing.Point(289, 71);
            this.LabelHerpes.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelHerpes.Name = "LabelHerpes";
            this.LabelHerpes.Size = new System.Drawing.Size(64, 13);
            this.LabelHerpes.TabIndex = 3;
            this.LabelHerpes.Text = "Play Herpes";
            // 
            // LabelWizzard
            // 
            this.LabelWizzard.AutoSize = true;
            this.LabelWizzard.Location = new System.Drawing.Point(127, 70);
            this.LabelWizzard.Name = "LabelWizzard";
            this.LabelWizzard.Size = new System.Drawing.Size(68, 13);
            this.LabelWizzard.TabIndex = 4;
            this.LabelWizzard.Text = "Play Wizzard";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 292);
            this.Controls.Add(this.LabelWizzard);
            this.Controls.Add(this.LabelHerpes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.herpes);
            this.Controls.Add(this.wizzard);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wizzard;
        private System.Windows.Forms.Button herpes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelHerpes;
        private System.Windows.Forms.Label LabelWizzard;
    }
}