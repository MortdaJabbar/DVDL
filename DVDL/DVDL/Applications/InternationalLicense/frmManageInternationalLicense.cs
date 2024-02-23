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

namespace DVDL
{
    public partial class frmManageInternationalLicense : Form
    {
        private DataTable _All = clsInternationalLicense.GetAllInternationalLicenseFormated();
        public frmManageInternationalLicense()
        {
            InitializeComponent();
        }
        private void _FillInternaionalLicenseinTable(DataTable dt)
        {

            dgvInternaionalLicenses.DataSource = dt;
            lbTotalRecords.Text = dgvInternaionalLicenses.RowCount.ToString();
        }

        private void frmManageInternationalLicense_Load(object sender, EventArgs e)
        {
            _FillInternaionalLicenseinTable(_All);
        }
    }
}
