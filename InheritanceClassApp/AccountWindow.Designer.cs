namespace InheritanceClassApp
{
    partial class AccountWindow
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
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lstCheckingCustomers = new System.Windows.Forms.ListBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lstSavingsCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboAccounts
            // 
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.cboAccounts.Location = new System.Drawing.Point(12, 92);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(121, 25);
            this.cboAccounts.TabIndex = 0;
            this.cboAccounts.Visible = false;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Niagara Engraved", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(27, 68);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(79, 21);
            this.lblAccountType.TabIndex = 1;
            this.lblAccountType.Text = "Account Type";
            // 
            // lstCheckingCustomers
            // 
            this.lstCheckingCustomers.FormattingEnabled = true;
            this.lstCheckingCustomers.ItemHeight = 17;
            this.lstCheckingCustomers.Location = new System.Drawing.Point(178, 92);
            this.lstCheckingCustomers.Name = "lstCheckingCustomers";
            this.lstCheckingCustomers.Size = new System.Drawing.Size(172, 89);
            this.lstCheckingCustomers.TabIndex = 2;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Niagara Engraved", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(235, 68);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(64, 21);
            this.lblCustomers.TabIndex = 3;
            this.lblCustomers.Text = "Customers";
            // 
            // lstSavingsCustomers
            // 
            this.lstSavingsCustomers.FormattingEnabled = true;
            this.lstSavingsCustomers.ItemHeight = 17;
            this.lstSavingsCustomers.Location = new System.Drawing.Point(178, 141);
            this.lstSavingsCustomers.Name = "lstSavingsCustomers";
            this.lstSavingsCustomers.Size = new System.Drawing.Size(172, 89);
            this.lstSavingsCustomers.TabIndex = 4;
            // 
            // AccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(362, 343);
            this.Controls.Add(this.lstSavingsCustomers);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lstCheckingCustomers);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.cboAccounts);
            this.Font = new System.Drawing.Font("Niagara Engraved", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "AccountWindow";
            this.Text = "Customer Account Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAccounts;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ListBox lstCheckingCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.ListBox lstSavingsCustomers;
    }
}

