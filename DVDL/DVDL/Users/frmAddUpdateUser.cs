using DVDLBussinesLogicTier;
using Microsoft.VisualBasic;
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
    public partial class frmAddUpdateUser : Form
    {
        private enum FormMode { AddNewUser = 1, UpdateUser = 2 };
        private FormMode _mode;
        private int _UserID = -1;
        private clsUser _User;
        private clsPerson _Person = new clsPerson();
        public delegate void DataBackHandler(object sender, int PersonID);
        public event DataBackHandler DataBack;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _mode = FormMode.AddNewUser;
            _UserID = -1;
            _Person = null;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _mode = FormMode.UpdateUser;
            _UserID = UserID;
        }
        private void _FillFormWithUserInfo(int UserID)
        {
            lbTitle.Text = "Update User";
            _User = clsUser.FindUserByUserID(UserID);

            if (_User != null)
            {
                lbUserID.Text = _User.UserID.ToString();
                txtUserName.Text = _User.UserName;
                txtPassword.Text = _User.Password;
                txtConfirmPassword.Text = _User.Password;
                chkisActive.Checked = _User.isActive;
                _User.Mode = clsUser.enMode.UpdateUser;
                ctrPersonInfoWithFilter1.FillPersonInfo(_User.Person.PersonID);
                _Person = ctrPersonInfoWithFilter1.Person;

                ctrPersonInfoWithFilter1.DisableFilter();

            }
            else _ResetInfo();
        }
        private void _ResetInfo()
        {
            lbTitle.Text = "Add User";
            txtUserName.Text = txtPassword.Text = txtConfirmPassword.Text = string.Empty;
            lbUserID.Text = "???";
            ctrPersonInfoWithFilter1.ResetInfo();
            _mode = FormMode.AddNewUser;
            _Person = null;
            (Tabs.TabPages["UserInfoTab"]).Enabled = false;

        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_mode == FormMode.UpdateUser)
            {
                _FillFormWithUserInfo(_UserID);

            }

            else
            {
                _ResetInfo();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Person != null) { (Tabs.TabPages["UserInfoTab"]).Enabled = true; }

            Tabs.SelectedTab = Tabs.TabPages["UserInfoTab"];
        }
        private void txtPassword_Validation(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Requeried");
            }
            else if (!clsValidation.isValidPassword(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Should Be at least 8 digit with small,capital and special chars");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }

        }
        private void txtConfirmPassword_Validation(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password Requeried");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Did not Match");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

        }
        private void txtUserName_Validation(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtUserName.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "UserName Should Be More Than 3 chars");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Input Filed is Not Valid");
                return;
            }

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.isActive = chkisActive.Checked;
            _User.Person = _Person;
            _User.Mode = (clsUser.enMode)_mode;

            if (_User.Save())
            {
                lbTitle.Text = "Update User";
                lbUserID.Text = _User.UserID.ToString();
                txtUserName.Text = _User.UserName;
                txtPassword.Text = txtConfirmPassword.Text = _User.Password;
                MessageBox.Show("Operation Done Successfuly");
                DataBack?.Invoke(this, _User.UserID);

            }
            else
            {
                MessageBox.Show("Operation is Failed Please Check Inputs And Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ctrPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            int PersonID = obj;
            _User = clsUser.FindUserByPersonID(PersonID);

            if (_User != null)
            {
                lbUserID.Text = _User.UserID.ToString();
                txtUserName.Text = _User.UserName;
                txtPassword.Text = _User.Password;
                txtConfirmPassword.Text = _User.Password;
                chkisActive.Checked = _User.isActive;
                lbTitle.Text = "Update User";
                _mode = FormMode.UpdateUser;

            }
            else { _User = new clsUser(); }

            MessageBox.Show($"You Select A Person With PersonID: {PersonID} ");
            (Tabs.TabPages["UserInfoTab"]).Enabled = true;
        }

        private void ctrPersonInfoWithFilter1_OnPersonAdded(int obj)
        {
            int PersonID = obj;
            MessageBox.Show($"You Select A Person With PersonID: {PersonID} ");
            _Person = clsPerson.FindPersonByID(PersonID);
            _User = new clsUser();
            (Tabs.TabPages["UserInfoTab"]).Enabled = true;
        }
    }
}
