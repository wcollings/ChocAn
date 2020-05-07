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
            // TODO: This line of code loads data into the 'databaseCADataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.FillById(this.databaseCADataSet.Providers, Id);
            populateReport();
        }

        private void populateReport()
        {
            string query = "SELECT  b.ServiceDate, b.CurrentDateAndTime as TimeReceived, d.Id as MemberNumber, d.Name as MemberName, c.ServiceName, c.Fee FROM Providers a " +
                            "INNER JOIN ServiceRecord b ON b.ProviderId = a.Id " +
                            "INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id " +
                            "INNER JOIN Members d ON d.Id = b.MemberId " +
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void providersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCADataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
