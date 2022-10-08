using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Organizer.GUI
{
    public partial class frmEditAndSeeInfos : Form
    {
        public frmEditAndSeeInfos()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtInputedFamilyName.Text == "")
                errorProvider1.SetError(txtInputedFamilyName, "نام فامیلی الزامیست");
            else
                errorProvider1.SetError(txtInputedFamilyName, "");

            if (txtInputedFirstName.Text == "")
                errorProvider1.SetError(txtInputedFirstName, "نام کوچک الزامیست");
            else
                errorProvider1.SetError(txtInputedFirstName, "");
        }
    }
}
