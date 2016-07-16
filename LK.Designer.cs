namespace E_ATM
{
    partial class LK
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
            this.exitButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 482);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(103, 482);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 1;
            this.signOutButton.Text = "Sign out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(81, 13);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(13, 13);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "0";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(15, 63);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(15, 93);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(15, 123);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(75, 23);
            this.transferButton.TabIndex = 6;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            // 
            // LK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 517);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.exitButton);
            this.Name = "LK";
            this.Text = "LK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button transferButton;
    }
}