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
    public partial class frmMangeTests : Form
    {
        private clsTestType _TestType;
        public frmMangeTests()
        {
            InitializeComponent();
            _TestType = new clsTestType();
        }
        private void frmMangeTests_Load(object sender, EventArgs e)
        {
            _FillAllTestTypes();
        }
        private void _FillAllTestTypes()
        {
            DataTable testTypes = clsTestType.GetAllTestTypes();
            dataGridView1.DataSource = testTypes;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Description";
            dataGridView1.Columns[3].HeaderText = "Fees";
            lbTotalRecord.Text = dataGridView1.RowCount.ToString();

        }
        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _TestType.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _TestType.Title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            _TestType.Description = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            _TestType.Fees = (Decimal)dataGridView1.CurrentRow.Cells[3].Value;
            frmUpdateTestType frmUpdate = new frmUpdateTestType(_TestType);

            frmUpdate.ShowDialog();
            _FillAllTestTypes();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
