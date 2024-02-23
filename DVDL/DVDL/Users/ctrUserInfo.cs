using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLBussinesLogicTier;
namespace DVDL.Users
{
    public partial class ctrUserInfo : UserControl
    {
        public ctrUserInfo()
        {
            InitializeComponent();    
        }
        public void ResetInfo()
        {
            ctrPersonInfo1.ResetInfo();
            lbUserName.Text = lbUserID.Text = lbIsActive.Text = "???";
        }
        public void LoadUserInfo(int UserID)
        {
            clsUser User = clsUser.FindUserByUserID(UserID);

            if (User != null)
            {
                ctrPersonInfo1.LoadPersonInfo(User.Person.PersonID);
                lbUserID.Text = User.UserID.ToString();
                lbUserName.Text = User.UserName;
                lbIsActive.Text = (User.isActive)?"Yes":"No";

            }
            else ResetInfo();
        }
        private void ctrUserInfo_Load(object sender, EventArgs e)
        {
            ResetInfo();
        }

        public void DisableFilter() { groupBox1.Enabled = false; }
    
    }
}
