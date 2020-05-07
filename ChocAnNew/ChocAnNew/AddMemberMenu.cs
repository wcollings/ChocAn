//Written by Evelyn Fitzpatrick

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
    public partial class AddMemberMenu : Form
    {
        //Global Vars
        string connectionString; //This is the database configuration location
        SqlConnection connectionSql; //This is the SQL Connection <3
        public AddMemberMenu()
        {
            InitializeComponent();

            //Connection string is necessary to connect to the database

            //This should work, I don't know why it isn't. It's some bullshit.
            //connectionString = ConfigurationManager.ConnectionStrings["ChocAnon.Properties.Settings.DatabaseCAConnectionString"].ConnectionString;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //This is where we need to grab the data and add it into the database
            
            

            //Vars
            bool status = true;
            string email, address, name, city, state, zip, reason;

            //Initialize
            name = this.nameTxtBox.Text;
            email = this.emailTxtBox.Text;
            address = this.addressTxtBox.Text;
            city = this.cityTxtBox.Text;
            state = this.stateTxtBox.Text;
            zip = this.zipTxtBox.Text;
            reason = " ";



        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
