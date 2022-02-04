namespace Treino1
{
    partial class Fase1
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
            this.mnStrip1 = new System.Windows.Forms.MenuStrip();
            this.trabaiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lujineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrip1
            // 
            this.mnStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mnStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabaiaToolStripMenuItem,
            this.lujineaToolStripMenuItem,
            this.gatasToolStripMenuItem});
            this.mnStrip1.Location = new System.Drawing.Point(0, 0);
            this.mnStrip1.Name = "mnStrip1";
            this.mnStrip1.Size = new System.Drawing.Size(800, 24);
            this.mnStrip1.TabIndex = 2;
            this.mnStrip1.Text = "menuStrip1";
            // 
            // trabaiaToolStripMenuItem
            // 
            this.trabaiaToolStripMenuItem.Name = "trabaiaToolStripMenuItem";
            this.trabaiaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.trabaiaToolStripMenuItem.Text = "Trabaia";
            this.trabaiaToolStripMenuItem.Click += new System.EventHandler(this.trabaiaToolStripMenuItem_Click);
            // 
            // lujineaToolStripMenuItem
            // 
            this.lujineaToolStripMenuItem.Name = "lujineaToolStripMenuItem";
            this.lujineaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.lujineaToolStripMenuItem.Text = "Lujinea";
            // 
            // gatasToolStripMenuItem
            // 
            this.gatasToolStripMenuItem.Name = "gatasToolStripMenuItem";
            this.gatasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.gatasToolStripMenuItem.Text = "Gatas";
            // 
            // Fase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnStrip1);
            this.MainMenuStrip = this.mnStrip1;
            this.Name = "Fase1";
            this.Text = "Fase1";
            this.mnStrip1.ResumeLayout(false);
            this.mnStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnStrip1;
        private System.Windows.Forms.ToolStripMenuItem trabaiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lujineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatasToolStripMenuItem;
    }
}