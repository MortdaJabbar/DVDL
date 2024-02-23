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
    public partial class frmManageTestType : Form
    {
        private DataTable _AllTestTypes;
        public frmManageTestType()
        {
            InitializeComponent();
        }

        private void frmManageTestType_Load(object sender, EventArgs e)
        {
            _AllTestTypes = clsTestType.GetAllTestTypes();

            dataGridView1.DataSource = _AllTestTypes;
            dataGridView1.Columns[0].HeaderText = "Test ID";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Decription";
            dataGridView1.Columns[3].HeaderText = "Fees";
            lbTotalRecords.Text = dataGridView1.RowCount.ToString();

        }
    }
}
