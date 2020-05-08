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
    public partial class AccountPayableSummaryReport : Form
    {
        string connectionString;
        SqlConnection connectionSql;

        public AccountPayableSummaryReport()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void AccountPayableSummaryReport_Load(object sender, EventArgs e)
        {
            PopulateAccGrid();
        }

        private void PopulateAccGrid()
        {
            string query = "SELECT  a.Name as ProviderName, COUNT(b.ServiceCode) As NumberOfConsultation, SUM(c.Fee) AS TotalFees FROM Providers a " +
                            "INNER JOIN ServiceRecord b ON b.ProviderId = a.Id " +
                            "INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id " +
                            "GROUP BY a.Name";
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            { 
                DataTable AccPayTable = new DataTable();
                adapter.Fill(AccPayTable);
                accPayGrid.DataSource = AccPayTable;

                //Totals
                Object totalProvObj,totalFeeObj, totalConsObj;
                totalProvObj = AccPayTable.Compute("COUNT(ProviderName)","");
                provTextBox.Text = totalProvObj.ToString();
                totalFeeObj = AccPayTable.Compute("SUM(TotalFees)", "");
                TotalFeeTxtBox.Text = totalFeeObj.ToString();
                totalConsObj = AccPayTable.Compute("SUM(NumberOfConsultation)", "");
                ConstextBox.Text = totalConsObj.ToString();
            }
        }
    }
}
