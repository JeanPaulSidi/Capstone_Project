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
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblSetup = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnGoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblObjectCount
            // 
            this.LblObjectCount.AutoSize = true;
            this.LblObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObjectCount.Location = new System.Drawing.Point(269, 200);
            this.LblObjectCount.Name = "LblObjectCount";
            this.LblObjectCount.Size = new System.Drawing.Size(133, 25);
            this.LblObjectCount.TabIndex = 0;
            this.LblObjectCount.Text = "Object Count:";
            // 
            // LblDrawerCount
            // 
            this.LblDrawerCount.AutoSize = true;
            this.LblDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawerCount.Location = new System.Drawing.Point(445, 319);
            this.LblDrawerCount.Name = "LblDrawerCount";
            this.LblDrawerCount.Size = new System.Drawing.Size(138, 25);
            this.LblDrawerCount.TabIndex = 1;
            this.LblDrawerCount.Text = "Drawer Count:";
            // 
            // CboObjectCount
            // 
            this.CboObjectCount.FormattingEnabled = true;
            this.CboObjectCount.Location = new System.Drawing.Point(420, 197);
            this.CboObjectCount.Name = "CboObjectCount";
            this.CboObjectCount.Size = new System.Drawing.Size(77, 28);
            this.CboObjectCount.TabIndex = 2;
            this.CboObjectCount.SelectedIndexChanged += new System.EventHandler(this.CboObjectCount_SelectedIndexChanged);
            // 
            // CboDrawerCount
            // 
            this.CboDrawerCount.FormattingEnabled = true;
            this.CboDrawerCount.Location = new System.Drawing.Point(608, 319);
            this.CboDrawerCount.Name = "CboDrawerCount";
            this.CboDrawerCount.Size = new System.Drawing.Size(70, 28);
            this.CboDrawerCount.TabIndex = 3;
            this.CboDrawerCount.SelectedIndexChanged += new System.EventHandler(this.CboDrawerCount_SelectedIndexChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(476, 520);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(215, 51);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblSetup
            // 
            this.LblSetup.AutoSize = true;
            this.LblSetup.Location = new System.Drawing.Point(435, 31);
            this.LblSetup.Name = "LblSetup";
            this.LblSetup.Size = new System.Drawing.Size(62, 20);
            this.LblSetup.TabIndex = 5;
            this.LblSetup.Text = "SETUP";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(476, 463);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(215, 51);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(852, 520);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(168, 51);
            this.BtnNext.TabIndex = 7;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnGoHome
            // 
            this.BtnGoHome.Location = new System.Drawing.Point(153, 520);
            this.BtnGoHome.Name = "BtnGoHome";
            this.BtnGoHome.Size = new System.Drawing.Size(170, 51);
            this.BtnGoHome.TabIndex = 8;
            this.BtnGoHome.Text = "Home";
            this.BtnGoHome.UseVisualStyleBackColor = true;
            this.BtnGoHome.Click += new System.EventHandler(this.BtnGoHome_Click);
            // 
            // FormIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 635);
            this.Controls.Add(this.BtnGoHome);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblSetup);
            this.Controls.Add(this.BtnStart);
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
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblSetup;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnGoHome;
    }
}