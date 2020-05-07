using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChocAnNew
{
    public partial class ModifyMemberRecords : Form
    {
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql;

        public ModifyMemberRecords()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
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
                membersdataGridView.DataSource = dt;
            }
        }

        private void ModifyMemberRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.databaseCADataSet.Members);

        }

        private void SearchMemberBtn_Click(object sender, EventArgs e)
        {
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * from Members where Id = @MembersID", connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@MembersID", idMemberTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {

                    MessageBox.Show("ID number does not exist");
                }
                else
                {
                    nameMemberTextBox.Text = dt.Rows[0][1].ToString();
                    streetMemberTextBox.Text = dt.Rows[0][2].ToString();
                    cityMemberTextBox.Text = dt.Rows[0][3].ToString();
                    stateMemberTextBox.Text = dt.Rows[0][4].ToString();
                    zipMemberTextBox.Text = dt.Rows[0][5].ToString();
                    statusCheckBox.Text = dt.Rows[0][6].ToString();
                    commentMemberTextBox.Text = dt.Rows[0][7].ToString();
                    emailMemberTextBox.Text = dt.Rows[0][8].ToString();
                }

            }
        }

        private void UpdateMemBtn_Click(object sender, EventArgs e)
        {
            string email, address, name, city, state, zip, status, comment;
            name = this.nameMemberTextBox.Text;
            email = this.emailMemberTextBox.Text;
            address = this.streetMemberTextBox.Text;
            city = this.cityMemberTextBox.Text;
            state = this.stateMemberTextBox.Text;
            zip = this.zipMemberTextBox.Text;
            status = this.statusCheckBox.Text;
            comment = this.commentMemberTextBox.Text;

            String query = ("UPDATE Members SET Name = @MembersName, Street = @MembersStreet, " +
                "City = @MembersCity, Zip = @MembersZip, Status = @MembersStatus," +
                " Reason = @MembersReason, Email=@MembersEmail WHERE Id = @MembersId");
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@MembersName", name);
                command.Parameters.AddWithValue("@MembersStreet", address);
                command.Parameters.AddWithValue("@MembersCity", city);
                command.Parameters.AddWithValue("@MembersState", state);
                command.Parameters.AddWithValue("@MembersZip", zip);
                command.Parameters.AddWithValue("@MembersStatus", status);
                command.Parameters.AddWithValue("@MembersReason", comment);
                command.Parameters.AddWithValue("@MembersEmail", email);
                command.Parameters.AddWithValue("@MembersId", idMemberTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated");
                loadMembersTable();
            }
        }

        private void DeleteMemberBtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE Members where ID = @MembersId ";
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@MembersId", idMemberTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted");
                loadMembersTable();

            }
        }

        private void clearTxtBox_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = " ";
                }
            }
        }

        private void membersdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            membersdataGridView.CurrentRow.Selected = true;
            idMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].FormattedValue.ToString();
            nameMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].FormattedValue.ToString();
            streetMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["streetDataGridViewTextBoxColumn"].FormattedValue.ToString();
            cityMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["cityDataGridViewTextBoxColumn"].FormattedValue.ToString();
            stateMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["stateDataGridViewTextBoxColumn"].FormattedValue.ToString();
            zipMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["zipDataGridViewTextBoxColumn"].FormattedValue.ToString();
            statusCheckBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["statusDataGridViewcheckBoxColumn"].FormattedValue.ToString();
            commentMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["reasonDataGridViewTextBoxColumn"].FormattedValue.ToString();
            emailMemberTextBox.Text = membersdataGridView.Rows[e.RowIndex].Cells["emailDataGridViewTextBoxColumn"].FormattedValue.ToString();
        }
    }
}
