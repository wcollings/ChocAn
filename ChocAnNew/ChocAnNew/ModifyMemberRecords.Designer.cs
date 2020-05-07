namespace ChocAnNew
{
    partial class ModifyMemberRecords
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idLabel;
            this.emailMemberTextBox = new System.Windows.Forms.TextBox();
            this.cityMemberTextBox = new System.Windows.Forms.TextBox();
            this.stateMemberTextBox = new System.Windows.Forms.TextBox();
            this.zipMemberTextBox = new System.Windows.Forms.TextBox();
            this.streetMemberTextBox = new System.Windows.Forms.TextBox();
            this.nameMemberTextBox = new System.Windows.Forms.TextBox();
            this.idMemberTextBox = new System.Windows.Forms.TextBox();
            this.DeleteMemberBtn = new System.Windows.Forms.Button();
            this.UpdateMemBtn = new System.Windows.Forms.Button();
            this.clearTxtBox = new System.Windows.Forms.Button();
            this.SearchMemberBtn = new System.Windows.Forms.Button();
            this.membersdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.membersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.MembersTableAdapter();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.commentMemberTextBox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(234, 397);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 39;
            emailLabel.Text = "Email:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(248, 243);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(32, 17);
            zipLabel.TabIndex = 38;
            zipLabel.Text = "Zip:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(235, 206);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 37;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(245, 166);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 36;
            cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(230, 123);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(50, 17);
            streetLabel.TabIndex = 35;
            streetLabel.Text = "Street:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(231, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 34;
            nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(125, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 33;
            idLabel.Text = "Id:";
            // 
            // emailMemberTextBox
            // 
            this.emailMemberTextBox.Location = new System.Drawing.Point(289, 393);
            this.emailMemberTextBox.Name = "emailMemberTextBox";
            this.emailMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.emailMemberTextBox.TabIndex = 50;
            // 
            // cityMemberTextBox
            // 
            this.cityMemberTextBox.Location = new System.Drawing.Point(289, 161);
            this.cityMemberTextBox.Name = "cityMemberTextBox";
            this.cityMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.cityMemberTextBox.TabIndex = 49;
            // 
            // stateMemberTextBox
            // 
            this.stateMemberTextBox.Location = new System.Drawing.Point(289, 201);
            this.stateMemberTextBox.Name = "stateMemberTextBox";
            this.stateMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.stateMemberTextBox.TabIndex = 48;
            // 
            // zipMemberTextBox
            // 
            this.zipMemberTextBox.Location = new System.Drawing.Point(289, 241);
            this.zipMemberTextBox.Name = "zipMemberTextBox";
            this.zipMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.zipMemberTextBox.TabIndex = 47;
            // 
            // streetMemberTextBox
            // 
            this.streetMemberTextBox.Location = new System.Drawing.Point(289, 121);
            this.streetMemberTextBox.Name = "streetMemberTextBox";
            this.streetMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.streetMemberTextBox.TabIndex = 46;
            // 
            // nameMemberTextBox
            // 
            this.nameMemberTextBox.Location = new System.Drawing.Point(289, 81);
            this.nameMemberTextBox.Name = "nameMemberTextBox";
            this.nameMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.nameMemberTextBox.TabIndex = 45;
            // 
            // idMemberTextBox
            // 
            this.idMemberTextBox.Location = new System.Drawing.Point(177, 40);
            this.idMemberTextBox.Name = "idMemberTextBox";
            this.idMemberTextBox.Size = new System.Drawing.Size(165, 22);
            this.idMemberTextBox.TabIndex = 44;
            // 
            // DeleteMemberBtn
            // 
            this.DeleteMemberBtn.Location = new System.Drawing.Point(513, 277);
            this.DeleteMemberBtn.Name = "DeleteMemberBtn";
            this.DeleteMemberBtn.Size = new System.Drawing.Size(163, 42);
            this.DeleteMemberBtn.TabIndex = 42;
            this.DeleteMemberBtn.Text = "Delete Member";
            this.DeleteMemberBtn.UseVisualStyleBackColor = true;
            this.DeleteMemberBtn.Click += new System.EventHandler(this.DeleteMemberBtn_Click);
            // 
            // UpdateMemBtn
            // 
            this.UpdateMemBtn.Location = new System.Drawing.Point(513, 199);
            this.UpdateMemBtn.Name = "UpdateMemBtn";
            this.UpdateMemBtn.Size = new System.Drawing.Size(163, 42);
            this.UpdateMemBtn.TabIndex = 41;
            this.UpdateMemBtn.Text = "Update";
            this.UpdateMemBtn.UseVisualStyleBackColor = true;
            this.UpdateMemBtn.Click += new System.EventHandler(this.UpdateMemBtn_Click);
            // 
            // clearTxtBox
            // 
            this.clearTxtBox.Location = new System.Drawing.Point(305, 432);
            this.clearTxtBox.Name = "clearTxtBox";
            this.clearTxtBox.Size = new System.Drawing.Size(83, 28);
            this.clearTxtBox.TabIndex = 40;
            this.clearTxtBox.Text = "Clear";
            this.clearTxtBox.UseVisualStyleBackColor = true;
            this.clearTxtBox.Click += new System.EventHandler(this.clearTxtBox_Click);
            // 
            // SearchMemberBtn
            // 
            this.SearchMemberBtn.Location = new System.Drawing.Point(374, 35);
            this.SearchMemberBtn.Name = "SearchMemberBtn";
            this.SearchMemberBtn.Size = new System.Drawing.Size(113, 30);
            this.SearchMemberBtn.TabIndex = 32;
            this.SearchMemberBtn.Text = "Search";
            this.SearchMemberBtn.UseVisualStyleBackColor = true;
            this.SearchMemberBtn.Click += new System.EventHandler(this.SearchMemberBtn_Click);
            // 
            // membersdataGridView
            // 
            this.membersdataGridView.AutoGenerateColumns = false;
            this.membersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.membersdataGridView.DataSource = this.membersBindingSource;
            this.membersdataGridView.Location = new System.Drawing.Point(4, 477);
            this.membersdataGridView.Name = "membersdataGridView";
            this.membersdataGridView.RowTemplate.Height = 24;
            this.membersdataGridView.Size = new System.Drawing.Size(963, 194);
            this.membersdataGridView.TabIndex = 51;
            this.membersdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersdataGridView_CellClick);
            //this.membersdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersdataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.databaseCADataSet;
            // 
            // databaseCADataSet
            // 
            this.databaseCADataSet.DataSetName = "DatabaseCADataSet";
            this.databaseCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(289, 285);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(102, 21);
            this.statusCheckBox.TabIndex = 52;
            this.statusCheckBox.Text = "Suspended";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // commentMemberTextBox
            // 
            this.commentMemberTextBox.Location = new System.Drawing.Point(289, 327);
            this.commentMemberTextBox.Multiline = true;
            this.commentMemberTextBox.Name = "commentMemberTextBox";
            this.commentMemberTextBox.Size = new System.Drawing.Size(165, 48);
            this.commentMemberTextBox.TabIndex = 53;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(232, 286);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(48, 17);
            this.status.TabIndex = 54;
            this.status.Text = "Status";
            // 
            // comments
            // 
            this.comments.AutoSize = true;
            this.comments.Location = new System.Drawing.Point(208, 337);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(72, 17);
            this.comments.TabIndex = 55;
            this.comments.Text = "comments";
            // 
            // ModifyMemberRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 726);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.status);
            this.Controls.Add(this.commentMemberTextBox);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.membersdataGridView);
            this.Controls.Add(this.emailMemberTextBox);
            this.Controls.Add(this.cityMemberTextBox);
            this.Controls.Add(this.stateMemberTextBox);
            this.Controls.Add(this.zipMemberTextBox);
            this.Controls.Add(this.streetMemberTextBox);
            this.Controls.Add(this.nameMemberTextBox);
            this.Controls.Add(this.idMemberTextBox);
            this.Controls.Add(this.DeleteMemberBtn);
            this.Controls.Add(this.UpdateMemBtn);
            this.Controls.Add(this.clearTxtBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(zipLabel);
            this.Controls.Add(stateLabel);
            this.Controls.Add(cityLabel);
            this.Controls.Add(streetLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.SearchMemberBtn);
            this.Name = "ModifyMemberRecords";
            this.Text = "Modify Member Records";
            this.Load += new System.EventHandler(this.ModifyMemberRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailMemberTextBox;
        private System.Windows.Forms.TextBox cityMemberTextBox;
        private System.Windows.Forms.TextBox stateMemberTextBox;
        private System.Windows.Forms.TextBox zipMemberTextBox;
        private System.Windows.Forms.TextBox streetMemberTextBox;
        private System.Windows.Forms.TextBox nameMemberTextBox;
        private System.Windows.Forms.TextBox idMemberTextBox;
        private System.Windows.Forms.Button DeleteMemberBtn;
        private System.Windows.Forms.Button UpdateMemBtn;
        private System.Windows.Forms.Button clearTxtBox;
        private System.Windows.Forms.Button SearchMemberBtn;
        private System.Windows.Forms.DataGridView membersdataGridView;
        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseCADataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.TextBox commentMemberTextBox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label comments;
    }
}