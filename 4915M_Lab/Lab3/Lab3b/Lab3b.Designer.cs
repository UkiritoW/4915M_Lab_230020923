namespace _4915M_Lab
{
    partial class Lab3b
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblMillion = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(65, 55);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblRate
            // 
            this.lblRate.Location = new System.Drawing.Point(65, 88);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(70, 28);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate (Annual)";
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(65, 196);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(87, 27);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value after 10 years";
            this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
            // 
            // lblValue2
            // 
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue2.Location = new System.Drawing.Point(180, 196);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(100, 23);
            this.lblValue2.TabIndex = 3;
            this.lblValue2.Click += new System.EventHandler(this.lblValue2_Click);
            // 
            // lblMillion
            // 
            this.lblMillion.Location = new System.Drawing.Point(65, 247);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(87, 30);
            this.lblMillion.TabIndex = 4;
            this.lblMillion.Text = "Years to reach $1M";
            this.lblMillion.Click += new System.EventHandler(this.lblMillion_Click);
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Location = new System.Drawing.Point(180, 247);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(100, 23);
            this.lblMillion2.TabIndex = 5;
            this.lblMillion2.Click += new System.EventHandler(this.lblMillion2_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(173, 52);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(173, 85);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 7;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(68, 136);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(205, 30);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Lab3b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 339);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "Lab3b";
            this.Text = "Compound Interest";
            this.Load += new System.EventHandler(this.Lab3b_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblMillion;
        private System.Windows.Forms.Label lblMillion2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnCalculate;
    }
}