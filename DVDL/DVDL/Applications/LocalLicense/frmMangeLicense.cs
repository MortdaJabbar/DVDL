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
    public partial class frmMangeLicense : Form
    {

        private DataTable _All = clsLicense.GetAllLicenses();
        public frmMangeLicense()
        {
            InitializeComponent();
        }

        private void _FillLicneseInfoInTable(DataTable dt)
        {
            dgvLicenses.DataSource = dt;
            lbTotalRecords.Text = dgvLicenses.RowCount.ToString();
        }

        private void frmMangeLicense_Load(object sender, EventArgs e)
        {
            _FillLicneseInfoInTable(_All);
        }
    }
}
