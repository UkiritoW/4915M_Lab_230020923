namespace _4915M_Lab
{
    partial class Lab3a
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
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.btnCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the Future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(94, 117);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(121, 21);
            this.cboMovie.TabIndex = 0;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(91, 56);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(157, 13);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "My Choice of Best Movie Series";
            this.lblCast.Click += new System.EventHandler(this.lblCast_Click);
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(106, 203);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(75, 23);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cast your vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // Lab3a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 324);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.cboMovie);
            this.Name = "Lab3a";
            this.Text = "Lab3a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Button btnCast;
    }
}