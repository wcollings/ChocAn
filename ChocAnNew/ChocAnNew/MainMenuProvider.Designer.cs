namespace ChocAnNew
{
    partial class MainMenuProvider
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
            this.valMemBtn = new System.Windows.Forms.Button();
            this.chocAnMMAdminLbl = new System.Windows.Forms.Label();
            this.rptServBtn = new System.Windows.Forms.Button();
            this.accProDirBtn = new System.Windows.Forms.Button();
            this.genProRptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valMemBtn
            // 
            this.valMemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valMemBtn.Location = new System.Drawing.Point(87, 77);
            this.valMemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valMemBtn.Name = "valMemBtn";
            this.valMemBtn.Size = new System.Drawing.Size(374, 60);
            this.valMemBtn.TabIndex = 0;
            this.valMemBtn.Text = "Validate Member";
            this.valMemBtn.UseVisualStyleBackColor = true;
            this.valMemBtn.Click += new System.EventHandler(this.valMemBtn_Click);
            // 
            // chocAnMMAdminLbl
            // 
            this.chocAnMMAdminLbl.AutoSize = true;
            this.chocAnMMAdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocAnMMAdminLbl.Location = new System.Drawing.Point(58, 14);
            this.chocAnMMAdminLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chocAnMMAdminLbl.Name = "chocAnMMAdminLbl";
            this.chocAnMMAdminLbl.Size = new System.Drawing.Size(425, 37);
            this.chocAnMMAdminLbl.TabIndex = 1;
            this.chocAnMMAdminLbl.Text = "Main Menu ChocAn Provider";
            // 
            // rptServBtn
            // 
            this.rptServBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptServBtn.Location = new System.Drawing.Point(87, 146);
            this.rptServBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rptServBtn.Name = "rptServBtn";
            this.rptServBtn.Size = new System.Drawing.Size(374, 60);
            this.rptServBtn.TabIndex = 2;
            this.rptServBtn.Text = "Report Services";
            this.rptServBtn.UseVisualStyleBackColor = true;
            this.rptServBtn.Click += new System.EventHandler(this.rptServBtn_Click);
            // 
            // accProDirBtn
            // 
            this.accProDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accProDirBtn.Location = new System.Drawing.Point(87, 215);
            this.accProDirBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accProDirBtn.Name = "accProDirBtn";
            this.accProDirBtn.Size = new System.Drawing.Size(374, 60);
            this.accProDirBtn.TabIndex = 3;
            this.accProDirBtn.Text = "Access Provider Directory";
            this.accProDirBtn.UseVisualStyleBackColor = true;
            this.accProDirBtn.Click += new System.EventHandler(this.accProDirBtn_Click);
            // 
            // genProRptBtn
            // 
            this.genProRptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genProRptBtn.Location = new System.Drawing.Point(87, 285);
            this.genProRptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genProRptBtn.Name = "genProRptBtn";
            this.genProRptBtn.Size = new System.Drawing.Size(374, 60);
            this.genProRptBtn.TabIndex = 4;
            this.genProRptBtn.Text = "Generate Provider Report";
            this.genProRptBtn.UseVisualStyleBackColor = true;
            this.genProRptBtn.Click += new System.EventHandler(this.genProRptBtn_Click);
            // 
            // MainMenuProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 368);
            this.Controls.Add(this.genProRptBtn);
            this.Controls.Add(this.accProDirBtn);
            this.Controls.Add(this.rptServBtn);
            this.Controls.Add(this.chocAnMMAdminLbl);
            this.Controls.Add(this.valMemBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenuProvider";
            this.Text = "Provider Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valMemBtn;
        private System.Windows.Forms.Label chocAnMMAdminLbl;
        private System.Windows.Forms.Button rptServBtn;
        private System.Windows.Forms.Button accProDirBtn;
        private System.Windows.Forms.Button genProRptBtn;
    }
}