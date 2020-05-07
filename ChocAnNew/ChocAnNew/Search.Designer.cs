using System;
using System.Drawing.Text;

namespace ChocAnNew
{
    partial class Search
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
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.RichTextBox();
            this.search_cancel = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(72, 49);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(82, 25);
            this.searchLbl.TabIndex = 0;
            this.searchLbl.Text = "Enter ID";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(172, 49);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(355, 37);
            this.searchTxtBox.TabIndex = 1;
            this.searchTxtBox.Text = "";
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // search_cancel
            // 
            this.search_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_cancel.Location = new System.Drawing.Point(357, 95);
            this.search_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.search_cancel.Name = "search_cancel";
            this.search_cancel.Size = new System.Drawing.Size(171, 42);
            this.search_cancel.TabIndex = 3;
            this.search_cancel.Text = "Cancel";
            this.search_cancel.UseVisualStyleBackColor = true;
            this.search_cancel.Click += new System.EventHandler(this.search_cancel_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(172, 95);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(171, 42);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 212);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.search_cancel);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.searchLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.RichTextBox searchTxtBox;
        private System.Windows.Forms.Button search_cancel;
        private System.Windows.Forms.Button submitBtn;
        private DatabaseCADataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private DatabaseCADataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}