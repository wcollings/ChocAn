using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnNew; //You need this to access the interfaces unless it's calling itself. Then you use "this" 

namespace ChocAnNew
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.ServiceRecord' table. You can move, or remove it, as needed.
            this.serviceRecordTableAdapter.Fill(this.databaseCADataSet.ServiceRecord);
            // TODO: This line of code loads data into the 'databaseCADataSet.Members' table. You can move, or remove it, as needed.
       

        }

        private void serviceRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCADataSet);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuAdmin admin = new MainMenuAdmin(); //creates an instance
            admin.Show(); //this is how you show the interface.
        }

        private void providerMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenuProvider provider = new MainMenuProvider();
            provider.Show();
        }
    }
}
