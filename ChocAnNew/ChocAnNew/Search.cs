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
using ChocAnNew;

namespace ChocAnNew
{
    public partial class Search : Form
    {
        string choice;
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql;
        public Search(string sentChoice)
        {
            InitializeComponent();
            choice = sentChoice;

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case "modify user":
                    //Below needs to be modified to take take from the database and put in the reason, validated bool, and ID number
                    ModifyMemberMenu modMem = new ModifyMemberMenu("This is a reason", true, this.searchTxtBox.Text);
                    modMem.Show();
                    break;
                case "delete user":
                    //Again, we're going to have to modify the below class and do the same thing as modifying the user.
                    DeleteMemberMenu delMem = new DeleteMemberMenu();
                    delMem.Show();
                    break;
                case "modify provider":
                    ModifyProviderMenu modPro = new ModifyProviderMenu();
                    modPro.Show();
                    break;
                case "delete provider":
                    DeleteProviderMenu delPro = new DeleteProviderMenu();
                    delPro.Show();
                    break;
                case "view member":
                    viewMember viewMem = new viewMember();
                    searchMemberById();
                    //viewMem.Show();
                    break;
            }
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * from";
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
            /*using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
            }*/
        }

        private void searchMemberById()
        {
            String query = ("SELECT Name, Status, Reason FROM Members WHERE Id=@id");
            connectionString = ConfigurationManager.ConnectionStrings["ChocAnNew.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
            using (connectionSql = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connectionSql))
            {
                connectionSql.Open();
                command.Parameters.AddWithValue("@id", Int32.Parse(searchTxtBox.Text));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetBoolean(1) == true) {
                                MessageBox.Show(String.Format("{0} is validated!", reader.GetString(0)));
                            }
                            else
                            {
                                MessageBox.Show(String.Format("{0} is Suspended!", reader.GetString(0)));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member Id dose not exits");
                    }
                    reader.Close();
                }
            }
        }
    }
}
