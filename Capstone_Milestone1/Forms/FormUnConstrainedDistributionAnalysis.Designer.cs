namespace Capstone_Milestone1.Forms
{
    partial class FormUnConstrainedDistributionAnalysis
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
            this.Fpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.LblSteps = new System.Windows.Forms.Label();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNextStep = new System.Windows.Forms.Button();
            this.BtnGoToSolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(142, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(0, 20);
            this.LblTitle.TabIndex = 0;
            // 
            // Fpnl
            // 
            this.Fpnl.AutoSize = true;
            this.Fpnl.Location = new System.Drawing.Point(13, 82);
            this.Fpnl.Name = "Fpnl";
            this.Fpnl.Size = new System.Drawing.Size(1150, 230);
            this.Fpnl.TabIndex = 1;
            // 
            // LblSteps
            // 
            this.LblSteps.AutoSize = true;
            this.LblSteps.Location = new System.Drawing.Point(215, 356);
            this.LblSteps.Name = "LblSteps";
            this.LblSteps.Size = new System.Drawing.Size(0, 20);
            this.LblSteps.TabIndex = 2;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(163, 621);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(139, 55);
            this.BtnPrevious.TabIndex = 3;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnNextStep
            // 
            this.BtnNextStep.Location = new System.Drawing.Point(531, 625);
            this.BtnNextStep.Name = "BtnNextStep";
            this.BtnNextStep.Size = new System.Drawing.Size(153, 51);
            this.BtnNextStep.TabIndex = 4;
            this.BtnNextStep.Text = "Next Step";
            this.BtnNextStep.UseVisualStyleBackColor = true;
            this.BtnNextStep.Click += new System.EventHandler(this.BtnNextStep_Click);
            // 
            // BtnGoToSolution
            // 
            this.BtnGoToSolution.Location = new System.Drawing.Point(883, 625);
            this.BtnGoToSolution.Name = "BtnGoToSolution";
            this.BtnGoToSolution.Size = new System.Drawing.Size(177, 51);
            this.BtnGoToSolution.TabIndex = 5;
            this.BtnGoToSolution.Text = "Go To Solution";
            this.BtnGoToSolution.UseVisualStyleBackColor = true;
            this.BtnGoToSolution.Click += new System.EventHandler(this.BtnGoToSolution_Click);
            // 
            // FormUnConstrainedDistributionAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 700);
            this.Controls.Add(this.BtnGoToSolution);
            this.Controls.Add(this.BtnNextStep);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.LblSteps);
            this.Controls.Add(this.Fpnl);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnConstrainedDistributionAnalysis";
            this.Text = "FormUnConstrainedDistributionAnalysis";
            this.Load += new System.EventHandler(this.FormUnConstrainedDistributionAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.FlowLayoutPanel Fpnl;
        private System.Windows.Forms.Label LblSteps;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNextStep;
        private System.Windows.Forms.Button BtnGoToSolution;
    }
}