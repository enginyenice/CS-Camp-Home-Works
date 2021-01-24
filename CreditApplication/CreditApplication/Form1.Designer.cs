
namespace CreditApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedList = new System.Windows.Forms.ListBox();
            this.ConsumerCreditCheck = new System.Windows.Forms.CheckBox();
            this.MortgageCreditCheck = new System.Windows.Forms.CheckBox();
            this.VehicleCreditCheck = new System.Windows.Forms.CheckBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CreditAmountNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CreditAmountNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedList
            // 
            this.SelectedList.FormattingEnabled = true;
            this.SelectedList.ItemHeight = 15;
            this.SelectedList.Location = new System.Drawing.Point(182, 8);
            this.SelectedList.Name = "SelectedList";
            this.SelectedList.Size = new System.Drawing.Size(273, 94);
            this.SelectedList.TabIndex = 0;
            // 
            // ConsumerCreditCheck
            // 
            this.ConsumerCreditCheck.AutoSize = true;
            this.ConsumerCreditCheck.Location = new System.Drawing.Point(12, 12);
            this.ConsumerCreditCheck.Name = "ConsumerCreditCheck";
            this.ConsumerCreditCheck.Size = new System.Drawing.Size(116, 19);
            this.ConsumerCreditCheck.TabIndex = 1;
            this.ConsumerCreditCheck.Text = "Consumer Credit";
            this.ConsumerCreditCheck.UseVisualStyleBackColor = true;
            // 
            // MortgageCreditCheck
            // 
            this.MortgageCreditCheck.AutoSize = true;
            this.MortgageCreditCheck.Location = new System.Drawing.Point(12, 46);
            this.MortgageCreditCheck.Name = "MortgageCreditCheck";
            this.MortgageCreditCheck.Size = new System.Drawing.Size(113, 19);
            this.MortgageCreditCheck.TabIndex = 2;
            this.MortgageCreditCheck.Text = "Mortgage Credit";
            this.MortgageCreditCheck.UseVisualStyleBackColor = true;
            // 
            // VehicleCreditCheck
            // 
            this.VehicleCreditCheck.AutoSize = true;
            this.VehicleCreditCheck.Location = new System.Drawing.Point(12, 84);
            this.VehicleCreditCheck.Name = "VehicleCreditCheck";
            this.VehicleCreditCheck.Size = new System.Drawing.Size(98, 19);
            this.VehicleCreditCheck.TabIndex = 3;
            this.VehicleCreditCheck.Text = "Vehicle Credit";
            this.VehicleCreditCheck.UseVisualStyleBackColor = true;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(182, 108);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(273, 29);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // CreditAmountNumber
            // 
            this.CreditAmountNumber.Location = new System.Drawing.Point(12, 114);
            this.CreditAmountNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.CreditAmountNumber.Name = "CreditAmountNumber";
            this.CreditAmountNumber.Size = new System.Drawing.Size(140, 23);
            this.CreditAmountNumber.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 148);
            this.Controls.Add(this.CreditAmountNumber);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.VehicleCreditCheck);
            this.Controls.Add(this.MortgageCreditCheck);
            this.Controls.Add(this.ConsumerCreditCheck);
            this.Controls.Add(this.SelectedList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CreditAmountNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SelectedList;
        private System.Windows.Forms.CheckBox ConsumerCreditCheck;
        private System.Windows.Forms.CheckBox MortgageCreditCheck;
        private System.Windows.Forms.CheckBox VehicleCreditCheck;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.NumericUpDown CreditAmountNumber;
    }
}

