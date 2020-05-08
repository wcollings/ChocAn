using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnNew
{
    public partial class MainMenuManager : Form
    {
        public MainMenuManager()
        {
            InitializeComponent();
        }

        private void MainMenuManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCADataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.databaseCADataSet.Members);
            // TODO: This line of code loads data into the 'databaseCADataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.databaseCADataSet.Providers);

        }

        private void AccPayBt_Click(object sender, EventArgs e)
        {
            AccountPayableSummaryReport acc = new AccountPayableSummaryReport();
            acc.Show();
        }

        private void provBt_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(ProvComboBox.SelectedValue.ToString());
            ProviderReport providerReport = new ProviderReport(id);
            providerReport.Show();
        }

        private void memBt_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(MemComboBox.SelectedValue.ToString());
            MemberReportt memberReportt = new MemberReportt(id);
            memberReportt.Show();
        }
    }
}
