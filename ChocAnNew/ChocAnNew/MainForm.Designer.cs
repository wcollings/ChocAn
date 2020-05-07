namespace ChocAnNew
{
    partial class MainForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label providerIdLabel;
            System.Windows.Forms.Label memberIdLabel;
            System.Windows.Forms.Label serviceCodeLabel;
            System.Windows.Forms.Label currentDateAndTimeLabel;
            System.Windows.Forms.Label serviceDateLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.serviceRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceRecordTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ServiceRecordTableAdapter();
            this.tableAdapterManager = new ChocAnNew.DatabaseCADataSetTableAdapters.TableAdapterManager();
            this.serviceRecordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.serviceRecordBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.providerIdTextBox = new System.Windows.Forms.TextBox();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.serviceCodeTextBox = new System.Windows.Forms.TextBox();
            this.currentDateAndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.serviceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.adminBtn = new System.Windows.Forms.Button();
            this.providerMenuBtn = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            providerIdLabel = new System.Windows.Forms.Label();
            memberIdLabel = new System.Windows.Forms.Label();
            serviceCodeLabel = new System.Windows.Forms.Label();
            currentDateAndTimeLabel = new System.Windows.Forms.Label();
            serviceDateLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRecordBindingNavigator)).BeginInit();
            this.serviceRecordBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(72, 37);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // providerIdLabel
            // 
            providerIdLabel.AutoSize = true;
            providerIdLabel.Location = new System.Drawing.Point(72, 58);
            providerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            providerIdLabel.Name = "providerIdLabel";
            providerIdLabel.Size = new System.Drawing.Size(61, 13);
            providerIdLabel.TabIndex = 3;
            providerIdLabel.Text = "Provider Id:";
            // 
            // memberIdLabel
            // 
            memberIdLabel.AutoSize = true;
            memberIdLabel.Location = new System.Drawing.Point(72, 79);
            memberIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            memberIdLabel.Name = "memberIdLabel";
            memberIdLabel.Size = new System.Drawing.Size(60, 13);
            memberIdLabel.TabIndex = 5;
            memberIdLabel.Text = "Member Id:";
            // 
            // serviceCodeLabel
            // 
            serviceCodeLabel.AutoSize = true;
            serviceCodeLabel.Location = new System.Drawing.Point(72, 99);
            serviceCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            serviceCodeLabel.Name = "serviceCodeLabel";
            serviceCodeLabel.Size = new System.Drawing.Size(74, 13);
            serviceCodeLabel.TabIndex = 7;
            serviceCodeLabel.Text = "Service Code:";
            // 
            // currentDateAndTimeLabel
            // 
            currentDateAndTimeLabel.AutoSize = true;
            currentDateAndTimeLabel.Location = new System.Drawing.Point(72, 121);
            currentDateAndTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            currentDateAndTimeLabel.Name = "currentDateAndTimeLabel";
            currentDateAndTimeLabel.Size = new System.Drawing.Size(118, 13);
            currentDateAndTimeLabel.TabIndex = 9;
            currentDateAndTimeLabel.Text = "Current Date And Time:";
            // 
            // serviceDateLabel
            // 
            serviceDateLabel.AutoSize = true;
            serviceDateLabel.Location = new System.Drawing.Point(72, 142);
            serviceDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            serviceDateLabel.Name = "serviceDateLabel";
            serviceDateLabel.Size = new System.Drawing.Size(72, 13);
            serviceDateLabel.TabIndex = 11;
            serviceDateLabel.Text = "Service Date:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(72, 162);
            commentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 13;
            commentsLabel.Text = "Comments:";
            // 
            // databaseCADataSet
            // 
            this.databaseCADataSet.DataSetName = "DatabaseCADataSet";
            this.databaseCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceRecordBindingSource
            // 
            this.serviceRecordBindingSource.DataMember = "ServiceRecord";
            this.serviceRecordBindingSource.DataSource = this.databaseCADataSet;
            // 
            // serviceRecordTableAdapter
            // 
            this.serviceRecordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProviderDirectoryTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.ServiceRecordTableAdapter = this.serviceRecordTableAdapter;
            this.tableAdapterManager.UpdateOrder = ChocAnNew.DatabaseCADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceRecordBindingNavigator
            // 
            this.serviceRecordBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviceRecordBindingNavigator.BindingSource = this.serviceRecordBindingSource;
            this.serviceRecordBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviceRecordBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviceRecordBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.serviceRecordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.serviceRecordBindingNavigatorSaveItem});
            this.serviceRecordBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviceRecordBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviceRecordBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviceRecordBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviceRecordBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviceRecordBindingNavigator.Name = "serviceRecordBindingNavigator";
            this.serviceRecordBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviceRecordBindingNavigator.Size = new System.Drawing.Size(628, 31);
            this.serviceRecordBindingNavigator.TabIndex = 0;
            this.serviceRecordBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // serviceRecordBindingNavigatorSaveItem
            // 
            this.serviceRecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceRecordBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceRecordBindingNavigatorSaveItem.Image")));
            this.serviceRecordBindingNavigatorSaveItem.Name = "serviceRecordBindingNavigatorSaveItem";
            this.serviceRecordBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.serviceRecordBindingNavigatorSaveItem.Text = "Save Data";
            this.serviceRecordBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceRecordBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceRecordBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(193, 35);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(188, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // providerIdTextBox
            // 
            this.providerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceRecordBindingSource, "ProviderId", true));
            this.providerIdTextBox.Location = new System.Drawing.Point(193, 56);
            this.providerIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.providerIdTextBox.Name = "providerIdTextBox";
            this.providerIdTextBox.Size = new System.Drawing.Size(188, 20);
            this.providerIdTextBox.TabIndex = 4;
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceRecordBindingSource, "MemberId", true));
            this.memberIdTextBox.Location = new System.Drawing.Point(193, 77);
            this.memberIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(188, 20);
            this.memberIdTextBox.TabIndex = 6;
            // 
            // serviceCodeTextBox
            // 
            this.serviceCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceRecordBindingSource, "ServiceCode", true));
            this.serviceCodeTextBox.Location = new System.Drawing.Point(193, 97);
            this.serviceCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serviceCodeTextBox.Name = "serviceCodeTextBox";
            this.serviceCodeTextBox.Size = new System.Drawing.Size(188, 20);
            this.serviceCodeTextBox.TabIndex = 8;
            // 
            // currentDateAndTimeDateTimePicker
            // 
            this.currentDateAndTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serviceRecordBindingSource, "CurrentDateAndTime", true));
            this.currentDateAndTimeDateTimePicker.Location = new System.Drawing.Point(193, 118);
            this.currentDateAndTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.currentDateAndTimeDateTimePicker.Name = "currentDateAndTimeDateTimePicker";
            this.currentDateAndTimeDateTimePicker.Size = new System.Drawing.Size(188, 20);
            this.currentDateAndTimeDateTimePicker.TabIndex = 10;
            // 
            // serviceDateDateTimePicker
            // 
            this.serviceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serviceRecordBindingSource, "ServiceDate", true));
            this.serviceDateDateTimePicker.Location = new System.Drawing.Point(193, 139);
            this.serviceDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.serviceDateDateTimePicker.Name = "serviceDateDateTimePicker";
            this.serviceDateDateTimePicker.Size = new System.Drawing.Size(188, 20);
            this.serviceDateDateTimePicker.TabIndex = 12;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceRecordBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(193, 160);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(188, 20);
            this.commentsTextBox.TabIndex = 14;
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(161, 226);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(75, 23);
            this.adminBtn.TabIndex = 15;
            this.adminBtn.Text = "Admin View";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // providerMenuBtn
            // 
            this.providerMenuBtn.Location = new System.Drawing.Point(242, 226);
            this.providerMenuBtn.Name = "providerMenuBtn";
            this.providerMenuBtn.Size = new System.Drawing.Size(85, 23);
            this.providerMenuBtn.TabIndex = 16;
            this.providerMenuBtn.Text = "Provider View";
            this.providerMenuBtn.UseVisualStyleBackColor = true;
            this.providerMenuBtn.Click += new System.EventHandler(this.providerMenuBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 278);
            this.Controls.Add(this.providerMenuBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(providerIdLabel);
            this.Controls.Add(this.providerIdTextBox);
            this.Controls.Add(memberIdLabel);
            this.Controls.Add(this.memberIdTextBox);
            this.Controls.Add(serviceCodeLabel);
            this.Controls.Add(this.serviceCodeTextBox);
            this.Controls.Add(currentDateAndTimeLabel);
            this.Controls.Add(this.currentDateAndTimeDateTimePicker);
            this.Controls.Add(serviceDateLabel);
            this.Controls.Add(this.serviceDateDateTimePicker);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.serviceRecordBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRecordBindingNavigator)).EndInit();
            this.serviceRecordBindingNavigator.ResumeLayout(false);
            this.serviceRecordBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource serviceRecordBindingSource;
        private DatabaseCADataSetTableAdapters.ServiceRecordTableAdapter serviceRecordTableAdapter;
        private DatabaseCADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator serviceRecordBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton serviceRecordBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox providerIdTextBox;
        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.TextBox serviceCodeTextBox;
        private System.Windows.Forms.DateTimePicker currentDateAndTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker serviceDateDateTimePicker;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button providerMenuBtn;
    }
}

