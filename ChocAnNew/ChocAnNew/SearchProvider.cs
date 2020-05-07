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
        }

        private void SearchProvider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.databaseCADataSet.Providers);

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

            String query = ("UPDATE Providers SET Name = @ProvidersName, @ProvidersStreet, @ProvidersCity, @ProvidersZip, @ProvidersEmail");
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
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

                try
                {

                    command.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {

                }
               

                MessageBox.Show("Successfully Updated");
            }
        }
    }
}
