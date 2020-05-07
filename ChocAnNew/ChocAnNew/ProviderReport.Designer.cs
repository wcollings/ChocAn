namespace ChocAnNew
{
    partial class ProviderReport
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
            this.provGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.provGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // provGrid
            // 
            this.provGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provGrid.Location = new System.Drawing.Point(39, 53);
            this.provGrid.Name = "provGrid";
            this.provGrid.RowTemplate.Height = 28;
            this.provGrid.Size = new System.Drawing.Size(694, 194);
            this.provGrid.TabIndex = 0;
            // 
            // ProviderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.provGrid);
            this.Name = "ProviderReport";
            this.Text = "ProviderReport";
            this.Load += new System.EventHandler(this.ProviderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView provGrid;
    }
}