﻿namespace Capstone_Milestone1.Forms
{
    partial class FormHome
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
            this.LblInDistinguishable = new System.Windows.Forms.Label();
            this.LblDistinguishable = new System.Windows.Forms.Label();
            this.BtnSelectIndistinguishable = new System.Windows.Forms.Button();
            this.BtnSelectDistinguishable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(337, 47);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(103, 36);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "HOME";
            // 
            // LblInDistinguishable
            // 
            this.LblInDistinguishable.AutoSize = true;
            this.LblInDistinguishable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInDistinguishable.Location = new System.Drawing.Point(197, 303);
            this.LblInDistinguishable.Name = "LblInDistinguishable";
            this.LblInDistinguishable.Size = new System.Drawing.Size(451, 36);
            this.LblInDistinguishable.TabIndex = 1;
            this.LblInDistinguishable.Text = "The objects are indistinguishable";
            // 
            // LblDistinguishable
            // 
            this.LblDistinguishable.AutoSize = true;
            this.LblDistinguishable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistinguishable.Location = new System.Drawing.Point(59, 450);
            this.LblDistinguishable.Name = "LblDistinguishable";
            this.LblDistinguishable.Size = new System.Drawing.Size(427, 36);
            this.LblDistinguishable.TabIndex = 2;
            this.LblDistinguishable.Text = "The objects are distinguishable";
            // 
            // BtnSelectIndistinguishable
            // 
            this.BtnSelectIndistinguishable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectIndistinguishable.Location = new System.Drawing.Point(666, 290);
            this.BtnSelectIndistinguishable.Name = "BtnSelectIndistinguishable";
            this.BtnSelectIndistinguishable.Size = new System.Drawing.Size(156, 49);
            this.BtnSelectIndistinguishable.TabIndex = 3;
            this.BtnSelectIndistinguishable.Text = "Select";
            this.BtnSelectIndistinguishable.UseVisualStyleBackColor = true;
            this.BtnSelectIndistinguishable.Click += new System.EventHandler(this.BtnSelectIndistinguishable_Click);
            // 
            // BtnSelectDistinguishable
            // 
            this.BtnSelectDistinguishable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectDistinguishable.Location = new System.Drawing.Point(498, 445);
            this.BtnSelectDistinguishable.Name = "BtnSelectDistinguishable";
            this.BtnSelectDistinguishable.Size = new System.Drawing.Size(150, 51);
            this.BtnSelectDistinguishable.TabIndex = 4;
            this.BtnSelectDistinguishable.Text = "Select";
            this.BtnSelectDistinguishable.UseVisualStyleBackColor = true;
            this.BtnSelectDistinguishable.Click += new System.EventHandler(this.BtnSelectDistinguishable_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 563);
            this.Controls.Add(this.BtnSelectDistinguishable);
            this.Controls.Add(this.BtnSelectIndistinguishable);
            this.Controls.Add(this.LblDistinguishable);
            this.Controls.Add(this.LblInDistinguishable);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblInDistinguishable;
        private System.Windows.Forms.Label LblDistinguishable;
        private System.Windows.Forms.Button BtnSelectIndistinguishable;
        private System.Windows.Forms.Button BtnSelectDistinguishable;
    }
}