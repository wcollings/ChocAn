//Written by Evelyn Fitzpatrick

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
using System.Text.RegularExpressions;

namespace ChocAnNew
{
    public partial class MemberRecords : Form
    {
        //Global Vars
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql; //This is the SQL Connection <3
        public MemberRecords()
        {
            InitializeComponent();
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

        public void loadMembersTable()
        {
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * from Members", connectionSql))
            {
                connectionSql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                membersDataGrid1.DataSource = dt;
            }
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            string email, address, name, city, state, zip;
            bool add = true;
            //Initialize
            name = this.nameTxtBox.Text;
            email = this.emailTxtBox.Text;
            address = this.addressTxtBox.Text;
            city = this.cityTxtBox.Text;
            state = this.stateTxtBox.Text;
            zip = this.zipTxtBox.Text;

            System.Text.RegularExpressions.Regex nameCheck = new System.Text.RegularExpressions.Regex(@"[^0-9]");
            System.Text.RegularExpressions.Regex emailCheck = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Regex addressCheck = new System.Text.RegularExpressions.Regex(@"\d+ \w*.? ?[A-Za-z0-9 ]+");
            System.Text.RegularExpressions.Regex cityCheck = new System.Text.RegularExpressions.Regex(@"\w+");
            System.Text.RegularExpressions.Regex stateCheck = new System.Text.RegularExpressions.Regex(@"\w+");
            System.Text.RegularExpressions.Regex zipCheck = new System.Text.RegularExpressions.Regex(@"\d{5}(-\d{3,7})?");

            if (!nameCheck.IsMatch(name))
            {
                MessageBox.Show("Name is not valid. Please Try again");
                add = false;
            }
            if (!emailCheck.IsMatch(email))
            {
                MessageBox.Show("Email is not valid. Please try again");
                add = false;
            }
            if (!addressCheck.IsMatch(address))
            {
                MessageBox.Show("Address is not valid. PLease try again");
                add = false;
            }
            if (!cityCheck.IsMatch(city))
            {
                MessageBox.Show("City is not valid. PLease try again");
                add = false;
            }
            if (!stateCheck.IsMatch(state))
            {
                MessageBox.Show("State is not Valid. Please try again");
                add = false;
            }
            if (!zipCheck.IsMatch(zip))
            {
                MessageBox.Show("Zip code is not valid. Please try again");
                add = false;
            }    
            if (add)
            {
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

                    MessageBox.Show("Member Added");
                    loadMembersTable();
                }
            }
        }

        private void addressTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void membersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            membersDataGrid1.CurrentRow.Selected = true;
            idTextBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].FormattedValue.ToString();
            nameTxtBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].FormattedValue.ToString();
            addressTxtBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].FormattedValue.ToString();
            cityTxtBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].FormattedValue.ToString();
            stateTxtBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].FormattedValue.ToString();
            zipTxtBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].FormattedValue.ToString();
            emailTxtBox.Text = membersDataGrid1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"].FormattedValue.ToString();
        }
    }
}
