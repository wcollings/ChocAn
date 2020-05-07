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
    public partial class SearchProvider : Form
    {
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql;

        public SearchProvider()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void SearchProvider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.databaseCADataSet.Providers);

        }
        public void loadProvidersTable()
        {
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * from Providers", connectionSql))
            {
                connectionSql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                providersDataGridView.DataSource = dt;
            }
        }


        private void providersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCADataSet);

        }

        private void SearchProviderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.providersTableAdapter.SearchByName(this.databaseCADataSet.Providers, searchProvText.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void clearTxtBox_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = " ";
                }
            }
        }

        private void UpdateProvBtn_Click(object sender, EventArgs e)
        {
            string email, address, name, city, state, zip;
            name = this.nameTextBox.Text;
            email = this.emailTextBox.Text;
            address = this.streetTextBox.Text;
            city = this.cityTextBox.Text;
            state = this.stateTextBox.Text;
            zip = this.zipTextBox.Text;

            String query = ("UPDATE Providers SET Name = @ProvidersName, Street = @ProvidersStreet, City = @ProvidersCity, Zip = @ProvidersZip, Email = @ProvidersEmail WHERE Id = @ProvidersId");
            //connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@ProvidersName", name);
                command.Parameters.AddWithValue("@ProvidersStreet", address);
                command.Parameters.AddWithValue("@ProvidersCity", city);
                command.Parameters.AddWithValue("@ProvidersState", state);
                command.Parameters.AddWithValue("@ProvidersZip", zip);
                command.Parameters.AddWithValue("@ProvidersEmail", email);
                command.Parameters.AddWithValue("@ProvidersId", idTextBox.Text);
                command.ExecuteNonQuery();
               
                
                MessageBox.Show("Successfully Updated");
                loadProvidersTable();
            }
        }

        private void DeleteProvBtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE Providers where ID = @ProvidersId ";
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@ProvidersId", idTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted");
                loadProvidersTable();

            }
        }

        private void providersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            providersDataGridView.CurrentRow.Selected = true;
            idTextBox.Text = providersDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].FormattedValue.ToString();
            nameTextBox.Text = providersDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].FormattedValue.ToString();
            streetTextBox.Text = providersDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].FormattedValue.ToString();
            cityTextBox.Text = providersDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].FormattedValue.ToString();
            zipTextBox.Text = providersDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].FormattedValue.ToString();
            emailTextBox.Text = providersDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].FormattedValue.ToString();   

        }


    }
}
