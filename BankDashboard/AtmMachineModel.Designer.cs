namespace BankDashboard
{
    partial class AtmMachineModel
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
            this.label1 = new System.Windows.Forms.Label();
            this.nValueOfTransfer = new System.Windows.Forms.NumericUpDown();
            this.bWithdrawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nValueOfTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of Cash to Withdraw";
            // 
            // nValueOfTransfer
            // 
            this.nValueOfTransfer.Location = new System.Drawing.Point(70, 75);
            this.nValueOfTransfer.Name = "nValueOfTransfer";
            this.nValueOfTransfer.Size = new System.Drawing.Size(120, 20);
            this.nValueOfTransfer.TabIndex = 1;
            // 
            // bWithdrawButton
            // 
            this.bWithdrawButton.Location = new System.Drawing.Point(70, 128);
            this.bWithdrawButton.Name = "bWithdrawButton";
            this.bWithdrawButton.Size = new System.Drawing.Size(139, 52);
            this.bWithdrawButton.TabIndex = 2;
            this.bWithdrawButton.Text = "Withdraw";
            this.bWithdrawButton.UseVisualStyleBackColor = true;
            this.bWithdrawButton.Click += new System.EventHandler(this.bWithdrawButton_Click);
            // 
            // AtmMachineModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 339);
            this.Controls.Add(this.bWithdrawButton);
            this.Controls.Add(this.nValueOfTransfer);
            this.Controls.Add(this.label1);
            this.Name = "AtmMachineModel";
            this.Text = "AtmMachineModel";
            ((System.ComponentModel.ISupportInitialize)(this.nValueOfTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nValueOfTransfer;
        private System.Windows.Forms.Button bWithdrawButton;
    }
}