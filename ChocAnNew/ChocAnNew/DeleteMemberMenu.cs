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
    public partial class DeleteMemberMenu : Form
    {
        public DeleteMemberMenu()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this user?", "Delete Member Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //This is where the delete should go.
            }
        }
    }
}
