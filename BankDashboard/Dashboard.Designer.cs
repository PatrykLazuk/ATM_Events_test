namespace BankDashboard
{
    partial class Dashboard
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
            this.lAccountBalanceLabel = new System.Windows.Forms.Label();
            this.lAccountBalanceValue = new System.Windows.Forms.Label();
            this.lbAccoutActions = new System.Windows.Forms.ListBox();
            this.bATM = new System.Windows.Forms.Button();
            this.lOwner = new System.Windows.Forms.Label();
            this.lOwnerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAccountBalanceLabel
            // 
            this.lAccountBalanceLabel.AutoSize = true;
            this.lAccountBalanceLabel.Location = new System.Drawing.Point(33, 80);
            this.lAccountBalanceLabel.Name = "lAccountBalanceLabel";
            this.lAccountBalanceLabel.Size = new System.Drawing.Size(89, 13);
            this.lAccountBalanceLabel.TabIndex = 0;
            this.lAccountBalanceLabel.Text = "Account Balance";
            // 
            // lAccountBalanceValue
            // 
            this.lAccountBalanceValue.AutoSize = true;
            this.lAccountBalanceValue.Location = new System.Drawing.Point(36, 106);
            this.lAccountBalanceValue.Name = "lAccountBalanceValue";
            this.lAccountBalanceValue.Size = new System.Drawing.Size(13, 13);
            this.lAccountBalanceValue.TabIndex = 1;
            this.lAccountBalanceValue.Text = "0";
            // 
            // lbAccoutActions
            // 
            this.lbAccoutActions.FormattingEnabled = true;
            this.lbAccoutActions.Location = new System.Drawing.Point(181, 34);
            this.lbAccoutActions.Name = "lbAccoutActions";
            this.lbAccoutActions.Size = new System.Drawing.Size(322, 173);
            this.lbAccoutActions.TabIndex = 2;
            // 
            // bATM
            // 
            this.bATM.Location = new System.Drawing.Point(36, 148);
            this.bATM.Name = "bATM";
            this.bATM.Size = new System.Drawing.Size(114, 59);
            this.bATM.TabIndex = 3;
            this.bATM.Text = "ATM";
            this.bATM.UseVisualStyleBackColor = true;
            this.bATM.Click += new System.EventHandler(this.bATM_Click);
            // 
            // lOwner
            // 
            this.lOwner.AutoSize = true;
            this.lOwner.Location = new System.Drawing.Point(36, 34);
            this.lOwner.Name = "lOwner";
            this.lOwner.Size = new System.Drawing.Size(81, 13);
            this.lOwner.TabIndex = 4;
            this.lOwner.Text = "Account Owner";
            // 
            // lOwnerName
            // 
            this.lOwnerName.AutoSize = true;
            this.lOwnerName.Location = new System.Drawing.Point(36, 56);
            this.lOwnerName.Name = "lOwnerName";
            this.lOwnerName.Size = new System.Drawing.Size(0, 13);
            this.lOwnerName.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 362);
            this.Controls.Add(this.lOwnerName);
            this.Controls.Add(this.lOwner);
            this.Controls.Add(this.bATM);
            this.Controls.Add(this.lbAccoutActions);
            this.Controls.Add(this.lAccountBalanceValue);
            this.Controls.Add(this.lAccountBalanceLabel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAccountBalanceLabel;
        private System.Windows.Forms.Label lAccountBalanceValue;
        private System.Windows.Forms.ListBox lbAccoutActions;
        private System.Windows.Forms.Button bATM;
        private System.Windows.Forms.Label lOwner;
        private System.Windows.Forms.Label lOwnerName;
    }
}

