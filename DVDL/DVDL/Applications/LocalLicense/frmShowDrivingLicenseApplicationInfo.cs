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

namespace DVDL.Applications.LocalLicense
{
    public partial class frmShowDrivingLicenseApplicationInfo : Form
    {
        int _LocalDrivingLicenseApplicationID = -1;

        public frmShowDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmShowDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {

            if (!clsLocalDrivingLicense.IsLocalDrivingLiceseApplicationExsist(_LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("There is No Local Driving License Application");
                this.Close();
                return;
                
            }

            ctrLocalDrivingLicenseCard1.LoadLocalDrivingLicenseInfo(_LocalDrivingLicenseApplicationID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
