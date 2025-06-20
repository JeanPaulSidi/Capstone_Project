﻿namespace Capstone_Milestone1.Forms
{
    partial class FormAnalysis2
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
            this.LblSteps = new System.Windows.Forms.Label();
            this.BtnNextStep = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnGoToSetup = new System.Windows.Forms.Button();
            this.BtnGoHome = new System.Windows.Forms.Button();
            this.Fpnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Fpnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnGoToSolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(277, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(0, 36);
            this.LblTitle.TabIndex = 0;
            // 
            // LblSteps
            // 
            this.LblSteps.AutoSize = true;
            this.LblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSteps.Location = new System.Drawing.Point(164, 651);
            this.LblSteps.Name = "LblSteps";
            this.LblSteps.Size = new System.Drawing.Size(0, 36);
            this.LblSteps.TabIndex = 3;
            // 
            // BtnNextStep
            // 
            this.BtnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextStep.Location = new System.Drawing.Point(576, 898);
            this.BtnNextStep.Name = "BtnNextStep";
            this.BtnNextStep.Size = new System.Drawing.Size(155, 55);
            this.BtnNextStep.TabIndex = 4;
            this.BtnNextStep.Text = "Next Step";
            this.BtnNextStep.UseVisualStyleBackColor = true;
            this.BtnNextStep.Click += new System.EventHandler(this.BtnNextStep_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(816, 907);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(159, 45);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnGoToSetup
            // 
            this.BtnGoToSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoToSetup.Location = new System.Drawing.Point(330, 898);
            this.BtnGoToSetup.Name = "BtnGoToSetup";
            this.BtnGoToSetup.Size = new System.Drawing.Size(129, 52);
            this.BtnGoToSetup.TabIndex = 6;
            this.BtnGoToSetup.Text = "Setup";
            this.BtnGoToSetup.UseVisualStyleBackColor = true;
            this.BtnGoToSetup.Click += new System.EventHandler(this.BtnGoToSetup_Click);
            // 
            // BtnGoHome
            // 
            this.BtnGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoHome.Location = new System.Drawing.Point(95, 898);
            this.BtnGoHome.Name = "BtnGoHome";
            this.BtnGoHome.Size = new System.Drawing.Size(104, 53);
            this.BtnGoHome.TabIndex = 7;
            this.BtnGoHome.Text = "Home";
            this.BtnGoHome.UseVisualStyleBackColor = true;
            this.BtnGoHome.Click += new System.EventHandler(this.BtnGoHome_Click);
            // 
            // Fpnl1
            // 
            this.Fpnl1.AutoSize = true;
            this.Fpnl1.Location = new System.Drawing.Point(13, 80);
            this.Fpnl1.Name = "Fpnl1";
            this.Fpnl1.Size = new System.Drawing.Size(1000, 200);
            this.Fpnl1.TabIndex = 9;
            // 
            // Fpnl2
            // 
            this.Fpnl2.AutoSize = true;
            this.Fpnl2.Location = new System.Drawing.Point(13, 312);
            this.Fpnl2.Name = "Fpnl2";
            this.Fpnl2.Size = new System.Drawing.Size(1000, 200);
            this.Fpnl2.TabIndex = 10;
            // 
            // BtnGoToSolution
            // 
            this.BtnGoToSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoToSolution.Location = new System.Drawing.Point(816, 885);
            this.BtnGoToSolution.Name = "BtnGoToSolution";
            this.BtnGoToSolution.Size = new System.Drawing.Size(209, 66);
            this.BtnGoToSolution.TabIndex = 11;
            this.BtnGoToSolution.Text = "Go To Solution";
            this.BtnGoToSolution.UseVisualStyleBackColor = true;
            this.BtnGoToSolution.Click += new System.EventHandler(this.BtnGoToSolution_Click);
            // 
            // FormAnalysis2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 1038);
            this.Controls.Add(this.BtnGoToSolution);
            this.Controls.Add(this.Fpnl2);
            this.Controls.Add(this.Fpnl1);
            this.Controls.Add(this.BtnGoHome);
            this.Controls.Add(this.BtnGoToSetup);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnNextStep);
            this.Controls.Add(this.LblSteps);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnalysis2";
            this.Text = "FormAnalysis2";
            this.Load += new System.EventHandler(this.FormAnalysis2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSteps;
        private System.Windows.Forms.Button BtnNextStep;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnGoToSetup;
        private System.Windows.Forms.Button BtnGoHome;
        private System.Windows.Forms.FlowLayoutPanel Fpnl1;
        private System.Windows.Forms.FlowLayoutPanel Fpnl2;
        private System.Windows.Forms.Button BtnGoToSolution;
    }
}