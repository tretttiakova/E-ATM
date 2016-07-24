namespace E_ATM
{
    partial class DepositForm
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
            this.depositAmount = new System.Windows.Forms.NumericUpDown();
            this.depositButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "amount";
            // 
            // depositAmount
            // 
            this.depositAmount.Location = new System.Drawing.Point(95, 44);
            this.depositAmount.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.depositAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(120, 20);
            this.depositAmount.TabIndex = 1;
            this.depositAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(15, 81);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "done";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // Deposit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 146);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.depositAmount);
            this.Controls.Add(this.label1);
            this.Name = "Deposit_form";
            this.Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)(this.depositAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.NumericUpDown depositAmount;
        private System.Windows.Forms.Label label1;
    }
}