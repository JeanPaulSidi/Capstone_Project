namespace Capstone_Milestone1.Forms
{
    partial class FormUnConstrainedDistributionSolution
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
            this.LblSolution = new System.Windows.Forms.Label();
            this.Fpnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblDistributionCounter = new System.Windows.Forms.Label();
            this.LblDistributionCount = new System.Windows.Forms.Label();
            this.LblDistribution = new System.Windows.Forms.Label();
            this.LblDistributionDetails = new System.Windows.Forms.Label();
            this.Fpnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnVisualisation = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(160, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(71, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Solution:";
            // 
            // LblSolution
            // 
            this.LblSolution.AutoSize = true;
            this.LblSolution.Location = new System.Drawing.Point(238, 22);
            this.LblSolution.Name = "LblSolution";
            this.LblSolution.Size = new System.Drawing.Size(0, 20);
            this.LblSolution.TabIndex = 1;
            // 
            // Fpnl1
            // 
            this.Fpnl1.AutoSize = true;
            this.Fpnl1.Location = new System.Drawing.Point(13, 86);
            this.Fpnl1.Name = "Fpnl1";
            this.Fpnl1.Size = new System.Drawing.Size(1150, 230);
            this.Fpnl1.TabIndex = 2;
            // 
            // LblDistributionCounter
            // 
            this.LblDistributionCounter.AutoSize = true;
            this.LblDistributionCounter.Location = new System.Drawing.Point(93, 376);
            this.LblDistributionCounter.Name = "LblDistributionCounter";
            this.LblDistributionCounter.Size = new System.Drawing.Size(140, 20);
            this.LblDistributionCounter.TabIndex = 3;
            this.LblDistributionCounter.Text = "Distribution Count:";
            // 
            // LblDistributionCount
            // 
            this.LblDistributionCount.AutoSize = true;
            this.LblDistributionCount.Location = new System.Drawing.Point(242, 375);
            this.LblDistributionCount.Name = "LblDistributionCount";
            this.LblDistributionCount.Size = new System.Drawing.Size(0, 20);
            this.LblDistributionCount.TabIndex = 4;
            // 
            // LblDistribution
            // 
            this.LblDistribution.AutoSize = true;
            this.LblDistribution.Location = new System.Drawing.Point(97, 437);
            this.LblDistribution.Name = "LblDistribution";
            this.LblDistribution.Size = new System.Drawing.Size(93, 20);
            this.LblDistribution.TabIndex = 5;
            this.LblDistribution.Text = "Distribution:";
            // 
            // LblDistributionDetails
            // 
            this.LblDistributionDetails.AutoSize = true;
            this.LblDistributionDetails.Location = new System.Drawing.Point(246, 436);
            this.LblDistributionDetails.Name = "LblDistributionDetails";
            this.LblDistributionDetails.Size = new System.Drawing.Size(0, 20);
            this.LblDistributionDetails.TabIndex = 6;
            // 
            // Fpnl2
            // 
            this.Fpnl2.AutoSize = true;
            this.Fpnl2.Location = new System.Drawing.Point(13, 557);
            this.Fpnl2.Name = "Fpnl2";
            this.Fpnl2.Size = new System.Drawing.Size(1150, 230);
            this.Fpnl2.TabIndex = 7;
            // 
            // BtnVisualisation
            // 
            this.BtnVisualisation.Location = new System.Drawing.Point(518, 917);
            this.BtnVisualisation.Name = "BtnVisualisation";
            this.BtnVisualisation.Size = new System.Drawing.Size(147, 47);
            this.BtnVisualisation.TabIndex = 8;
            this.BtnVisualisation.Text = "Click to visualize";
            this.BtnVisualisation.UseVisualStyleBackColor = true;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(171, 917);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(123, 47);
            this.BtnPrevious.TabIndex = 9;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(872, 917);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(125, 47);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // FormUnConstrainedDistributionSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 1009);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnVisualisation);
            this.Controls.Add(this.Fpnl2);
            this.Controls.Add(this.LblDistributionDetails);
            this.Controls.Add(this.LblDistribution);
            this.Controls.Add(this.LblDistributionCount);
            this.Controls.Add(this.LblDistributionCounter);
            this.Controls.Add(this.Fpnl1);
            this.Controls.Add(this.LblSolution);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnConstrainedDistributionSolution";
            this.Text = "FormUnConstrainedDistributionSolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSolution;
        private System.Windows.Forms.FlowLayoutPanel Fpnl1;
        private System.Windows.Forms.Label LblDistributionCounter;
        private System.Windows.Forms.Label LblDistributionCount;
        private System.Windows.Forms.Label LblDistribution;
        private System.Windows.Forms.Label LblDistributionDetails;
        private System.Windows.Forms.FlowLayoutPanel Fpnl2;
        private System.Windows.Forms.Button BtnVisualisation;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
    }
}