using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLBussinesLogicTier;
namespace DVDL.Users
{
    public partial class frmManageUsers : Form
    {
        private static DataTable _AllUsers = clsUser.GetAllUsers();
        private static DataTable _dtUsers = _AllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "FullName", "IsActive");
        public frmManageUsers()
        {
            InitializeComponent();
        }
        private void _ReformDataGridView(ref DataTable Users)
        {
            dataGridView1.RowCount = Users.Rows.Count;

            int i = 0;
            foreach (DataRow User in Users.Rows)
            {
                dataGridView1.Rows[i].Cells["UserID"].Value = (int)User["UserID"];
                dataGridView1.Rows[i].Cells["PersonID"].Value = (int)User["PersonID"];
                dataGridView1.Rows[i].Cells["UserName"].Value = User["UserName"].ToString();
                dataGridView1.Rows[i].Cells["FullName"].Value = User["FullName"].ToString();
                dataGridView1.Rows[i].Cells["IsActive"].Value = (((bool)User["IsActive"]) == true) ? "Yes" : "No";
                i++;
            }
            lbTotalRecords.Text = dataGridView1.RowCount.ToString();

        }
        private void _FillDataGridWithUsers()
        {
            _ReformDataGridView(ref _AllUsers);

        }
        private void cbActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = clsUser.GetAllUsers();
            string ActiveStatus = (cbActiveStatus.SelectedItem.ToString());
            if (ActiveStatus == "All")
            {
                _ReformDataGridView(ref dt);
            }
            else if (ActiveStatus == "Yes")
            {
                dt = dt.Select("IsActive = true").CopyToDataTable();
                _ReformDataGridView(ref dt);

            }
            else
            {
                dt = dt.Select("IsActive = false").CopyToDataTable();
                _ReformDataGridView(ref dt);
            }

        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Filter = (cbFilter.SelectedItem.ToString());
            if (Filter != "None")
            {
                if (Filter == "IsActive") { cbActiveStatus.SelectedItem = "All"; cbActiveStatus.Visible = true; txtFilter.Visible = false; }
                else { txtFilter.Visible = true; cbActiveStatus.Visible = false; }
            }

            else { cbActiveStatus.Visible = false; txtFilter.Visible = false; }

        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Filter = cbFilter.SelectedItem.ToString();

            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (Filter == "PersonID" || Filter == "UserID"));
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedItem = "None";
            _FillDataGridWithUsers();
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {

            string FilterValue = txtFilter.Text.Trim();
            if (FilterValue != "")
            {
                DataTable dt = clsUser.GetAllUsers();
                switch (cbFilter.SelectedItem.ToString())
                {
                    case "PersonID":
                        {

                            if (dt.Select($"PersonID={FilterValue}").Count() > 0)
                            {
                                dt = dt.Select($"PersonID={FilterValue}").CopyToDataTable();
                                _ReformDataGridView(ref dt);
                            }
                            else { txtFilter.Clear(); MessageBox.Show($"User With {cbFilter.SelectedItem.ToString()} = {FilterValue} Not Found"); _RefreshUsersList(); }
                        }
                        break;

                    case "UserID":
                        {

                            if (dt.Select($"UserID={FilterValue}").Count() > 0)
                            {
                                dt = dt.Select($"UserID={FilterValue}").CopyToDataTable();
                                _ReformDataGridView(ref dt);
                            }
                            else { txtFilter.Clear(); MessageBox.Show($"User With {cbFilter.SelectedItem.ToString()} = {FilterValue} Not Found"); _RefreshUsersList(); }
                        }
                        break;

                    case "UserName":
                        {

                            if (dt.Select($"UserName='{FilterValue}'").Count() > 0)
                            {
                                dt = dt.Select($"UserName ='{FilterValue}' ").CopyToDataTable();

                                _ReformDataGridView(ref dt);
                            }
                            else { txtFilter.Clear(); MessageBox.Show($"User With {cbFilter.SelectedItem.ToString()} = {FilterValue} Not Found"); _RefreshUsersList(); }
                        }
                        break;

                    case "FullName":
                        {
                            if (dt.Select($"FullName='{FilterValue}'").Count() > 0)
                            {
                                dt = dt.Select($"FullName ='{FilterValue}' ").CopyToDataTable();

                                _ReformDataGridView(ref dt);
                            }
                            else { txtFilter.Clear(); MessageBox.Show($"User With {cbFilter.SelectedItem.ToString()} = {FilterValue} Not Found"); _RefreshUsersList(); }
                        }
                        break;


                }
            }
            else { _RefreshUsersList();  }
        }
        private void _RefreshUsersList()
        {
            DataTable Users = clsUser.GetAllUsers();

            _ReformDataGridView(ref Users);
        }
        private void ShowUserInfo_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dataGridView1.CurrentRow.Cells["UserID"].Value;
            frmShowUserInfo UserInfo = new frmShowUserInfo(SelectedUserID);
            UserInfo.ShowDialog();

        }
        private void AddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser FormAddUpdateUser = new frmAddUpdateUser();
            FormAddUpdateUser.ShowDialog();

            _RefreshUsersList();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddNewUser_Click(null, null);
        }
        private void UpdateUser_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridView1.CurrentRow.Cells["UserID"].Value;
            frmAddUpdateUser frmupdateuser = new frmAddUpdateUser(UserID);

            frmupdateuser.ShowDialog();

            _RefreshUsersList();
        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridView1.CurrentRow.Cells["UserID"].Value;

            if (clsUser.DeleteUser(UserID)) 
            {
                MessageBox.Show("Person Deleted Sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshUsersList();
            }
            else 
            {
                MessageBox.Show("Person Deletion Failed due to other connections in system", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
   
    
    
    }
}
