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
            this.addMemBtn = new System.Windows.Forms.Button();
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
            emailLabel.Location = new System.Drawing.Point(176, 323);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 39;
            emailLabel.Text = "Email:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(186, 197);
            zipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(25, 13);
            zipLabel.TabIndex = 38;
            zipLabel.Text = "Zip:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(176, 167);
            stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 37;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(184, 135);
            cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 36;
            cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(172, 100);
            streetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 35;
            streetLabel.Text = "Street:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(173, 65);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 34;
            nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(94, 32);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 33;
            idLabel.Text = "Id:";
            // 
            // emailMemberTextBox
            // 
            this.emailMemberTextBox.Location = new System.Drawing.Point(217, 319);
            this.emailMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailMemberTextBox.Name = "emailMemberTextBox";
            this.emailMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.emailMemberTextBox.TabIndex = 50;
            // 
            // cityMemberTextBox
            // 
            this.cityMemberTextBox.Location = new System.Drawing.Point(217, 131);
            this.cityMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityMemberTextBox.Name = "cityMemberTextBox";
            this.cityMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.cityMemberTextBox.TabIndex = 49;
            // 
            // stateMemberTextBox
            // 
            this.stateMemberTextBox.Location = new System.Drawing.Point(217, 163);
            this.stateMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stateMemberTextBox.Name = "stateMemberTextBox";
            this.stateMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.stateMemberTextBox.TabIndex = 48;
            // 
            // zipMemberTextBox
            // 
            this.zipMemberTextBox.Location = new System.Drawing.Point(217, 196);
            this.zipMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zipMemberTextBox.Name = "zipMemberTextBox";
            this.zipMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.zipMemberTextBox.TabIndex = 47;
            // 
            // streetMemberTextBox
            // 
            this.streetMemberTextBox.Location = new System.Drawing.Point(217, 98);
            this.streetMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.streetMemberTextBox.Name = "streetMemberTextBox";
            this.streetMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.streetMemberTextBox.TabIndex = 46;
            // 
            // nameMemberTextBox
            // 
            this.nameMemberTextBox.Location = new System.Drawing.Point(217, 66);
            this.nameMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameMemberTextBox.Name = "nameMemberTextBox";
            this.nameMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.nameMemberTextBox.TabIndex = 45;
            // 
            // idMemberTextBox
            // 
            this.idMemberTextBox.Location = new System.Drawing.Point(133, 32);
            this.idMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idMemberTextBox.Name = "idMemberTextBox";
            this.idMemberTextBox.Size = new System.Drawing.Size(125, 20);
            this.idMemberTextBox.TabIndex = 44;
            // 
            // DeleteMemberBtn
            // 
            this.DeleteMemberBtn.Location = new System.Drawing.Point(385, 225);
            this.DeleteMemberBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteMemberBtn.Name = "DeleteMemberBtn";
            this.DeleteMemberBtn.Size = new System.Drawing.Size(122, 34);
            this.DeleteMemberBtn.TabIndex = 42;
            this.DeleteMemberBtn.Text = "Delete Member";
            this.DeleteMemberBtn.UseVisualStyleBackColor = true;
            this.DeleteMemberBtn.Click += new System.EventHandler(this.DeleteMemberBtn_Click);
            // 
            // UpdateMemBtn
            // 
            this.UpdateMemBtn.Location = new System.Drawing.Point(385, 162);
            this.UpdateMemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateMemBtn.Name = "UpdateMemBtn";
            this.UpdateMemBtn.Size = new System.Drawing.Size(122, 34);
            this.UpdateMemBtn.TabIndex = 41;
            this.UpdateMemBtn.Text = "Update";
            this.UpdateMemBtn.UseVisualStyleBackColor = true;
            this.UpdateMemBtn.Click += new System.EventHandler(this.UpdateMemBtn_Click);
            // 
            // clearTxtBox
            // 
            this.clearTxtBox.Location = new System.Drawing.Point(229, 351);
            this.clearTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearTxtBox.Name = "clearTxtBox";
            this.clearTxtBox.Size = new System.Drawing.Size(62, 23);
            this.clearTxtBox.TabIndex = 40;
            this.clearTxtBox.Text = "Clear";
            this.clearTxtBox.UseVisualStyleBackColor = true;
            this.clearTxtBox.Click += new System.EventHandler(this.clearTxtBox_Click);
            // 
            // SearchMemberBtn
            // 
            this.SearchMemberBtn.Location = new System.Drawing.Point(280, 28);
            this.SearchMemberBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchMemberBtn.Name = "SearchMemberBtn";
            this.SearchMemberBtn.Size = new System.Drawing.Size(85, 24);
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
            this.membersdataGridView.Location = new System.Drawing.Point(3, 388);
            this.membersdataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.membersdataGridView.Name = "membersdataGridView";
            this.membersdataGridView.RowTemplate.Height = 24;
            this.membersdataGridView.Size = new System.Drawing.Size(722, 158);
            this.membersdataGridView.TabIndex = 51;
            this.membersdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersdataGridView_CellClick);
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
            this.statusCheckBox.Location = new System.Drawing.Point(217, 232);
            this.statusCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(80, 17);
            this.statusCheckBox.TabIndex = 52;
            this.statusCheckBox.Text = "Suspended";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // commentMemberTextBox
            // 
            this.commentMemberTextBox.Location = new System.Drawing.Point(217, 266);
            this.commentMemberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commentMemberTextBox.Multiline = true;
            this.commentMemberTextBox.Name = "commentMemberTextBox";
            this.commentMemberTextBox.Size = new System.Drawing.Size(125, 40);
            this.commentMemberTextBox.TabIndex = 53;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(174, 232);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 54;
            this.status.Text = "Status";
            // 
            // comments
            // 
            this.comments.AutoSize = true;
            this.comments.Location = new System.Drawing.Point(156, 274);
            this.comments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(55, 13);
            this.comments.TabIndex = 55;
            this.comments.Text = "comments";
            // 
            // addMemBtn
            // 
            this.addMemBtn.Location = new System.Drawing.Point(385, 100);
            this.addMemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addMemBtn.Name = "addMemBtn";
            this.addMemBtn.Size = new System.Drawing.Size(122, 34);
            this.addMemBtn.TabIndex = 56;
            this.addMemBtn.Text = "Add Member";
            this.addMemBtn.UseVisualStyleBackColor = true;
            this.addMemBtn.Click += new System.EventHandler(this.addMemBtn_Click);
            // 
            // ModifyMemberRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 590);
            this.Controls.Add(this.addMemBtn);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button addMemBtn;
    }
}