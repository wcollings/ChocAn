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

namespace ChoccAn
{
    public partial class Main : Form
    {
        SqlConnection connection;
        string connectionString;

        public Main()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ChoccAn.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }



        private void Main_Load(object sender, EventArgs e)
        {
            PopulateProvidersList();
        }
        

        private void PopulateProvidersList()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Providers", connection))
            {
                DataTable ProviderDirectoryTable = new DataTable();
                adapter.Fill(ProviderDirectoryTable);

                lstProviders.DisplayMember = "Name";
                lstProviders.ValueMember = "Id";
                lstProviders.DataSource = ProviderDirectoryTable;
            }
        }

        private void lstProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstProviders.SelectedValue.ToString());
            PopulateServices();
        }

        private void PopulateServices()
        {
            string query = "SELECT a.ServiceCode FROM ServiceRecord a " +
                            "INNER JOIN Providers b ON b.Id = a.ProviderId " +
                            "WHERE b.Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", lstProviders.SelectedValue);

                DataTable ProviderServicesTable = new DataTable();
                adapter.Fill(ProviderServicesTable);

                lstServices.DisplayMember = "ServiceCode";
                lstServices.DataSource = ProviderServicesTable;
            }
        }


    }
}
