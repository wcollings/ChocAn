namespace ChocAnNew
{
    partial class ReportServicesMenu
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
            this.memIDLbl = new System.Windows.Forms.Label();
            this.proIDLbl = new System.Windows.Forms.Label();
            this.servCodeLbl = new System.Windows.Forms.Label();
            this.servDateLbl = new System.Windows.Forms.Label();
            this.commentsTxtBox = new System.Windows.Forms.RichTextBox();
            this.commentsLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ProvComboBox = new System.Windows.Forms.ComboBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.providersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ProvidersTableAdapter();
            this.providersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.providersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.meMcomboBox = new System.Windows.Forms.ComboBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKServiceProvidersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceRecordTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ServiceRecordTableAdapter();
            this.membersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.MembersTableAdapter();
            this.serCodeComboBox = new System.Windows.Forms.ComboBox();
            this.providerDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerDirectoryTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ProviderDirectoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServiceProvidersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerDirectoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memIDLbl
            // 
            this.memIDLbl.AutoSize = true;
            this.memIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memIDLbl.Location = new System.Drawing.Point(21, 72);
            this.memIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memIDLbl.Name = "memIDLbl";
            this.memIDLbl.Size = new System.Drawing.Size(132, 29);
            this.memIDLbl.TabIndex = 0;
            this.memIDLbl.Text = "Member ID";
            // 
            // proIDLbl
            // 
            this.proIDLbl.AutoSize = true;
            this.proIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proIDLbl.Location = new System.Drawing.Point(22, 33);
            this.proIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proIDLbl.Name = "proIDLbl";
            this.proIDLbl.Size = new System.Drawing.Size(133, 29);
            this.proIDLbl.TabIndex = 2;
            this.proIDLbl.Text = "Provider ID";
            // 
            // servCodeLbl
            // 
            this.servCodeLbl.AutoSize = true;
            this.servCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servCodeLbl.Location = new System.Drawing.Point(-2, 111);
            this.servCodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servCodeLbl.Name = "servCodeLbl";
            this.servCodeLbl.Size = new System.Drawing.Size(159, 29);
            this.servCodeLbl.TabIndex = 4;
            this.servCodeLbl.Text = "Service Code";
            // 
            // servDateLbl
            // 
            this.servDateLbl.AutoSize = true;
            this.servDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servDateLbl.Location = new System.Drawing.Point(3, 151);
            this.servDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servDateLbl.Name = "servDateLbl";
            this.servDateLbl.Size = new System.Drawing.Size(150, 29);
            this.servDateLbl.TabIndex = 6;
            this.servDateLbl.Text = "Service Date";
            // 
            // commentsTxtBox
            // 
            this.commentsTxtBox.Location = new System.Drawing.Point(162, 191);
            this.commentsTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentsTxtBox.Name = "commentsTxtBox";
            this.commentsTxtBox.Size = new System.Drawing.Size(296, 69);
            this.commentsTxtBox.TabIndex = 9;
            this.commentsTxtBox.Text = "";
            // 
            // commentsLbl
            // 
            this.commentsLbl.AutoSize = true;
            this.commentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLbl.Location = new System.Drawing.Point(24, 191);
            this.commentsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsLbl.Name = "commentsLbl";
            this.commentsLbl.Size = new System.Drawing.Size(129, 29);
            this.commentsLbl.TabIndex = 8;
            this.commentsLbl.Text = "Comments";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(162, 271);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(147, 52);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(314, 271);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(147, 52);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // ProvComboBox
            // 
            this.ProvComboBox.DataSource = this.providersBindingSource;
            this.ProvComboBox.DisplayMember = "Id";
            this.ProvComboBox.FormattingEnabled = true;
            this.ProvComboBox.Location = new System.Drawing.Point(162, 33);
            this.ProvComboBox.Name = "ProvComboBox";
            this.ProvComboBox.Size = new System.Drawing.Size(296, 28);
            this.ProvComboBox.TabIndex = 13;
            this.ProvComboBox.ValueMember = "Id";
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.databaseCADataSet;
            // 
            // databaseCADataSet
            // 
            this.databaseCADataSet.DataSetName = "DatabaseCADataSet";
            this.databaseCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // providersBindingSource1
            // 
            this.providersBindingSource1.DataMember = "Providers";
            this.providersBindingSource1.DataSource = this.databaseCADataSet;
            // 
            // providersBindingSource2
            // 
            this.providersBindingSource2.DataMember = "Providers";
            this.providersBindingSource2.DataSource = this.databaseCADataSet;
            // 
            // meMcomboBox
            // 
            this.meMcomboBox.DataSource = this.membersBindingSource;
            this.meMcomboBox.DisplayMember = "Id";
            this.meMcomboBox.FormattingEnabled = true;
            this.meMcomboBox.Location = new System.Drawing.Point(161, 72);
            this.meMcomboBox.Name = "meMcomboBox";
            this.meMcomboBox.Size = new System.Drawing.Size(300, 28);
            this.meMcomboBox.TabIndex = 14;
            this.meMcomboBox.ValueMember = "Id";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.databaseCADataSet;
            // 
            // fKServiceProvidersBindingSource
            // 
            this.fKServiceProvidersBindingSource.DataMember = "FK_Service_Providers";
            this.fKServiceProvidersBindingSource.DataSource = this.providersBindingSource;
            // 
            // serviceRecordTableAdapter
            // 
            this.serviceRecordTableAdapter.ClearBeforeFill = true;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // serCodeComboBox
            // 
            this.serCodeComboBox.DataSource = this.providerDirectoryBindingSource;
            this.serCodeComboBox.DisplayMember = "ServiceName";
            this.serCodeComboBox.FormattingEnabled = true;
            this.serCodeComboBox.Location = new System.Drawing.Point(161, 111);
            this.serCodeComboBox.Name = "serCodeComboBox";
            this.serCodeComboBox.Size = new System.Drawing.Size(296, 28);
            this.serCodeComboBox.TabIndex = 15;
            this.serCodeComboBox.ValueMember = "Id";
            // 
            // providerDirectoryBindingSource
            // 
            this.providerDirectoryBindingSource.DataMember = "ProviderDirectory";
            this.providerDirectoryBindingSource.DataSource = this.databaseCADataSet;
            // 
            // providerDirectoryTableAdapter
            // 
            this.providerDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // ReportServicesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.serCodeComboBox);
            this.Controls.Add(this.meMcomboBox);
            this.Controls.Add(this.ProvComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.commentsTxtBox);
            this.Controls.Add(this.commentsLbl);
            this.Controls.Add(this.servDateLbl);
            this.Controls.Add(this.servCodeLbl);
            this.Controls.Add(this.proIDLbl);
            this.Controls.Add(this.memIDLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportServicesMenu";
            this.Text = "Report Service";
            this.Load += new System.EventHandler(this.ReportServicesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServiceProvidersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerDirectoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memIDLbl;
        private System.Windows.Forms.Label proIDLbl;
        private System.Windows.Forms.Label servCodeLbl;
        private System.Windows.Forms.Label servDateLbl;
        private System.Windows.Forms.RichTextBox commentsTxtBox;
        private System.Windows.Forms.Label commentsLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ProvComboBox;
        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DatabaseCADataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource1;
        private System.Windows.Forms.BindingSource providersBindingSource2;
        private System.Windows.Forms.ComboBox meMcomboBox;
        private System.Windows.Forms.BindingSource fKServiceProvidersBindingSource;
        private DatabaseCADataSetTableAdapters.ServiceRecordTableAdapter serviceRecordTableAdapter;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseCADataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.ComboBox serCodeComboBox;
        private System.Windows.Forms.BindingSource providerDirectoryBindingSource;
        private DatabaseCADataSetTableAdapters.ProviderDirectoryTableAdapter providerDirectoryTableAdapter;
    }
}