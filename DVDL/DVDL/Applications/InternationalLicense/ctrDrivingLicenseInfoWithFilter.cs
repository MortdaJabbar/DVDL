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
    public partial class ctrDrivingLicenseInfoWithFilter : UserControl
    {
        private clsLicense _License;
             
        public event Action<int> OnLicenseSelected;
        protected virtual void SelectedLicese(int personID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(personID);
            }

        }
        public bool gbFilterEnable
        {
            get { return gbFilter.Enabled; }
            set { gbFilter.Enabled = value; }
        }
        public clsLicense License { get { return _License; } }
        public ctrDrivingLicenseInfoWithFilter()
        {
            InitializeComponent();
        }


        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {

            int LicenseID = -1 ;

            if (e.KeyData == Keys.Enter)
            {
                if (txtFilter.Text.Trim() == "") { MessageBox.Show("Please Enter LicenseID (-:"); return; }
                if (!clsLicense.IsLicenseExsist(Convert.ToInt32(txtFilter.Text))) { MessageBox.Show("Sorry ,License With This LicenseID Was Not Found )-:"); return; }
                LicenseID = Convert.ToInt32(txtFilter.Text);

                FillLicenesInfo(LicenseID);
            }

        }
       
        public void FillLicenesInfo(int LicenseID)
        {

            _License = clsLicense.GetLicenseByID(LicenseID);
            if (_License != null)
            {
                txtFilter.Text = _License.LicenseID.ToString();
                ctrDrivingLicenseInfo1.FillLicenseInfo(_License.LicenseID);
               if (OnLicenseSelected != null) OnLicenseSelected(LicenseID);


            }
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void pbSearch_Click(object sender, EventArgs e)
        {
            int LicenseID = -1;
            if (txtFilter.Text.Trim() == "") { MessageBox.Show("Please Enter LicenseID (-:"); return; }
            if (!clsLicense.IsLicenseExsist(Convert.ToInt32(txtFilter.Text))) { MessageBox.Show("Sorry ,License With This LicenseID Was Not Found )-:"); return; }
            LicenseID = Convert.ToInt32(txtFilter.Text);

            FillLicenesInfo(LicenseID);

        }
    
    }
}
