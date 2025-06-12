namespace Capstone_Milestone1.Forms
{
    partial class FormConstrainedDistributionAnalysis
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
            this.BtnGoToSolution = new System.Windows.Forms.Button();
            this.BtnNextStep = new System.Windows.Forms.Button();
            this.LblSteps = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnGoToSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(142, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(51, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "label1";
            // 
            // Fpnl
            // 
            this.Fpnl.AutoScroll = true;
            this.Fpnl.Location = new System.Drawing.Point(4, 106);
            this.Fpnl.Name = "Fpnl";
            this.Fpnl.Size = new System.Drawing.Size(1150, 230);
            this.Fpnl.TabIndex = 2;
            // 
            // BtnGoToSolution
            // 
            this.BtnGoToSolution.Location = new System.Drawing.Point(771, 609);
            this.BtnGoToSolution.Name = "BtnGoToSolution";
            this.BtnGoToSolution.Size = new System.Drawing.Size(143, 44);
            this.BtnGoToSolution.TabIndex = 4;
            this.BtnGoToSolution.Text = "Go To Solution";
            this.BtnGoToSolution.UseVisualStyleBackColor = true;
            this.BtnGoToSolution.Click += new System.EventHandler(this.BtnGoToSolution_Click);
            // 
            // BtnNextStep
            // 
            this.BtnNextStep.Location = new System.Drawing.Point(453, 609);
            this.BtnNextStep.Name = "BtnNextStep";
            this.BtnNextStep.Size = new System.Drawing.Size(135, 44);
            this.BtnNextStep.TabIndex = 5;
            this.BtnNextStep.Text = "Next Step";
            this.BtnNextStep.UseVisualStyleBackColor = true;
            this.BtnNextStep.Click += new System.EventHandler(this.BtnNextStep_Click);
            // 
            // LblSteps
            // 
            this.LblSteps.AutoSize = true;
            this.LblSteps.Location = new System.Drawing.Point(146, 385);
            this.LblSteps.Name = "LblSteps";
            this.LblSteps.Size = new System.Drawing.Size(0, 20);
            this.LblSteps.TabIndex = 7;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(771, 609);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(143, 44);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnGoToSetup
            // 
            this.BtnGoToSetup.Location = new System.Drawing.Point(160, 609);
            this.BtnGoToSetup.Name = "BtnGoToSetup";
            this.BtnGoToSetup.Size = new System.Drawing.Size(117, 54);
            this.BtnGoToSetup.TabIndex = 9;
            this.BtnGoToSetup.Text = "Go To Setup";
            this.BtnGoToSetup.UseVisualStyleBackColor = true;
            this.BtnGoToSetup.Click += new System.EventHandler(this.BtnGoToSetup_Click);
            // 
            // FormConstrainedDistributionAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 822);
            this.Controls.Add(this.BtnGoToSetup);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LblSteps);
            this.Controls.Add(this.BtnNextStep);
            this.Controls.Add(this.BtnGoToSolution);
            this.Controls.Add(this.Fpnl);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConstrainedDistributionAnalysis";
            this.Text = "FormConstrainedDistributionAnalysis";
            this.Load += new System.EventHandler(this.FormConstrainedDistributionAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.FlowLayoutPanel Fpnl;
        private System.Windows.Forms.Button BtnGoToSolution;
        private System.Windows.Forms.Button BtnNextStep;
        private System.Windows.Forms.Label LblSteps;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnGoToSetup;
    }
}