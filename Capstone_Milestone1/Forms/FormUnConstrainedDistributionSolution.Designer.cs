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
            this.LblDistributionCounter = new System.Windows.Forms.Label();
            this.LblDistributionCount = new System.Windows.Forms.Label();
            this.LblDistribution = new System.Windows.Forms.Label();
            this.LblDistributionDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(125, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(51, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "label1";
            // 
            // LblSolution
            // 
            this.LblSolution.AutoSize = true;
            this.LblSolution.Location = new System.Drawing.Point(191, 13);
            this.LblSolution.Name = "LblSolution";
            this.LblSolution.Size = new System.Drawing.Size(51, 20);
            this.LblSolution.TabIndex = 1;
            this.LblSolution.Text = "label1";
            // 
            // LblDistributionCounter
            // 
            this.LblDistributionCounter.AutoSize = true;
            this.LblDistributionCounter.Location = new System.Drawing.Point(58, 528);
            this.LblDistributionCounter.Name = "LblDistributionCounter";
            this.LblDistributionCounter.Size = new System.Drawing.Size(137, 20);
            this.LblDistributionCounter.TabIndex = 2;
            this.LblDistributionCounter.Text = "Distribution count:";
            // 
            // LblDistributionCount
            // 
            this.LblDistributionCount.AutoSize = true;
            this.LblDistributionCount.Location = new System.Drawing.Point(214, 528);
            this.LblDistributionCount.Name = "LblDistributionCount";
            this.LblDistributionCount.Size = new System.Drawing.Size(51, 20);
            this.LblDistributionCount.TabIndex = 3;
            this.LblDistributionCount.Text = "label1";
            // 
            // LblDistribution
            // 
            this.LblDistribution.AutoSize = true;
            this.LblDistribution.Location = new System.Drawing.Point(58, 601);
            this.LblDistribution.Name = "LblDistribution";
            this.LblDistribution.Size = new System.Drawing.Size(93, 20);
            this.LblDistribution.TabIndex = 4;
            this.LblDistribution.Text = "Distribution:";
            // 
            // LblDistributionDetails
            // 
            this.LblDistributionDetails.AutoSize = true;
            this.LblDistributionDetails.Location = new System.Drawing.Point(180, 601);
            this.LblDistributionDetails.Name = "LblDistributionDetails";
            this.LblDistributionDetails.Size = new System.Drawing.Size(51, 20);
            this.LblDistributionDetails.TabIndex = 5;
            this.LblDistributionDetails.Text = "label1";
            // 
            // FormUnConstrainedDistributionSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 712);
            this.Controls.Add(this.LblDistributionDetails);
            this.Controls.Add(this.LblDistribution);
            this.Controls.Add(this.LblDistributionCount);
            this.Controls.Add(this.LblDistributionCounter);
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
        private System.Windows.Forms.Label LblDistributionCounter;
        private System.Windows.Forms.Label LblDistributionCount;
        private System.Windows.Forms.Label LblDistribution;
        private System.Windows.Forms.Label LblDistributionDetails;
    }
}