namespace ChocAnNew
{
    partial class MemberReportt
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
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label emailLabel;
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new ChocAnNew.DatabaseCADataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.consTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.memGrid = new System.Windows.Forms.DataGridView();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseCADataSet
            // 
            this.databaseCADataSet.DataSetName = "DatabaseCADataSet";
            this.databaseCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.databaseCADataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProviderDirectoryTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.ServiceRecordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChocAnNew.DatabaseCADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(35, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(36, 26);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(132, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(279, 32);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(35, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(77, 26);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(132, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(279, 32);
            this.nameTextBox.TabIndex = 4;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetLabel.Location = new System.Drawing.Point(35, 107);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(76, 26);
            streetLabel.TabIndex = 5;
            streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(132, 104);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(279, 32);
            this.streetTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(35, 142);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(56, 26);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(132, 139);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(279, 32);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(35, 179);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(69, 26);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "State", true));
            this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Location = new System.Drawing.Point(132, 176);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(279, 32);
            this.stateTextBox.TabIndex = 10;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipLabel.Location = new System.Drawing.Point(35, 224);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(48, 26);
            zipLabel.TabIndex = 11;
            zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Zip", true));
            this.zipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(132, 221);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(279, 32);
            this.zipTextBox.TabIndex = 12;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(35, 263);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(80, 26);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Status:";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.membersBindingSource, "Status", true));
            this.statusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(132, 259);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(279, 33);
            this.statusCheckBox.TabIndex = 14;
            this.statusCheckBox.Text = "checkBox1";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reasonLabel.Location = new System.Drawing.Point(35, 305);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(93, 26);
            reasonLabel.TabIndex = 15;
            reasonLabel.Text = "Reason:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Reason", true));
            this.reasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonTextBox.Location = new System.Drawing.Point(132, 302);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.ReadOnly = true;
            this.reasonTextBox.Size = new System.Drawing.Size(279, 32);
            this.reasonTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(35, 346);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(74, 26);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(132, 343);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(279, 32);
            this.emailTextBox.TabIndex = 18;
            // 
            // consTxtBox
            // 
            this.consTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consTxtBox.Location = new System.Drawing.Point(222, 613);
            this.consTxtBox.Name = "consTxtBox";
            this.consTxtBox.ReadOnly = true;
            this.consTxtBox.Size = new System.Drawing.Size(228, 32);
            this.consTxtBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Total consultations";
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.Location = new System.Drawing.Point(222, 575);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(228, 32);
            this.TotalTxtBox.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Total fees";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(939, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 47;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // memGrid
            // 
            this.memGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memGrid.Location = new System.Drawing.Point(40, 404);
            this.memGrid.Name = "memGrid";
            this.memGrid.RowTemplate.Height = 28;
            this.memGrid.Size = new System.Drawing.Size(985, 150);
            this.memGrid.TabIndex = 52;
            // 
            // MemberReportt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 666);
            this.Controls.Add(this.memGrid);
            this.Controls.Add(this.consTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "MemberReportt";
            this.Text = "MemberReportt";
            this.Load += new System.EventHandler(this.MemberReportt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseCADataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private DatabaseCADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox consTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView memGrid;
    }
}