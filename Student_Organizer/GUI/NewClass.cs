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
    public partial class NewClass : Form
    {
        public NewClass()
        {
            InitializeComponent();
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if (txtDay.Text.Length > 0)
            {
                if (int.Parse(txtDay.Text) > 31)
                {
                    txtDay.Text = "";
                    txtDay.Focus();
                }
            }
        }

        private void txtMounth_TextChanged(object sender, EventArgs e)
        {
            if (txtMounth.Text.Length > 0)
            {
                if (int.Parse(txtMounth.Text) > 12)
                {
                    txtMounth.Text = "";
                    txtMounth.Focus();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
