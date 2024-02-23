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

namespace DVDL.Applications
{
    public partial class frmEditApplicationType : Form
    {
        private clsApplicationType _ApplicationType;
        public frmEditApplicationType(clsApplicationType ApplicationType)
        {
            InitializeComponent();
            _ApplicationType = ApplicationType;
        }
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            lbID.Text = _ApplicationType.ID.ToString();
            txtTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtFees.Text = _ApplicationType.Fees.ToString();
            _ApplicationType.Mode = clsApplicationType.enApplicationTypeMode.Update;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFees.Text.Trim() == "" || txtTitle.Text.Trim() == "") { MessageBox.Show(" Application Update Failed"); return; }
            _ApplicationType.ApplicationTypeTitle = txtTitle.Text;
            _ApplicationType.Fees =Convert.ToDecimal(txtFees.Text);
            if (_ApplicationType.Save())
            {
                MessageBox.Show("Application Updated Sucessfuly");
            }
            else MessageBox.Show(" Application Update Failed");

        }
        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar);
        }
    }
}
