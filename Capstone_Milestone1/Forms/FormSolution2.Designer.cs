namespace Capstone_Milestone1.Forms
{
    partial class FormSolution2
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
            this.BtnClickToVisualize = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnSetup = new System.Windows.Forms.Button();
            this.LblDistribution = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(224, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(71, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Solution:";
            // 
            // LblSolution
            // 
            this.LblSolution.AutoSize = true;
            this.LblSolution.Location = new System.Drawing.Point(310, 23);
            this.LblSolution.Name = "LblSolution";
            this.LblSolution.Size = new System.Drawing.Size(0, 20);
            this.LblSolution.TabIndex = 1;
            // 
            // BtnClickToVisualize
            // 
            this.BtnClickToVisualize.Location = new System.Drawing.Point(589, 940);
            this.BtnClickToVisualize.Name = "BtnClickToVisualize";
            this.BtnClickToVisualize.Size = new System.Drawing.Size(169, 45);
            this.BtnClickToVisualize.TabIndex = 2;
            this.BtnClickToVisualize.Text = "Click To Visualize";
            this.BtnClickToVisualize.UseVisualStyleBackColor = true;
            this.BtnClickToVisualize.Click += new System.EventHandler(this.BtnClickToVisualize_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(1009, 940);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(140, 45);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(332, 935);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(126, 45);
            this.BtnPrevious.TabIndex = 4;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnSetup
            // 
            this.BtnSetup.Location = new System.Drawing.Point(105, 935);
            this.BtnSetup.Name = "BtnSetup";
            this.BtnSetup.Size = new System.Drawing.Size(118, 55);
            this.BtnSetup.TabIndex = 5;
            this.BtnSetup.Text = "Setup";
            this.BtnSetup.UseVisualStyleBackColor = true;
            this.BtnSetup.Click += new System.EventHandler(this.BtnSetup_Click);
            // 
            // LblDistribution
            // 
            this.LblDistribution.AutoSize = true;
            this.LblDistribution.Location = new System.Drawing.Point(517, 863);
            this.LblDistribution.Name = "LblDistribution";
            this.LblDistribution.Size = new System.Drawing.Size(154, 20);
            this.LblDistribution.TabIndex = 6;
            this.LblDistribution.Text = "Distribution Counter:";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(677, 863);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 20);
            this.lblCounter.TabIndex = 7;
            // 
            // FormSolution2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 1053);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.LblDistribution);
            this.Controls.Add(this.BtnSetup);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnClickToVisualize);
            this.Controls.Add(this.LblSolution);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSolution2";
            this.Text = "FormSolution2";
            this.Load += new System.EventHandler(this.FormSolution2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSolution;
        private System.Windows.Forms.Button BtnClickToVisualize;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnSetup;
        private System.Windows.Forms.Label LblDistribution;
        private System.Windows.Forms.Label lblCounter;
    }
}