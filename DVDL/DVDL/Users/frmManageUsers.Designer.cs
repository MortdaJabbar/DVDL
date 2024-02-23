namespace DVDL.Users
{
    partial class frmManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            PersonID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            cmsUserOperation = new ContextMenuStrip(components);
            AddNewUser = new ToolStripMenuItem();
            UpdateUser = new ToolStripMenuItem();
            DeleteUser = new ToolStripMenuItem();
            ShowUserInfo = new ToolStripMenuItem();
            lbTitle = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbTotalRecords = new Label();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            label2 = new Label();
            cbActiveStatus = new ComboBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmsUserOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PersonID, UserID, FullName, UserName, IsActive });
            dataGridView1.ContextMenuStrip = cmsUserOperation;
            dataGridView1.Location = new Point(12, 242);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(890, 223);
            dataGridView1.TabIndex = 0;
            // 
            // PersonID
            // 
            PersonID.HeaderText = "PersonID";
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.HeaderText = "FullName";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "IsActive";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // cmsUserOperation
            // 
            cmsUserOperation.Items.AddRange(new ToolStripItem[] { AddNewUser, UpdateUser, DeleteUser, ShowUserInfo });
            cmsUserOperation.Name = "cmsUserOperation";
            cmsUserOperation.Size = new Size(200, 156);
            // 
            // AddNewUser
            // 
            AddNewUser.Font = new Font("Segoe UI", 12F);
            AddNewUser.Image = Properties.Resources.Add_New_User_32;
            AddNewUser.ImageAlign = ContentAlignment.MiddleLeft;
            AddNewUser.ImageScaling = ToolStripItemImageScaling.None;
            AddNewUser.Name = "AddNewUser";
            AddNewUser.Size = new Size(199, 38);
            AddNewUser.Text = "Add New User";
            AddNewUser.Click += AddNewUser_Click;
            // 
            // UpdateUser
            // 
            UpdateUser.Font = new Font("Segoe UI", 12F);
            UpdateUser.Image = Properties.Resources.Edit_User_32;
            UpdateUser.ImageScaling = ToolStripItemImageScaling.None;
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(199, 38);
            UpdateUser.Text = "Update User ";
            UpdateUser.TextAlign = ContentAlignment.MiddleLeft;
            UpdateUser.Click += UpdateUser_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.Font = new Font("Segoe UI", 12F);
            DeleteUser.Image = Properties.Resources.Delete_User_32;
            DeleteUser.ImageScaling = ToolStripItemImageScaling.None;
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(199, 38);
            DeleteUser.Text = "Delete User";
            DeleteUser.Click += DeleteUser_Click;
            // 
            // ShowUserInfo
            // 
            ShowUserInfo.Font = new Font("Segoe UI", 12F);
            ShowUserInfo.Image = Properties.Resources.User_32__2;
            ShowUserInfo.ImageAlign = ContentAlignment.MiddleLeft;
            ShowUserInfo.ImageScaling = ToolStripItemImageScaling.None;
            ShowUserInfo.Name = "ShowUserInfo";
            ShowUserInfo.Size = new Size(199, 38);
            ShowUserInfo.Text = "Show User Info";
            ShowUserInfo.Click += ShowUserInfo_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Maroon;
            lbTitle.Location = new Point(322, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(129, 22);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Mange Users";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_400;
            pictureBox1.Location = new Point(264, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 489);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 3;
            label1.Text = "Record#:";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(103, 489);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(39, 25);
            lbTotalRecords.TabIndex = 4;
            lbTotalRecords.Text = "???";
            // 
            // cbFilter
            // 
            cbFilter.AutoCompleteCustomSource.AddRange(new string[] { "None", "PersonID", "UserID", "UserName", "FullName", "IsActive" });
            cbFilter.BackColor = SystemColors.ButtonHighlight;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "PersonID", "UserID", "UserName", "FullName", "IsActive" });
            cbFilter.Location = new Point(70, 213);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 5;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(197, 213);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(142, 23);
            txtFilter.TabIndex = 6;
            txtFilter.Visible = false;
            txtFilter.KeyPress += txtFilter_KeyPress;
            txtFilter.Leave += txtFilter_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 7;
            label2.Text = "Filter:";
            // 
            // cbActiveStatus
            // 
            cbActiveStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActiveStatus.FormattingEnabled = true;
            cbActiveStatus.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbActiveStatus.Location = new Point(197, 213);
            cbActiveStatus.Name = "cbActiveStatus";
            cbActiveStatus.Size = new Size(142, 23);
            cbActiveStatus.TabIndex = 8;
            cbActiveStatus.Visible = false;
            cbActiveStatus.SelectedIndexChanged += cbActiveStatus_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Add_New_User_72;
            pictureBox2.Location = new Point(802, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 529);
            Controls.Add(pictureBox2);
            Controls.Add(cbActiveStatus);
            Controls.Add(label2);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(lbTotalRecords);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbTitle);
            Controls.Add(dataGridView1);
            Name = "frmManageUsers";
            Text = "frmManageUsers";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmsUserOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbTotalRecords;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private Label label2;
        private ComboBox cbActiveStatus;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn IsActive;
        private PictureBox pictureBox2;
        private ContextMenuStrip cmsUserOperation;
        private ToolStripMenuItem AddNewUser;
        private ToolStripMenuItem UpdateUser;
        private ToolStripMenuItem DeleteUser;
        private ToolStripMenuItem ShowUserInfo;
    }
}