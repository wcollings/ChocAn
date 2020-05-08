namespace ChocAnNew
{
    partial class AccountPayableSummaryReport
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
            this.accPayGrid = new System.Windows.Forms.DataGridView();
            this.ConstextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalFeeTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.provTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accPayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accPayGrid
            // 
            this.accPayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accPayGrid.Location = new System.Drawing.Point(28, 58);
            this.accPayGrid.Name = "accPayGrid";
            this.accPayGrid.RowTemplate.Height = 28;
            this.accPayGrid.Size = new System.Drawing.Size(667, 201);
            this.accPayGrid.TabIndex = 0;
            // 
            // ConstextBox
            // 
            this.ConstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstextBox.Location = new System.Drawing.Point(371, 409);
            this.ConstextBox.Name = "ConstextBox";
            this.ConstextBox.ReadOnly = true;
            this.ConstextBox.Size = new System.Drawing.Size(228, 32);
            this.ConstextBox.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Total consultations";
            // 
            // TotalFeeTxtBox
            // 
            this.TotalFeeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFeeTxtBox.Location = new System.Drawing.Point(371, 369);
            this.TotalFeeTxtBox.Name = "TotalFeeTxtBox";
            this.TotalFeeTxtBox.ReadOnly = true;
            this.TotalFeeTxtBox.Size = new System.Drawing.Size(228, 32);
            this.TotalFeeTxtBox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Total Fees";
            // 
            // provTextBox
            // 
            this.provTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provTextBox.Location = new System.Drawing.Point(371, 331);
            this.provTextBox.Name = "provTextBox";
            this.provTextBox.ReadOnly = true;
            this.provTextBox.Size = new System.Drawing.Size(228, 32);
            this.provTextBox.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total Number of Providers";
            // 
            // AccountPayableSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.provTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConstextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalFeeTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accPayGrid);
            this.Name = "AccountPayableSummaryReport";
            this.Text = "Account Payable Summary Report";
            this.Load += new System.EventHandler(this.AccountPayableSummaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accPayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accPayGrid;
        private System.Windows.Forms.TextBox ConstextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalFeeTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox provTextBox;
        private System.Windows.Forms.Label label3;
    }
}