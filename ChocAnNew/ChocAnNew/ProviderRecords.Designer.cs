namespace ChocAnNew
{
    partial class ProviderRecords
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderRecords));
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ProvidersTableAdapter();
            this.tableAdapterManager = new ChocAnNew.DatabaseCADataSetTableAdapters.TableAdapterManager();
            this.providersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.providersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.providersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchProviderBtn = new System.Windows.Forms.Button();
            this.clearTxtBox = new System.Windows.Forms.Button();
            this.UpdateProvBtn = new System.Windows.Forms.Button();
            this.DeleteProvBtn = new System.Windows.Forms.Button();
            this.addProv = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingNavigator)).BeginInit();
            this.providersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(47, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(125, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(125, 150);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(50, 17);
            streetLabel.TabIndex = 15;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(125, 198);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(125, 243);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 17;
            stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(125, 282);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(32, 17);
            zipLabel.TabIndex = 18;
            zipLabel.Text = "Zip:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(124, 326);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email:";
            // 
            // databaseCADataSet
            // 
            this.databaseCADataSet.DataSetName = "DatabaseCADataSet";
            this.databaseCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.databaseCADataSet;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProviderDirectoryTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = this.providersTableAdapter;
            this.tableAdapterManager.ServiceRecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChocAnNew.DatabaseCADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // providersBindingNavigator
            // 
            this.providersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.providersBindingNavigator.BindingSource = this.providersBindingSource;
            this.providersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.providersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.providersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.providersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.providersBindingNavigatorSaveItem});
            this.providersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.providersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.providersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.providersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.providersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.providersBindingNavigator.Name = "providersBindingNavigator";
            this.providersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.providersBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.providersBindingNavigator.TabIndex = 9;
            this.providersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // providersBindingNavigatorSaveItem
            // 
            this.providersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.providersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("providersBindingNavigatorSaveItem.Image")));
            this.providersBindingNavigatorSaveItem.Name = "providersBindingNavigatorSaveItem";
            this.providersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.providersBindingNavigatorSaveItem.Text = "Save Data";
            this.providersBindingNavigatorSaveItem.Click += new System.EventHandler(this.providersBindingNavigatorSaveItem_Click);
            // 
            // providersDataGridView
            // 
            this.providersDataGridView.AutoGenerateColumns = false;
            this.providersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.providersDataGridView.DataSource = this.providersBindingSource;
            this.providersDataGridView.Location = new System.Drawing.Point(12, 441);
            this.providersDataGridView.Name = "providersDataGridView";
            this.providersDataGridView.RowTemplate.Height = 24;
            this.providersDataGridView.Size = new System.Drawing.Size(784, 220);
            this.providersDataGridView.TabIndex = 9;
            this.providersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.providersDataGridView_CellClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn3.HeaderText = "Street";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn5.HeaderText = "State";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Zip";
            this.dataGridViewTextBoxColumn6.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // SearchProviderBtn
            // 
            this.SearchProviderBtn.Location = new System.Drawing.Point(296, 40);
            this.SearchProviderBtn.Name = "SearchProviderBtn";
            this.SearchProviderBtn.Size = new System.Drawing.Size(113, 30);
            this.SearchProviderBtn.TabIndex = 12;
            this.SearchProviderBtn.Text = "Search";
            this.SearchProviderBtn.UseVisualStyleBackColor = true;
            this.SearchProviderBtn.Click += new System.EventHandler(this.SearchProviderBtn_Click);
            // 
            // clearTxtBox
            // 
            this.clearTxtBox.Location = new System.Drawing.Point(205, 373);
            this.clearTxtBox.Name = "clearTxtBox";
            this.clearTxtBox.Size = new System.Drawing.Size(83, 28);
            this.clearTxtBox.TabIndex = 21;
            this.clearTxtBox.Text = "Clear";
            this.clearTxtBox.UseVisualStyleBackColor = true;
            this.clearTxtBox.Click += new System.EventHandler(this.clearTxtBox_Click);
            // 
            // UpdateProvBtn
            // 
            this.UpdateProvBtn.Location = new System.Drawing.Point(435, 194);
            this.UpdateProvBtn.Name = "UpdateProvBtn";
            this.UpdateProvBtn.Size = new System.Drawing.Size(163, 42);
            this.UpdateProvBtn.TabIndex = 22;
            this.UpdateProvBtn.Text = "Update";
            this.UpdateProvBtn.UseVisualStyleBackColor = true;
            this.UpdateProvBtn.Click += new System.EventHandler(this.UpdateProvBtn_Click);
            // 
            // DeleteProvBtn
            // 
            this.DeleteProvBtn.Location = new System.Drawing.Point(435, 272);
            this.DeleteProvBtn.Name = "DeleteProvBtn";
            this.DeleteProvBtn.Size = new System.Drawing.Size(163, 42);
            this.DeleteProvBtn.TabIndex = 23;
            this.DeleteProvBtn.Text = "Delete Provider";
            this.DeleteProvBtn.UseVisualStyleBackColor = true;
            this.DeleteProvBtn.Click += new System.EventHandler(this.DeleteProvBtn_Click);
            // 
            // addProv
            // 
            this.addProv.Location = new System.Drawing.Point(435, 116);
            this.addProv.Name = "addProv";
            this.addProv.Size = new System.Drawing.Size(163, 42);
            this.addProv.TabIndex = 24;
            this.addProv.Text = "Add Provider";
            this.addProv.UseVisualStyleBackColor = true;
            this.addProv.Click += new System.EventHandler(this.addProv_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(99, 45);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(165, 22);
            this.idTextBox.TabIndex = 25;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(180, 114);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 22);
            this.nameTextBox.TabIndex = 26;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(180, 150);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(165, 22);
            this.streetTextBox.TabIndex = 27;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(180, 279);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(165, 22);
            this.zipTextBox.TabIndex = 28;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(180, 238);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(165, 22);
            this.stateTextBox.TabIndex = 29;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(180, 195);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(165, 22);
            this.cityTextBox.TabIndex = 30;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(180, 321);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(165, 22);
            this.emailTextBox.TabIndex = 31;
            // 
            // SearchProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 681);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addProv);
            this.Controls.Add(this.DeleteProvBtn);
            this.Controls.Add(this.UpdateProvBtn);
            this.Controls.Add(this.clearTxtBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(zipLabel);
            this.Controls.Add(stateLabel);
            this.Controls.Add(cityLabel);
            this.Controls.Add(streetLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.SearchProviderBtn);
            this.Controls.Add(this.providersDataGridView);
            this.Controls.Add(this.providersBindingNavigator);
            this.Name = "SearchProvider";
            this.Text = "Provider Records";
            this.Load += new System.EventHandler(this.SearchProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingNavigator)).EndInit();
            this.providersBindingNavigator.ResumeLayout(false);
            this.providersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DatabaseCADataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private DatabaseCADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator providersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton providersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView providersDataGridView;
        private System.Windows.Forms.Button SearchProviderBtn;
        private System.Windows.Forms.Button clearTxtBox;
        private System.Windows.Forms.Button UpdateProvBtn;
        private System.Windows.Forms.Button DeleteProvBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button addProv;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}