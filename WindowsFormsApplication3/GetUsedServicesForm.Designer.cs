namespace WindowsFormsApplication3
{
    partial class GetUsedServicesForm
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
            this.txtUsedServices = new System.Windows.Forms.RichTextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUsedServices
            // 
            this.txtUsedServices.Location = new System.Drawing.Point(12, 77);
            this.txtUsedServices.Name = "txtUsedServices";
            this.txtUsedServices.Size = new System.Drawing.Size(198, 157);
            this.txtUsedServices.TabIndex = 0;
            this.txtUsedServices.Text = "";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(134, 35);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.Text = "Keresés";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(12, 35);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(97, 21);
            this.cmbCustomer.TabIndex = 2;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // GetUsedServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 262);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtUsedServices);
            this.Name = "GetUsedServicesForm";
            this.Text = "Igénybevett szolgáltatások";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtUsedServices;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}