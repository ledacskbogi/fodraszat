namespace WindowsFormsApplication3
{
    partial class UsedServiceForm
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtSzolgaltatasNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUgyfel = new System.Windows.Forms.ComboBox();
            this.cmbSzolgaltatas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(173, 227);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Mentés";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtSzolgaltatasNev
            // 
            this.txtSzolgaltatasNev.Location = new System.Drawing.Point(148, 129);
            this.txtSzolgaltatasNev.Name = "txtSzolgaltatasNev";
            this.txtSzolgaltatasNev.Size = new System.Drawing.Size(121, 20);
            this.txtSzolgaltatasNev.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szolgáltatás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Szolgáltatás megnevezése";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ügyfél azonosító";
            // 
            // cmbUgyfel
            // 
            this.cmbUgyfel.FormattingEnabled = true;
            this.cmbUgyfel.Location = new System.Drawing.Point(148, 21);
            this.cmbUgyfel.Name = "cmbUgyfel";
            this.cmbUgyfel.Size = new System.Drawing.Size(121, 21);
            this.cmbUgyfel.TabIndex = 8;
            // 
            // cmbSzolgaltatas
            // 
            this.cmbSzolgaltatas.FormattingEnabled = true;
            this.cmbSzolgaltatas.Location = new System.Drawing.Point(148, 51);
            this.cmbSzolgaltatas.Name = "cmbSzolgaltatas";
            this.cmbSzolgaltatas.Size = new System.Drawing.Size(121, 21);
            this.cmbSzolgaltatas.TabIndex = 9;
            this.cmbSzolgaltatas.SelectedIndexChanged += new System.EventHandler(this.cmbSzolgaltatas_SelectedIndexChanged);
            // 
            // UsedServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 262);
            this.Controls.Add(this.cmbSzolgaltatas);
            this.Controls.Add(this.cmbUgyfel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSzolgaltatasNev);
            this.Controls.Add(this.cmdSave);
            this.Name = "UsedServiceForm";
            this.Text = "Szolgáltatás igénybevétele";
            this.Load += new System.EventHandler(this.UsedServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtSzolgaltatasNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUgyfel;
        private System.Windows.Forms.ComboBox cmbSzolgaltatas;
    }
}

