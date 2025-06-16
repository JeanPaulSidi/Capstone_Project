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
            this.BtnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(113, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(133, 36);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Solution:";
            // 
            // LblSolution
            // 
            this.LblSolution.AutoSize = true;
            this.LblSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSolution.Location = new System.Drawing.Point(273, 26);
            this.LblSolution.Name = "LblSolution";
            this.LblSolution.Size = new System.Drawing.Size(0, 36);
            this.LblSolution.TabIndex = 1;
            // 
            // LblDistributionCounter
            // 
            this.LblDistributionCounter.AutoSize = true;
            this.LblDistributionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistributionCounter.Location = new System.Drawing.Point(37, 480);
            this.LblDistributionCounter.Name = "LblDistributionCounter";
            this.LblDistributionCounter.Size = new System.Drawing.Size(282, 36);
            this.LblDistributionCounter.TabIndex = 2;
            this.LblDistributionCounter.Text = "Distribution counter:";
            // 
            // LblDistributionCount
            // 
            this.LblDistributionCount.AutoSize = true;
            this.LblDistributionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistributionCount.Location = new System.Drawing.Point(346, 480);
            this.LblDistributionCount.Name = "LblDistributionCount";
            this.LblDistributionCount.Size = new System.Drawing.Size(0, 36);
            this.LblDistributionCount.TabIndex = 3;
            // 
            // LblDistribution
            // 
            this.LblDistribution.AutoSize = true;
            this.LblDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistribution.Location = new System.Drawing.Point(79, 546);
            this.LblDistribution.Name = "LblDistribution";
            this.LblDistribution.Size = new System.Drawing.Size(174, 36);
            this.LblDistribution.TabIndex = 4;
            this.LblDistribution.Text = "Distribution:";
            // 
            // LblDistributionDetails
            // 
            this.LblDistributionDetails.AutoSize = true;
            this.LblDistributionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistributionDetails.Location = new System.Drawing.Point(273, 546);
            this.LblDistributionDetails.Name = "LblDistributionDetails";
            this.LblDistributionDetails.Size = new System.Drawing.Size(0, 36);
            this.LblDistributionDetails.TabIndex = 5;
            // 
            // BtnVisualisation
            // 
            this.BtnVisualisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisualisation.Location = new System.Drawing.Point(564, 875);
            this.BtnVisualisation.Name = "BtnVisualisation";
            this.BtnVisualisation.Size = new System.Drawing.Size(281, 50);
            this.BtnVisualisation.TabIndex = 6;
            this.BtnVisualisation.Text = "Click to Visualize";
            this.BtnVisualisation.UseVisualStyleBackColor = true;
            this.BtnVisualisation.Click += new System.EventHandler(this.BtnVisualisation_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(326, 879);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(139, 50);
            this.BtnPrevious.TabIndex = 7;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(977, 875);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(119, 50);
            this.BtnHome.TabIndex = 8;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
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
            this.Controls.Add(this.BtnHome);
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
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}