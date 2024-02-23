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
    public partial class frmShowLicenseInfo : Form
    {
        private int _LicenseID = -1;
        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_LicenseID != -1) 
            {
                ctrDrivingLicenseInfo1.FillLicenseInfo(_LicenseID);
            }
        }
    }
}
