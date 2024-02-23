using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.Users
{
    public partial class frmChangePassword : Form
    {
        private static clsUser _User = null;
       
        private int _UserID = -1;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.FindUserByUserID(_UserID);
            if (_User != null)
            {
                ctrUserInfo1.LoadUserInfo(_UserID);
            }
            else { MessageBox.Show("There Is No User ", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPassword.Text == "") { e.Cancel = true; errorProvider1.SetError(txtCurrentPassword, "Current Password Required"); }
            else if (txtCurrentPassword.Text == _User.Password)
            {
                e.Cancel = true; errorProvider1.SetError(txtCurrentPassword, "Current Password Not Correct");

            }

        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text == "") { e.Cancel = true; errorProvider1.SetError(txtNewPassword, "New Password Required"); }
            else if (!clsValidation.isValidPassword(txtNewPassword.Text))
            {
                e.Cancel = true; errorProvider1.SetError(txtNewPassword, "New Password Should Be at Leats 8 digit small,capital,special char");
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text == "") { e.Cancel = true; errorProvider1.SetError(txtConfirmPassword, "Confirm Password Required"); }
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                e.Cancel = true; errorProvider1.SetError(txtConfirmPassword, "Confirm Password Did not match New Password");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) { MessageBox.Show("Some Inputs is not valid"); return; }

            _User.Password = txtNewPassword.Text;
            
            if (_User.ChangePassword()) { MessageBox.Show("Password Changed Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Password Update Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
