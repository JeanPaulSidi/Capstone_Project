namespace Capstone_Milestone1.Forms
{
    partial class FormIntroduction2
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
            this.LblSetup = new System.Windows.Forms.Label();
            this.LblObjectCount = new System.Windows.Forms.Label();
            this.CboObjectCount = new System.Windows.Forms.ComboBox();
            this.LblDrawerCount = new System.Windows.Forms.Label();
            this.CboDrawerCount = new System.Windows.Forms.ComboBox();
            this.BtnGoHome = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSetup
            // 
            this.LblSetup.AutoSize = true;
            this.LblSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetup.Location = new System.Drawing.Point(508, 59);
            this.LblSetup.Name = "LblSetup";
            this.LblSetup.Size = new System.Drawing.Size(115, 36);
            this.LblSetup.TabIndex = 0;
            this.LblSetup.Text = "SETUP";
            // 
            // LblObjectCount
            // 
            this.LblObjectCount.AutoSize = true;
            this.LblObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObjectCount.Location = new System.Drawing.Point(246, 209);
            this.LblObjectCount.Name = "LblObjectCount";
            this.LblObjectCount.Size = new System.Drawing.Size(196, 36);
            this.LblObjectCount.TabIndex = 1;
            this.LblObjectCount.Text = "Object Count:";
            // 
            // CboObjectCount
            // 
            this.CboObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboObjectCount.FormattingEnabled = true;
            this.CboObjectCount.Location = new System.Drawing.Point(456, 207);
            this.CboObjectCount.Name = "CboObjectCount";
            this.CboObjectCount.Size = new System.Drawing.Size(84, 38);
            this.CboObjectCount.TabIndex = 2;
            this.CboObjectCount.SelectedIndexChanged += new System.EventHandler(this.CboObjectCount_SelectedIndexChanged);
            // 
            // LblDrawerCount
            // 
            this.LblDrawerCount.AutoSize = true;
            this.LblDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawerCount.Location = new System.Drawing.Point(379, 327);
            this.LblDrawerCount.Name = "LblDrawerCount";
            this.LblDrawerCount.Size = new System.Drawing.Size(206, 36);
            this.LblDrawerCount.TabIndex = 3;
            this.LblDrawerCount.Text = "Drawer Count:";
            // 
            // CboDrawerCount
            // 
            this.CboDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDrawerCount.FormattingEnabled = true;
            this.CboDrawerCount.Location = new System.Drawing.Point(606, 325);
            this.CboDrawerCount.Name = "CboDrawerCount";
            this.CboDrawerCount.Size = new System.Drawing.Size(86, 38);
            this.CboDrawerCount.TabIndex = 4;
            this.CboDrawerCount.SelectedIndexChanged += new System.EventHandler(this.CboDrawerCount_SelectedIndexChanged);
            // 
            // BtnGoHome
            // 
            this.BtnGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoHome.Location = new System.Drawing.Point(117, 550);
            this.BtnGoHome.Name = "BtnGoHome";
            this.BtnGoHome.Size = new System.Drawing.Size(137, 45);
            this.BtnGoHome.TabIndex = 5;
            this.BtnGoHome.Text = "Home";
            this.BtnGoHome.UseVisualStyleBackColor = true;
            this.BtnGoHome.Click += new System.EventHandler(this.BtnGoHome_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(901, 550);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(124, 45);
            this.BtnNext.TabIndex = 7;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(555, 550);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(164, 45);
            this.BtnStart.TabIndex = 8;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FormIntroduction2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 646);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnGoHome);
            this.Controls.Add(this.CboDrawerCount);
            this.Controls.Add(this.LblDrawerCount);
            this.Controls.Add(this.CboObjectCount);
            this.Controls.Add(this.LblObjectCount);
            this.Controls.Add(this.LblSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIntroduction2";
            this.Text = "FormIntroduction2";
            this.Load += new System.EventHandler(this.FormIntroduction2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSetup;
        private System.Windows.Forms.Label LblObjectCount;
        private System.Windows.Forms.ComboBox CboObjectCount;
        private System.Windows.Forms.Label LblDrawerCount;
        private System.Windows.Forms.ComboBox CboDrawerCount;
        private System.Windows.Forms.Button BtnGoHome;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnStart;
    }
}