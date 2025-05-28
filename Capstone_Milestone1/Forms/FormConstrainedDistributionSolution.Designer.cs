namespace Capstone_Milestone1.Forms
{
    partial class FormConstrainedDistributionSolution
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.Fpnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblDistributionCount = new System.Windows.Forms.Label();
            this.LblDistribution = new System.Windows.Forms.Label();
            this.Fpnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnVisualisation = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.LblDistributionCounter = new System.Windows.Forms.Label();
            this.LblSolution = new System.Windows.Forms.Label();
            this.LblDristributionDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(228, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(71, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Solution:";
            // 
            // Fpnl1
            // 
            this.Fpnl1.Location = new System.Drawing.Point(3, 62);
            this.Fpnl1.Name = "Fpnl1";
            this.Fpnl1.Size = new System.Drawing.Size(1150, 230);
            this.Fpnl1.TabIndex = 1;
            // 
            // LblDistributionCount
            // 
            this.LblDistributionCount.AutoSize = true;
            this.LblDistributionCount.Location = new System.Drawing.Point(51, 387);
            this.LblDistributionCount.Name = "LblDistributionCount";
            this.LblDistributionCount.Size = new System.Drawing.Size(154, 20);
            this.LblDistributionCount.TabIndex = 2;
            this.LblDistributionCount.Text = "Distribution Counter:";
            // 
            // LblDistribution
            // 
            this.LblDistribution.AutoSize = true;
            this.LblDistribution.Location = new System.Drawing.Point(55, 438);
            this.LblDistribution.Name = "LblDistribution";
            this.LblDistribution.Size = new System.Drawing.Size(93, 20);
            this.LblDistribution.TabIndex = 3;
            this.LblDistribution.Text = "Distribution:";
            // 
            // Fpnl2
            // 
            this.Fpnl2.Location = new System.Drawing.Point(37, 566);
            this.Fpnl2.Name = "Fpnl2";
            this.Fpnl2.Size = new System.Drawing.Size(1150, 230);
            this.Fpnl2.TabIndex = 4;
            // 
            // BtnVisualisation
            // 
            this.BtnVisualisation.Location = new System.Drawing.Point(519, 876);
            this.BtnVisualisation.Name = "BtnVisualisation";
            this.BtnVisualisation.Size = new System.Drawing.Size(163, 46);
            this.BtnVisualisation.TabIndex = 5;
            this.BtnVisualisation.Text = "Click To Visualize";
            this.BtnVisualisation.UseVisualStyleBackColor = true;
            this.BtnVisualisation.Click += new System.EventHandler(this.BtnVisualisation_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(862, 876);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(133, 46);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(204, 876);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(132, 46);
            this.BtnPrevious.TabIndex = 7;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // LblDistributionCounter
            // 
            this.LblDistributionCounter.AutoSize = true;
            this.LblDistributionCounter.Location = new System.Drawing.Point(198, 387);
            this.LblDistributionCounter.Name = "LblDistributionCounter";
            this.LblDistributionCounter.Size = new System.Drawing.Size(0, 20);
            this.LblDistributionCounter.TabIndex = 8;
            // 
            // LblSolution
            // 
            this.LblSolution.AutoSize = true;
            this.LblSolution.Location = new System.Drawing.Point(306, 13);
            this.LblSolution.Name = "LblSolution";
            this.LblSolution.Size = new System.Drawing.Size(0, 20);
            this.LblSolution.TabIndex = 9;
            // 
            // LblDristributionDetails
            // 
            this.LblDristributionDetails.AutoSize = true;
            this.LblDristributionDetails.Location = new System.Drawing.Point(202, 438);
            this.LblDristributionDetails.Name = "LblDristributionDetails";
            this.LblDristributionDetails.Size = new System.Drawing.Size(0, 20);
            this.LblDristributionDetails.TabIndex = 10;
            // 
            // FormConstrainedDistributionSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 946);
            this.Controls.Add(this.LblDristributionDetails);
            this.Controls.Add(this.LblSolution);
            this.Controls.Add(this.LblDistributionCounter);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnVisualisation);
            this.Controls.Add(this.Fpnl2);
            this.Controls.Add(this.LblDistribution);
            this.Controls.Add(this.LblDistributionCount);
            this.Controls.Add(this.Fpnl1);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConstrainedDistributionSolution";
            this.Text = "FormConstrainedDistributionSolution";
            this.Load += new System.EventHandler(this.FormConstrainedDistributionSolution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.FlowLayoutPanel Fpnl1;
        private System.Windows.Forms.Label LblDistributionCount;
        private System.Windows.Forms.Label LblDistribution;
        private System.Windows.Forms.FlowLayoutPanel Fpnl2;
        private System.Windows.Forms.Button BtnVisualisation;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Label LblDistributionCounter;
        private System.Windows.Forms.Label LblSolution;
        private System.Windows.Forms.Label LblDristributionDetails;
    }
}