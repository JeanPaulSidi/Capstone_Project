namespace Capstone_Milestone1.Forms
{
    partial class FormIntroduction
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
            this.LblObjectCount = new System.Windows.Forms.Label();
            this.LblDrawerCount = new System.Windows.Forms.Label();
            this.CboObjectCount = new System.Windows.Forms.ComboBox();
            this.CboDrawerCount = new System.Windows.Forms.ComboBox();
            this.BtnClickToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblObjectCount
            // 
            this.LblObjectCount.AutoSize = true;
            this.LblObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObjectCount.Location = new System.Drawing.Point(45, 95);
            this.LblObjectCount.Name = "LblObjectCount";
            this.LblObjectCount.Size = new System.Drawing.Size(133, 25);
            this.LblObjectCount.TabIndex = 0;
            this.LblObjectCount.Text = "Object Count:";
            // 
            // LblDrawerCount
            // 
            this.LblDrawerCount.AutoSize = true;
            this.LblDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawerCount.Location = new System.Drawing.Point(129, 215);
            this.LblDrawerCount.Name = "LblDrawerCount";
            this.LblDrawerCount.Size = new System.Drawing.Size(138, 25);
            this.LblDrawerCount.TabIndex = 1;
            this.LblDrawerCount.Text = "Drawer Count:";
            // 
            // CboObjectCount
            // 
            this.CboObjectCount.FormattingEnabled = true;
            this.CboObjectCount.Location = new System.Drawing.Point(190, 95);
            this.CboObjectCount.Name = "CboObjectCount";
            this.CboObjectCount.Size = new System.Drawing.Size(77, 28);
            this.CboObjectCount.TabIndex = 2;
            this.CboObjectCount.SelectedIndexChanged += new System.EventHandler(this.CboObjectCount_SelectedIndexChanged);
            // 
            // CboDrawerCount
            // 
            this.CboDrawerCount.FormattingEnabled = true;
            this.CboDrawerCount.Location = new System.Drawing.Point(273, 215);
            this.CboDrawerCount.Name = "CboDrawerCount";
            this.CboDrawerCount.Size = new System.Drawing.Size(70, 28);
            this.CboDrawerCount.TabIndex = 3;
            this.CboDrawerCount.SelectedIndexChanged += new System.EventHandler(this.CboDrawerCount_SelectedIndexChanged);
            // 
            // BtnClickToStart
            // 
            this.BtnClickToStart.Location = new System.Drawing.Point(264, 336);
            this.BtnClickToStart.Name = "BtnClickToStart";
            this.BtnClickToStart.Size = new System.Drawing.Size(215, 51);
            this.BtnClickToStart.TabIndex = 4;
            this.BtnClickToStart.Text = "Click To Start";
            this.BtnClickToStart.UseVisualStyleBackColor = true;
            this.BtnClickToStart.Click += new System.EventHandler(this.BtnClickToStart_Click);
            // 
            // FormIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClickToStart);
            this.Controls.Add(this.CboDrawerCount);
            this.Controls.Add(this.CboObjectCount);
            this.Controls.Add(this.LblDrawerCount);
            this.Controls.Add(this.LblObjectCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIntroduction";
            this.Text = "FormIntroduction";
            this.Load += new System.EventHandler(this.FormIntroduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblObjectCount;
        private System.Windows.Forms.Label LblDrawerCount;
        private System.Windows.Forms.ComboBox CboObjectCount;
        private System.Windows.Forms.ComboBox CboDrawerCount;
        private System.Windows.Forms.Button BtnClickToStart;
    }
}