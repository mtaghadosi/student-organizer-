using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Organizer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "باید تعداد کل دانشجویان را نمایش دهد";
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (rdoNewRegistration.Checked == true)
            {
                GUI.frmStudentInfo newfrm = new Student_Organizer.GUI.frmStudentInfo();
                newfrm.ShowDialog(this);
            }
            else if (rdoEdit.Checked == true)
            {
                GUI.frmEditAndSeeInfos edt = new Student_Organizer.GUI.frmEditAndSeeInfos();
                edt.ShowDialog(this);
            }
            else if (rdoConfirmNewClass.Checked == true)
            {
                GUI.NewClass fr = new Student_Organizer.GUI.NewClass();
                fr.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("لطفا یک گزینه را انتخاب کنید", "یک گزینه را انتخاب کنید", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("آیا واقعا می خواهید از نرم افزار خارج شوید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (DialogResult == DialogResult.No)
                e.Cancel = true;
        }
    }
}
