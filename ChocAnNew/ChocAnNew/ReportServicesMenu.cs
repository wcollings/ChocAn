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
                command.Parameters.AddWithValue("@p", Int32.Parse(proIDTxtBox.Text));
                command.Parameters.AddWithValue("@m", Int32.Parse(memIDTxtBox.Text));
                command.Parameters.AddWithValue("@code", Int32.Parse(servCodeTxtBox.Text));
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
    }
}
