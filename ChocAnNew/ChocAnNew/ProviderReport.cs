using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnNew
{
    public partial class ProviderReport : Form
    {
        int Id;
        string connectionString;
        SqlConnection connectionSql;

        public ProviderReport(int id)
        {
            InitializeComponent();
            Id = id;
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void ProviderReport_Load(object sender, EventArgs e)
        {
            populateReport();
        }

        private void populateReport()
        {
            string query = "SELECT a.Name, b.ServiceDate,c.ServiceName, c.Fee FROM Providers a " +
                            "INNER JOIN ServiceRecord b ON b.ProviderId = a.Id " +
                            "INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id " +
                            "WHERE b.ProviderID = @id ";
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", Id);
                DataTable providerReportTable = new DataTable();
                adapter.Fill(providerReportTable);
                provGrid.DataSource= providerReportTable;
            }
        }
    }
}
