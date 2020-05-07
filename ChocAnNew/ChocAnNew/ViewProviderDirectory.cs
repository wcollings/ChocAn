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
    public partial class ViewProviderDirectory : Form
    {
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql;

        public ViewProviderDirectory()
        {
            InitializeComponent();
        }

        private void ViewProviderDirectory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.ProviderDirectory' table. You can move, or remove it, as needed.
            this.providerDirectoryTableAdapter.Fill(this.databaseCADataSet.ProviderDirectory);

        }

        private void UpdateProviderDir_Click(object sender, EventArgs e)
        {
           /* string query = "UPDATE ";
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
            }*/
        }
    }
}
