namespace ChocAnNew
{
    partial class MainMenuManager
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
            this.AccPayBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.memBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MemComboBox = new System.Windows.Forms.ComboBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCADataSet = new ChocAnNew.DatabaseCADataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProvComboBox = new System.Windows.Forms.ComboBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.providersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.ProvidersTableAdapter();
            this.membersTableAdapter = new ChocAnNew.DatabaseCADataSetTableAdapters.MembersTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccPayBt
            // 
            this.AccPayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccPayBt.Location = new System.Drawing.Point(159, 40);
            this.AccPayBt.Name = "AccPayBt";
            this.AccPayBt.Size = new System.Drawing.Size(435, 43);
            this.AccPayBt.TabIndex = 0;
            this.AccPayBt.Text = "Accounts Payable Summary Reports";
            this.AccPayBt.UseVisualStyleBackColor = true;
            this.AccPayBt.Click += new System.EventHandler(this.AccPayBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member Name: ";
            // 
            // memBt
            // 
            this.memBt.Location = new System.Drawing.Point(517, 31);
            this.memBt.Name = "memBt";
            this.memBt.Size = new System.Drawing.Size(191, 40);
            this.memBt.TabIndex = 2;
            this.memBt.Text = "Get Report";
            this.memBt.UseVisualStyleBackColor = true;
            this.memBt.Click += new System.EventHandler(this.memBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MemComboBox);
            this.groupBox1.Controls.Add(this.memBt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Individual Report";
            // 
            // MemComboBox
            // 
            this.MemComboBox.DataSource = this.membersBindingSource;
            this.MemComboBox.DisplayMember = "Name";
            this.MemComboBox.FormattingEnabled = true;
            this.MemComboBox.Location = new System.Drawing.Point(198, 43);
            this.MemComboBox.Name = "MemComboBox";
            this.MemComboBox.Size = new System.Drawing.Size(244, 34);
            this.MemComboBox.TabIndex = 15;
            this.MemComboBox.ValueMember = "Id";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProvComboBox);
            this.groupBox2.Controls.Add(this.provBt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provider Individual Report";
            // 
            // ProvComboBox
            // 
            this.ProvComboBox.DataSource = this.providersBindingSource;
            this.ProvComboBox.DisplayMember = "Name";
            this.ProvComboBox.FormattingEnabled = true;
            this.ProvComboBox.Location = new System.Drawing.Point(198, 44);
            this.ProvComboBox.Name = "ProvComboBox";
            this.ProvComboBox.Size = new System.Drawing.Size(244, 34);
            this.ProvComboBox.TabIndex = 14;
            this.ProvComboBox.ValueMember = "Id";
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.databaseCADataSet;
            // 
            // provBt
            // 
            this.provBt.Location = new System.Drawing.Point(517, 40);
            this.provBt.Name = "provBt";
            this.provBt.Size = new System.Drawing.Size(191, 42);
            this.provBt.TabIndex = 2;
            this.provBt.Text = "Get Report";
            this.provBt.UseVisualStyleBackColor = true;
            this.provBt.Click += new System.EventHandler(this.provBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provider Name: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AccPayBt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Summary Report";
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenuManager";
            this.Text = "MainMenuManager";
            this.Load += new System.EventHandler(this.MainMenuManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCADataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccPayBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button memBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button provBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ProvComboBox;
        private DatabaseCADataSet databaseCADataSet;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DatabaseCADataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.ComboBox MemComboBox;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseCADataSetTableAdapters.MembersTableAdapter membersTableAdapter;
    }
}