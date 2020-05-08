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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuProvider provider = new MainMenuProvider();
            provider.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            MainMenuAdmin admin = new MainMenuAdmin(); //creates an instance
            admin.Show();
        }
    }
}
