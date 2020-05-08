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
    public partial class MemberReportt : Form
    {
        int Id;
        string connectionString;
        SqlConnection connectionSql;

        public MemberReportt(int id)
        {
            InitializeComponent();
            Id = id;
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCADataSet);
            

        }

        private void MemberReportt_Load(object sender, EventArgs e)
        {
            this.membersTableAdapter.FillById(this.databaseCADataSet.Members, Id);
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            string query = "SELECT  b.ServiceDate, d.Name as ProviderNumber, c.ServiceName, c.Fee FROM Members a " +
                            "INNER JOIN ServiceRecord b ON b.MemberId = a.Id " +
                            "INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id " +
                            "INNER JOIN Providers d ON d.Id = b.ProviderId " +
                            "WHERE a.Id = @id";
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", Id);
                DataTable memberReportTable = new DataTable();
                adapter.Fill(memberReportTable);
                memGrid.DataSource = memberReportTable;

                //Totals
                Object totalO, totalcons;
                totalO = memberReportTable.Compute("Sum(Fee)", "");
                TotalTxtBox.Text = totalO.ToString();
                totalcons = memberReportTable.Compute("COUNT(Fee)", "");
                consTxtBox.Text = totalcons.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


