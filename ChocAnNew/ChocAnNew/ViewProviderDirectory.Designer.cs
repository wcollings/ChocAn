namespace ChocAnNew
{
    partial class ViewProviderDirectory
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.providerDirectoryTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ProviderDirectoryTableAdapter();
            this.UpdateProviderDir = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.providerDirectoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            this.feeDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerDirectoryBindingSource
            // 
            this.providerDirectoryBindingSource.DataMember = "ProviderDirectory";
            this.providerDirectoryBindingSource.DataSource = this.databaseCADataSet;
            // 
            // databaseCADataSet
            // 
            this.databaseCADataSet.DataSetName = "DatabaseCADataSet";
            this.databaseCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerDirectoryTableAdapter
            // 
            this.providerDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateProviderDir
            // 
            this.UpdateProviderDir.Location = new System.Drawing.Point(11, 266);
            this.UpdateProviderDir.Name = "UpdateProviderDir";
            this.UpdateProviderDir.Size = new System.Drawing.Size(153, 40);
            this.UpdateProviderDir.TabIndex = 1;
            this.UpdateProviderDir.Text = "Modify Directory";
            this.UpdateProviderDir.UseVisualStyleBackColor = true;
            this.UpdateProviderDir.Click += new System.EventHandler(this.UpdateProviderDir_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(373, 259);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 39);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ViewProviderDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 388);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.UpdateProviderDir);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewProviderDirectory";
            this.Text = "View Provider Directory";
            this.Load += new System.EventHandler(this.ViewProviderDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource providerDirectoryBindingSource;
        private DatabaseCADataSetTableAdapters.ProviderDirectoryTableAdapter providerDirectoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UpdateProviderDir;
        private System.Windows.Forms.Button Cancel;
    }
}