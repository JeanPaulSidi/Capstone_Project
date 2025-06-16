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
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnGoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblObjectCount
            // 
            this.LblObjectCount.AutoSize = true;
            this.LblObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObjectCount.Location = new System.Drawing.Point(269, 200);
            this.LblObjectCount.Name = "LblObjectCount";
            this.LblObjectCount.Size = new System.Drawing.Size(196, 36);
            this.LblObjectCount.TabIndex = 0;
            this.LblObjectCount.Text = "Object Count:";
            // 
            // LblDrawerCount
            // 
            this.LblDrawerCount.AutoSize = true;
            this.LblDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawerCount.Location = new System.Drawing.Point(445, 319);
            this.LblDrawerCount.Name = "LblDrawerCount";
            this.LblDrawerCount.Size = new System.Drawing.Size(206, 36);
            this.LblDrawerCount.TabIndex = 1;
            this.LblDrawerCount.Text = "Drawer Count:";
            // 
            // CboObjectCount
            // 
            this.CboObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboObjectCount.FormattingEnabled = true;
            this.CboObjectCount.Location = new System.Drawing.Point(471, 200);
            this.CboObjectCount.Name = "CboObjectCount";
            this.CboObjectCount.Size = new System.Drawing.Size(77, 38);
            this.CboObjectCount.TabIndex = 2;
            this.CboObjectCount.SelectedIndexChanged += new System.EventHandler(this.CboObjectCount_SelectedIndexChanged);
            // 
            // CboDrawerCount
            // 
            this.CboDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDrawerCount.FormattingEnabled = true;
            this.CboDrawerCount.Location = new System.Drawing.Point(657, 317);
            this.CboDrawerCount.Name = "CboDrawerCount";
            this.CboDrawerCount.Size = new System.Drawing.Size(70, 38);
            this.CboDrawerCount.TabIndex = 3;
            this.CboDrawerCount.SelectedIndexChanged += new System.EventHandler(this.CboDrawerCount_SelectedIndexChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(587, 520);
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
            this.LblSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetup.Location = new System.Drawing.Point(435, 31);
            this.LblSetup.Name = "LblSetup";
            this.LblSetup.Size = new System.Drawing.Size(115, 36);
            this.LblSetup.TabIndex = 5;
            this.LblSetup.Text = "SETUP";
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(930, 520);
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
            this.ClientSize = new System.Drawing.Size(1180, 635);
            this.Controls.Add(this.BtnGoHome);
            this.Controls.Add(this.BtnNext);
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
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnGoHome;
    }
}