﻿//Written by Evelyn Fitzpatrick

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ChocAnNew
{
    public partial class AddMemberMenu : Form
    {
        //Global Vars
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql; //This is the SQL Connection <3
        public AddMemberMenu()
        {
            InitializeComponent();
            //Connection string is necessary to connect to the database
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
            //connectionString = ConfigurationManager.ConnectionStrings["ChocAnon.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCADataSet);

        }

        private void AddMemberMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.Members' table. You can move, or remove it, as needed.

                this.membersTableAdapter.Fill(this.databaseCADataSet.Members);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //This is where we need to grab the data and add it into the database

            //Vars
            bool status = true;
            string email, address, name, city, state, zip, reason;

            //Initialize
            name = this.nameTxtBox.Text;
            email = this.emailTxtBox.Text;
            address = this.addressTxtBox.Text;
            city = this.cityTxtBox.Text;
            state = this.stateTxtBox.Text;
            zip = this.zipTxtBox.Text;
            reason = " ";

            string query = "INSERT INTO Members(Name, Street, City, State, Zip, Email) VALUES (@MembersName, @MembersStreet, @MembersCity, @MembersState, @MembersZip, @MembersEmail)";

            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@MembersName", name);
                command.Parameters.AddWithValue("@MembersStreet", address);
                command.Parameters.AddWithValue("@MembersCity", city);
                command.Parameters.AddWithValue("@MembersState", state);
                command.Parameters.AddWithValue("@MembersZip", zip);
                command.Parameters.AddWithValue("@MembersEmail", email);
                command.ExecuteScalar();
            }

        }

        private void addressTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
