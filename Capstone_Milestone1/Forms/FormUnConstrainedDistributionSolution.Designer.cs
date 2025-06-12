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
            this.BtnVisualisation = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(125, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(71, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Solution:";
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
            this.LblDistributionCount.Size = new System.Drawing.Size(0, 20);
            this.LblDistributionCount.TabIndex = 3;
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
            this.LblDistributionDetails.Size = new System.Drawing.Size(0, 20);
            this.LblDistributionDetails.TabIndex = 5;
            // 
            // BtnVisualisation
            // 
            this.BtnVisualisation.Location = new System.Drawing.Point(729, 879);
            this.BtnVisualisation.Name = "BtnVisualisation";
            this.BtnVisualisation.Size = new System.Drawing.Size(145, 50);
            this.BtnVisualisation.TabIndex = 6;
            this.BtnVisualisation.Text = "Click to Visualize";
            this.BtnVisualisation.UseVisualStyleBackColor = true;
            this.BtnVisualisation.Click += new System.EventHandler(this.BtnVisualisation_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(476, 879);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(112, 50);
            this.BtnPrevious.TabIndex = 7;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(1037, 879);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(103, 50);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 668);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // FormUnConstrainedDistributionSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 966);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnVisualisation);
            this.Controls.Add(this.LblDistributionDetails);
            this.Controls.Add(this.LblDistribution);
            this.Controls.Add(this.LblDistributionCount);
            this.Controls.Add(this.LblDistributionCounter);
            this.Controls.Add(this.LblSolution);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnConstrainedDistributionSolution";
            this.Text = "FormUnConstrainedDistributionSolution";
            this.Load += new System.EventHandler(this.FormUnConstrainedDistributionSolution_Load);
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
        private System.Windows.Forms.Button BtnVisualisation;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}