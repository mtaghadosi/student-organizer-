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
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Check_Errors();
            
        }

        private void Check_Errors()
        {
            if (txtFirstName.Text == "")
                errorProvider1.SetError(txtFirstName, "نام الزامیست");
            else
                errorProvider1.SetError(txtFirstName, "");
            if (txtFamilyName.Text == "")
                errorProvider1.SetError(txtFamilyName, "نام خانوادگی الزامیست");
            else
                errorProvider1.SetError(txtFamilyName, "");
            if (txtAddress.Text == "")
                errorProvider1.SetError(txtAddress, "آدرس الزامیست");
            else
                errorProvider1.SetError(txtAddress, "");
            if (cmbSelectedField.Text == "")
                errorProvider1.SetError(cmbSelectedField, "انتخاب رشته الزامیست");
            else
                errorProvider1.SetError(cmbSelectedField, "");
            if (txtSessionNumber.Text == "")
                errorProvider1.SetError(txtSessionNumber, "مشخص کردن تعداد جلسات الزامیست");
            else
                errorProvider1.SetError(txtSessionNumber, "");
            if (txtHoursNumber.Text == "")
                errorProvider1.SetError(txtHoursNumber, "مشخص کردن تعداد ساعات الزامیست");
            else
                errorProvider1.SetError(txtHoursNumber, "");
            if (txttotalMoney.Text == "")
                errorProvider1.SetError(txttotalMoney, "مشخص کردن مبلغ کل قابل پرداخت الزامیست");
            else
                errorProvider1.SetError(txttotalMoney, "");
        }
    }
}
