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
    public partial class frmManageApplicationTypes : Form
    {
        private clsApplicationType _ApplicationType;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            _ApplicationType = new clsApplicationType();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationList();
        }
        private void _RefreshApplicationList()
        {
            DataTable _AllApplications = clsApplicationType.GetAllApplicationsTypes();
            dataGridView1.DataSource = _AllApplications;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Fees";
            lbTotalRecords.Text = dataGridView1.RowCount.ToString();

        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ApplicationType.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _ApplicationType.Fees = (Decimal)dataGridView1.CurrentRow.Cells[2].Value;
            _ApplicationType.ApplicationTypeTitle = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            frmEditApplicationType editApplication = new frmEditApplicationType(_ApplicationType);
            editApplication.ShowDialog();
            _RefreshApplicationList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
