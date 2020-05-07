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
    public partial class ReportServicesMenu : Form

    {
        string connectionString;
        SqlConnection connectionSql;

        public ReportServicesMenu()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ServiceRecord VALUES (@p, @m, @code, @current, @date, @comment)";
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@p", ProvComboBox.SelectedValue);
                command.Parameters.AddWithValue("@m", meMcomboBox.SelectedValue);
                command.Parameters.AddWithValue("@code", serCodeComboBox.SelectedValue);
                command.Parameters.AddWithValue("@current", DateTime.Now);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@comment", commentsTxtBox.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Recored Added!", "Added", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message,"Invalid Input", MessageBoxButtons.OK);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportServicesMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.ProviderDirectory' table. You can move, or remove it, as needed.
            this.providerDirectoryTableAdapter.Fill(this.databaseCADataSet.ProviderDirectory);
            // TODO: This line of code loads data into the 'databaseCADataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.databaseCADataSet.Members);
            // TODO: This line of code loads data into the 'databaseCADataSet.ServiceRecord' table. You can move, or remove it, as needed.
            this.serviceRecordTableAdapter.Fill(this.databaseCADataSet.ServiceRecord);
            // TODO: This line of code loads data into the 'databaseCADataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.databaseCADataSet.Providers);

        }
    }
}
