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

namespace DVDL.InternationalLicense
{
    public partial class frmShowInternationalLicense : Form
    {
        private int _InternationalLicenseID = -1;
        public frmShowInternationalLicense(int InternationalLicneseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicneseID;
        }

        private void frmShowInternationalLicense_Load(object sender, EventArgs e)
        {
            if (!clsInternationalLicense.IsInternationalLicenseExsist(_InternationalLicenseID))
            {
                MessageBox.Show($"Sorry , No International License With ID {_InternationalLicenseID}");
                this.Close();
            }
            ctrInternationalLicense1.FillLicenseInfo(_InternationalLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
