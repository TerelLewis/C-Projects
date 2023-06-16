namespace GreenvilleRevenueGUI2
{
    partial class Form1
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
            this.lblLastYearContestants = new System.Windows.Forms.Label();
            this.lblThisYearContestants = new System.Windows.Forms.Label();
            this.txtLastYrContestants = new System.Windows.Forms.TextBox();
            this.txtThisYrContestants = new System.Windows.Forms.TextBox();
            this.BtnDisplayData = new System.Windows.Forms.Button();
            this.lblComparison = new System.Windows.Forms.Label();
            this.lblRevenueExpected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastYearContestants
            // 
            this.lblLastYearContestants.AutoSize = true;
            this.lblLastYearContestants.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastYearContestants.Location = new System.Drawing.Point(18, 18);
            this.lblLastYearContestants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastYearContestants.Name = "lblLastYearContestants";
            this.lblLastYearContestants.Size = new System.Drawing.Size(231, 19);
            this.lblLastYearContestants.TabIndex = 0;
            this.lblLastYearContestants.Text = "Enter number of contestants last year";
            this.lblLastYearContestants.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblThisYearContestants
            // 
            this.lblThisYearContestants.AutoSize = true;
            this.lblThisYearContestants.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisYearContestants.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblThisYearContestants.Location = new System.Drawing.Point(18, 61);
            this.lblThisYearContestants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThisYearContestants.Name = "lblThisYearContestants";
            this.lblThisYearContestants.Size = new System.Drawing.Size(231, 19);
            this.lblThisYearContestants.TabIndex = 1;
            this.lblThisYearContestants.Text = "Enter number of contestants this year";
            // 
            // txtLastYrContestants
            // 
            this.txtLastYrContestants.Location = new System.Drawing.Point(374, 18);
            this.txtLastYrContestants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastYrContestants.Name = "txtLastYrContestants";
            this.txtLastYrContestants.Size = new System.Drawing.Size(148, 26);
            this.txtLastYrContestants.TabIndex = 2;
            // 
            // txtThisYrContestants
            // 
            this.txtThisYrContestants.Location = new System.Drawing.Point(374, 63);
            this.txtThisYrContestants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThisYrContestants.Name = "txtThisYrContestants";
            this.txtThisYrContestants.Size = new System.Drawing.Size(148, 26);
            this.txtThisYrContestants.TabIndex = 3;
            // 
            // BtnDisplayData
            // 
            this.BtnDisplayData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDisplayData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDisplayData.Location = new System.Drawing.Point(128, 133);
            this.BtnDisplayData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDisplayData.Name = "BtnDisplayData";
            this.BtnDisplayData.Size = new System.Drawing.Size(152, 77);
            this.BtnDisplayData.TabIndex = 4;
            this.BtnDisplayData.Text = "Display Data";
            this.BtnDisplayData.UseVisualStyleBackColor = true;
            this.BtnDisplayData.Click += new System.EventHandler(this.BtnDisplayData_Click);
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Location = new System.Drawing.Point(124, 307);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(90, 19);
            this.lblComparison.TabIndex = 5;
            this.lblComparison.Text = "Comparison: ";
            // 
            // lblRevenueExpected
            // 
            this.lblRevenueExpected.AutoSize = true;
            this.lblRevenueExpected.Location = new System.Drawing.Point(115, 356);
            this.lblRevenueExpected.Name = "lblRevenueExpected";
            this.lblRevenueExpected.Size = new System.Drawing.Size(125, 19);
            this.lblRevenueExpected.TabIndex = 6;
            this.lblRevenueExpected.Text = "Revenue Expected:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.lblRevenueExpected);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.BtnDisplayData);
            this.Controls.Add(this.txtThisYrContestants);
            this.Controls.Add(this.txtLastYrContestants);
            this.Controls.Add(this.lblThisYearContestants);
            this.Controls.Add(this.lblLastYearContestants);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GreenvilleRevenueGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastYearContestants;
        private System.Windows.Forms.Label lblThisYearContestants;
        private System.Windows.Forms.TextBox txtLastYrContestants;
        private System.Windows.Forms.TextBox txtThisYrContestants;
        private System.Windows.Forms.Button BtnDisplayData;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Label lblRevenueExpected;
    }
}

