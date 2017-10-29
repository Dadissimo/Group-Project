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
            this.button1 = new System.Windows.Forms.Button();
            this.herpes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LabelHerpes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.herpes.MouseHover += new System.EventHandler(this.Herpes_Hover);
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
            this.LabelHerpes.Location = new System.Drawing.Point(770, 169);
            this.LabelHerpes.Name = "LabelHerpes";
            this.LabelHerpes.Size = new System.Drawing.Size(169, 32);
            this.LabelHerpes.TabIndex = 3;
            this.LabelHerpes.Text = "Play Herpes";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 696);
            this.Controls.Add(this.LabelHerpes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.herpes);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button herpes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelHerpes;
    }
}