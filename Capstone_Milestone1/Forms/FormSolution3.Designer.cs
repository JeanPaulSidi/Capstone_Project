namespace Capstone_Milestone1.Forms
{
    partial class FormSolution3
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
            this.BtnVisualize = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(288, 31);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(51, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "label1";
            // 
            // BtnVisualize
            // 
            this.BtnVisualize.Location = new System.Drawing.Point(553, 878);
            this.BtnVisualize.Name = "BtnVisualize";
            this.BtnVisualize.Size = new System.Drawing.Size(198, 74);
            this.BtnVisualize.TabIndex = 1;
            this.BtnVisualize.Text = "Click To Visualize";
            this.BtnVisualize.UseVisualStyleBackColor = true;
            this.BtnVisualize.Click += new System.EventHandler(this.BtnVisualize_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(186, 883);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(153, 69);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // FormSolution3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 997);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnVisualize);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSolution3";
            this.Text = "FormSolution3";
            this.Load += new System.EventHandler(this.FormSolution3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnVisualize;
        private System.Windows.Forms.Button BtnPrevious;
    }
}