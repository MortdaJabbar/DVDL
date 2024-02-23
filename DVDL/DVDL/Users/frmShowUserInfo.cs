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
    public partial class frmShowUserInfo : Form
    {
        private static clsUser _User = null;

        private static int _UserID = -1;
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            if (_UserID == -1)
            {
                ctrUserInfo1.ResetInfo();
            }
            else
            {
                ctrUserInfo1.LoadUserInfo(_UserID);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
