namespace E_ATM
{
    partial class Withdraw
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
            this.withdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.doneWithdrawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawAmount
            // 
            this.withdrawAmount.Location = new System.Drawing.Point(97, 45);
            this.withdrawAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.withdrawAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.withdrawAmount.Name = "withdrawAmount";
            this.withdrawAmount.Size = new System.Drawing.Size(120, 20);
            this.withdrawAmount.TabIndex = 0;
            this.withdrawAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "amount";
            // 
            // doneWithdrawButton
            // 
            this.doneWithdrawButton.Location = new System.Drawing.Point(36, 85);
            this.doneWithdrawButton.Name = "doneWithdrawButton";
            this.doneWithdrawButton.Size = new System.Drawing.Size(75, 23);
            this.doneWithdrawButton.TabIndex = 2;
            this.doneWithdrawButton.Text = "done";
            this.doneWithdrawButton.UseVisualStyleBackColor = true;
            this.doneWithdrawButton.Click += new System.EventHandler(this.doneWithdrawButton_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 149);
            this.Controls.Add(this.doneWithdrawButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawAmount);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            ((System.ComponentModel.ISupportInitialize)(this.withdrawAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown withdrawAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneWithdrawButton;
    }
}