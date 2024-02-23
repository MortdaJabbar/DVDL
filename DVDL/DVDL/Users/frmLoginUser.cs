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
    public partial class frmLoginUser : Form
    {

        public frmLoginUser()
        {
            InitializeComponent();
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text.Trim() == "") { e.Cancel = true; errorProvider1.SetError(txtUserName, "UserName is Required"); }
            else errorProvider1.SetError(txtUserName, null);
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() == "") { e.Cancel = true; errorProvider1.SetError(txtPassword, "Password is Required"); }
            else errorProvider1.SetError(txtPassword, null);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!clsUser.isUserExsist(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show(" User Information is wrong ", "incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUserName.Clear();
                ckRememberMe.Checked = false;
                return;
            }
            Global.CurrentUser = clsUser.FindUserByUserNameAndPassword(txtUserName.Text, txtPassword.Text);

            if (!Global.CurrentUser.isActive)
            {
                txtUserName.Focus();
                MessageBox.Show("User Is Not Active, Please Contact Your admin", "Not Active");
                return;
            }

            if (ckRememberMe.Checked)
            {
                Global.StoreUserInfoInFile(txtUserName.Text, txtPassword.Text);

            }
            else { Global.StoreUserInfoInFile("", ""); }
            


            this.Hide();
            MainForm m = new MainForm(this);
            m.ShowDialog();
           

        }
        private void frmLoginUser_Load(object sender, EventArgs e)
        {
            ActiveControl = lbTitle;
            
            string UserName = "", Password = "";
          
                if (Global.GetStoredUser(ref UserName, ref Password))
                {
                    txtUserName.Text = UserName;
                    txtPassword.Text = Password;
                ckRememberMe.Enabled = true;
                }

            else { txtUserName.Clear(); txtPassword.Clear(); ckRememberMe.Checked = false; Global.StoreUserInfoInFile("", ""); }

        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    
    }
}
