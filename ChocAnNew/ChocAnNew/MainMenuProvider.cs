using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnNew;

namespace ChocAnNew
{
    public partial class MainMenuProvider : Form
    {
        public MainMenuProvider()
        {
            InitializeComponent();
        }

        private void valMemBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search("view member");
            search.Show();
        }

        private void rptServBtn_Click(object sender, EventArgs e)
        {
            ReportServicesMenu report = new ReportServicesMenu();
            report.Show();
           
        }

        private void accProDirBtn_Click(object sender, EventArgs e)
        {
            ViewProviderDirectory PD = new ViewProviderDirectory();
            PD.Show();
        }

        private void genProRptBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search("provider id");
            search.Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
