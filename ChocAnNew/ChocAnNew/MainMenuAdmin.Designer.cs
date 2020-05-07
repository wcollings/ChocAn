namespace ChocAnNew
{
    partial class MainMenuAdmin
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
            this.memRecBtn = new System.Windows.Forms.Button();
            this.chocAnMMAdminLbl = new System.Windows.Forms.Label();
            this.modProBtn = new System.Windows.Forms.Button();
            this.modProDirBtn = new System.Windows.Forms.Button();
            this.accProDirBtn = new System.Windows.Forms.Button();
            this.genManRepBtn = new System.Windows.Forms.Button();
            this.modMemberRecs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memRecBtn
            // 
            this.memRecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memRecBtn.Location = new System.Drawing.Point(77, 116);
            this.memRecBtn.Margin = new System.Windows.Forms.Padding(4);
            this.memRecBtn.Name = "memRecBtn";
            this.memRecBtn.Size = new System.Drawing.Size(332, 52);
            this.memRecBtn.TabIndex = 0;
            this.memRecBtn.Text = "Member Records";
            this.memRecBtn.UseVisualStyleBackColor = true;
            this.memRecBtn.Click += new System.EventHandler(this.addMemBtn_Click);
            // 
            // chocAnMMAdminLbl
            // 
            this.chocAnMMAdminLbl.AutoSize = true;
            this.chocAnMMAdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocAnMMAdminLbl.Location = new System.Drawing.Point(65, 11);
            this.chocAnMMAdminLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chocAnMMAdminLbl.Name = "chocAnMMAdminLbl";
            this.chocAnMMAdminLbl.Size = new System.Drawing.Size(333, 31);
            this.chocAnMMAdminLbl.TabIndex = 1;
            this.chocAnMMAdminLbl.Text = "Main Menu ChocAn Admin";
            // 
            // modProBtn
            // 
            this.modProBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProBtn.Location = new System.Drawing.Point(77, 337);
            this.modProBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modProBtn.Name = "modProBtn";
            this.modProBtn.Size = new System.Drawing.Size(332, 52);
            this.modProBtn.TabIndex = 5;
            this.modProBtn.Text = "Provider Records";
            this.modProBtn.UseVisualStyleBackColor = true;
            this.modProBtn.Click += new System.EventHandler(this.modProBtn_Click);
            // 
            // modProDirBtn
            // 
            this.modProDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProDirBtn.Location = new System.Drawing.Point(77, 394);
            this.modProDirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modProDirBtn.Name = "modProDirBtn";
            this.modProDirBtn.Size = new System.Drawing.Size(332, 52);
            this.modProDirBtn.TabIndex = 7;
            this.modProDirBtn.Text = "Modify Provider Directory";
            this.modProDirBtn.UseVisualStyleBackColor = true;
            this.modProDirBtn.Click += new System.EventHandler(this.modProDirBtn_Click);
            // 
            // accProDirBtn
            // 
            this.accProDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accProDirBtn.Location = new System.Drawing.Point(77, 449);
            this.accProDirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.accProDirBtn.Name = "accProDirBtn";
            this.accProDirBtn.Size = new System.Drawing.Size(332, 52);
            this.accProDirBtn.TabIndex = 8;
            this.accProDirBtn.Text = "Access Provider Directory";
            this.accProDirBtn.UseVisualStyleBackColor = true;
            this.accProDirBtn.Click += new System.EventHandler(this.accProDirBtn_Click);
            // 
            // genManRepBtn
            // 
            this.genManRepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genManRepBtn.Location = new System.Drawing.Point(77, 505);
            this.genManRepBtn.Margin = new System.Windows.Forms.Padding(4);
            this.genManRepBtn.Name = "genManRepBtn";
            this.genManRepBtn.Size = new System.Drawing.Size(332, 52);
            this.genManRepBtn.TabIndex = 9;
            this.genManRepBtn.Text = "Generate Manager Report";
            this.genManRepBtn.UseVisualStyleBackColor = true;
            this.genManRepBtn.Click += new System.EventHandler(this.genManRepBtn_Click);
            // 
            // modMemberRecs
            // 
            this.modMemberRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modMemberRecs.Location = new System.Drawing.Point(77, 211);
            this.modMemberRecs.Name = "modMemberRecs";
            this.modMemberRecs.Size = new System.Drawing.Size(332, 52);
            this.modMemberRecs.TabIndex = 10;
            this.modMemberRecs.Text = "Modify Member Records";
            this.modMemberRecs.UseVisualStyleBackColor = true;
            this.modMemberRecs.Click += new System.EventHandler(this.modMemberRecs_Click);
            // 
            // MainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 572);
            this.Controls.Add(this.modMemberRecs);
            this.Controls.Add(this.genManRepBtn);
            this.Controls.Add(this.accProDirBtn);
            this.Controls.Add(this.modProDirBtn);
            this.Controls.Add(this.modProBtn);
            this.Controls.Add(this.chocAnMMAdminLbl);
            this.Controls.Add(this.memRecBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuAdmin";
            this.Text = "Main Menu Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memRecBtn;
        private System.Windows.Forms.Label chocAnMMAdminLbl;
        private System.Windows.Forms.Button modProBtn;
        private System.Windows.Forms.Button modProDirBtn;
        private System.Windows.Forms.Button accProDirBtn;
        private System.Windows.Forms.Button genManRepBtn;
        private System.Windows.Forms.Button modMemberRecs;
    }
}