using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnNew; //when you want to use one of the fourms you need to import the name space.

namespace ChocAnNew
{
    public partial class MainMenuAdmin : Form
    {
        public MainMenuAdmin()
        {
            InitializeComponent();
        }

        private void addMemBtn_Click(object sender, EventArgs e)
        {
            AddMemberMenu add = new AddMemberMenu();// modify is going to need something in the loading to get the menu.
            add.Show();
        }

        private void modMemBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search("modify user");
           
            search.Show();
        }

        private void delMemBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search("delete user");
            search.Show();
        }

        private void addProBtn_Click(object sender, EventArgs e)
        {
            AddProviderMenu addPro = new AddProviderMenu();
            addPro.Show();
        }

        private void modProBtn_Click(object sender, EventArgs e)
        {
            //Search search = new Search("modify provider");
            SearchProvider search_provider = new SearchProvider();
            search_provider.Show();
            //search.Show();
        }

        private void delProBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search("delete provider");
            search.Show();
        }

        private void modProDirBtn_Click(object sender, EventArgs e)
        {
            ModifyProviderDirectory modProDir = new ModifyProviderDirectory();
            modProDir.Show();
        }

        private void accProDirBtn_Click(object sender, EventArgs e)
        {
            MainMenuProvider viewProv = new MainMenuProvider();
            viewProv.Show();
        }

        private void genManRepBtn_Click(object sender, EventArgs e)
        {
            //This is where we need to put the logic to send the Manager Report
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
