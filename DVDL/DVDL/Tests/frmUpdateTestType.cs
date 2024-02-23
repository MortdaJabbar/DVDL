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

namespace DVDL.Tests
{
    public partial class frmUpdateTestType : Form
    {
        private clsTestType _TestType;
        public frmUpdateTestType(clsTestType testType)
        {
            InitializeComponent();
            _TestType = testType;
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (Title.Text.Trim() == "") { errorProvider1.SetError(txt, $"{txt.Name} Is Requierd"); }
            else { errorProvider1.SetError(Title, null); }
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            lbID.Text = _TestType.ID.ToString();
            txtFees.Text = _TestType.Fees.ToString();
            Title.Text = _TestType.Title;
            Description.Text = _TestType.Description;
            _TestType.Mode = clsTestType.enMode.Update;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some Input is not valid"); return;
            }

            _TestType.Title = Title.Text;
            _TestType.Description = Description.Text;
            _TestType.Fees = Convert.ToDecimal(txtFees.Text);
            
            if (_TestType.Save())
            {
                MessageBox.Show("Update Done Succesfully");
            }
            else { MessageBox.Show("Failed"); this.Close(); }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
