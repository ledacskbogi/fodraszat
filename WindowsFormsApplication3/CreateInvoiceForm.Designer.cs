namespace WindowsFormsApplication3
{
    partial class CreateInvoiceForm
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
            this.cmbUgyfel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCreateInvoice = new System.Windows.Forms.Button();
            this.txtInvoice = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbUgyfel
            // 
            this.cmbUgyfel.FormattingEnabled = true;
            this.cmbUgyfel.Location = new System.Drawing.Point(144, 16);
            this.cmbUgyfel.Name = "cmbUgyfel";
            this.cmbUgyfel.Size = new System.Drawing.Size(121, 21);
            this.cmbUgyfel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ügyfél azonosító";
            // 
            // cmdCreateInvoice
            // 
            this.cmdCreateInvoice.Location = new System.Drawing.Point(350, 14);
            this.cmdCreateInvoice.Name = "cmdCreateInvoice";
            this.cmdCreateInvoice.Size = new System.Drawing.Size(145, 23);
            this.cmdCreateInvoice.TabIndex = 2;
            this.cmdCreateInvoice.Text = "Számla készítés";
            this.cmdCreateInvoice.UseVisualStyleBackColor = true;
            this.cmdCreateInvoice.Click += new System.EventHandler(this.cmdCreateInvoice_Click);
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(28, 62);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(467, 188);
            this.txtInvoice.TabIndex = 3;
            this.txtInvoice.Text = "";
            this.txtInvoice.TextChanged += new System.EventHandler(this.txtInvoice_TextChanged);
            // 
            // CreateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 263);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.cmdCreateInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUgyfel);
            this.Name = "CreateInvoiceForm";
            this.Text = "Számla készítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUgyfel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCreateInvoice;
        private System.Windows.Forms.RichTextBox txtInvoice;
    }
}