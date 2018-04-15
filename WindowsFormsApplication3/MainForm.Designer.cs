namespace WindowsFormsApplication3
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törzsadatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szolgáltatásIgénybevételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számlaKészítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szolgáltatásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.műveletekToolStripMenuItem,
            this.törzsadatokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // műveletekToolStripMenuItem
            // 
            this.műveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szolgáltatásIgénybevételeToolStripMenuItem,
            this.számlaKészítéseToolStripMenuItem});
            this.műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            this.műveletekToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.műveletekToolStripMenuItem.Text = "Műveletek";
            // 
            // törzsadatokToolStripMenuItem
            // 
            this.törzsadatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ügyfelekToolStripMenuItem,
            this.szolgáltatásokToolStripMenuItem});
            this.törzsadatokToolStripMenuItem.Name = "törzsadatokToolStripMenuItem";
            this.törzsadatokToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.törzsadatokToolStripMenuItem.Text = "Törzsadatok";
            // 
            // szolgáltatásIgénybevételeToolStripMenuItem
            // 
            this.szolgáltatásIgénybevételeToolStripMenuItem.Name = "szolgáltatásIgénybevételeToolStripMenuItem";
            this.szolgáltatásIgénybevételeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.szolgáltatásIgénybevételeToolStripMenuItem.Text = "Szolgáltatás igénybevétele";
            this.szolgáltatásIgénybevételeToolStripMenuItem.Click += new System.EventHandler(this.szolgáltatásIgénybevételeToolStripMenuItem_Click);
            // 
            // ügyfelekToolStripMenuItem
            // 
            this.ügyfelekToolStripMenuItem.Name = "ügyfelekToolStripMenuItem";
            this.ügyfelekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ügyfelekToolStripMenuItem.Text = "Ügyfelek";
            this.ügyfelekToolStripMenuItem.Click += new System.EventHandler(this.ügyfelekToolStripMenuItem_Click);
            // 
            // számlaKészítéseToolStripMenuItem
            // 
            this.számlaKészítéseToolStripMenuItem.Name = "számlaKészítéseToolStripMenuItem";
            this.számlaKészítéseToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.számlaKészítéseToolStripMenuItem.Text = "Számla készítése";
            this.számlaKészítéseToolStripMenuItem.Click += new System.EventHandler(this.számlaKészítéseToolStripMenuItem_Click);
            // 
            // szolgáltatásokToolStripMenuItem
            // 
            this.szolgáltatásokToolStripMenuItem.Name = "szolgáltatásokToolStripMenuItem";
            this.szolgáltatásokToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.szolgáltatásokToolStripMenuItem.Text = "Szolgáltatások";
            this.szolgáltatásokToolStripMenuItem.Click += new System.EventHandler(this.szolgáltatásokToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 407);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törzsadatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szolgáltatásIgénybevételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem számlaKészítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szolgáltatásokToolStripMenuItem;
    }
}