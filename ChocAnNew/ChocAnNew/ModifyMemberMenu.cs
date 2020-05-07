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
    public partial class ModifyMemberMenu : Form
    {
        public ModifyMemberMenu(string reason, bool validated, string id) //Either this has to be modified to take in all vars
        {
            InitializeComponent();
            this.validatedCheckBox.Checked = true;
            this.reasonTxtBox.Text = reason;
            this.validatedCheckBox.Checked = validated;
            this.IDTxtBox.Text = id;
            //Or this will have to pull the rest of the information currently in the database here.
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
