namespace DVDL.Pepole
{
    partial class frmManagePepole
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
            NationalNo = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            SecondName = new DataGridViewTextBoxColumn();
            ThirdName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            cmOperationsMenu = new ContextMenuStrip(components);
            cmsShowDetails = new ToolStripMenuItem();
            editPersonInfoToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            deletePersonToolStripMenuItem1 = new ToolStripMenuItem();
            sendMessageToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lbTotalRecords = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cbFilters = new ComboBox();
            txtFilter = new TextBox();
            pbAddNew = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmOperationsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gender, DateOfBirth, Nationality, Email, Phone });
            dataGridView1.ContextMenuStrip = cmOperationsMenu;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(2, 198);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1097, 302);
            dataGridView1.TabIndex = 0;
            // 
            // PersonID
            // 
            PersonID.HeaderText = "PersonID";
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
            // 
            // NationalNo
            // 
            NationalNo.HeaderText = "NationalNo";
            NationalNo.Name = "NationalNo";
            NationalNo.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            SecondName.HeaderText = "SecondName";
            SecondName.Name = "SecondName";
            SecondName.ReadOnly = true;
            // 
            // ThirdName
            // 
            ThirdName.HeaderText = "ThirdName";
            ThirdName.Name = "ThirdName";
            ThirdName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "DateOfBirth";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // Nationality
            // 
            Nationality.HeaderText = "Nationality";
            Nationality.Name = "Nationality";
            Nationality.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // cmOperationsMenu
            // 
            cmOperationsMenu.Items.AddRange(new ToolStripItem[] { cmsShowDetails, editPersonInfoToolStripMenuItem, addNewPersonToolStripMenuItem, deletePersonToolStripMenuItem1, sendMessageToolStripMenuItem, emailToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmOperationsMenu.Name = "cmOperationsMenu";
            cmOperationsMenu.Size = new Size(250, 326);
            // 
            // cmsShowDetails
            // 
            cmsShowDetails.Font = new Font("Segoe UI", 10F);
            cmsShowDetails.Image = Properties.Resources.PersonDetails_32;
            cmsShowDetails.ImageAlign = ContentAlignment.MiddleLeft;
            cmsShowDetails.ImageScaling = ToolStripItemImageScaling.None;
            cmsShowDetails.Name = "cmsShowDetails";
            cmsShowDetails.Size = new Size(249, 46);
            cmsShowDetails.Text = "ShowDetails";
            cmsShowDetails.Click += cmsShowDetails_Click;
            // 
            // editPersonInfoToolStripMenuItem
            // 
            editPersonInfoToolStripMenuItem.Image = Properties.Resources.edit_32;
            editPersonInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editPersonInfoToolStripMenuItem.Name = "editPersonInfoToolStripMenuItem";
            editPersonInfoToolStripMenuItem.Size = new Size(249, 46);
            editPersonInfoToolStripMenuItem.Text = "EditPersonInfo";
            editPersonInfoToolStripMenuItem.Click += editPersonInfoToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addNewPersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(249, 46);
            addNewPersonToolStripMenuItem.Text = "AddNewPerson";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // deletePersonToolStripMenuItem1
            // 
            deletePersonToolStripMenuItem1.Image = Properties.Resources.Delete_32;
            deletePersonToolStripMenuItem1.ImageAlign = ContentAlignment.MiddleLeft;
            deletePersonToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deletePersonToolStripMenuItem1.Name = "deletePersonToolStripMenuItem1";
            deletePersonToolStripMenuItem1.Size = new Size(249, 46);
            deletePersonToolStripMenuItem1.Text = "DeletePerson";
            deletePersonToolStripMenuItem1.Click += deletePersonToolStripMenuItem1_Click;
            // 
            // sendMessageToolStripMenuItem
            // 
            sendMessageToolStripMenuItem.Image = Properties.Resources.call_32;
            sendMessageToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            sendMessageToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            sendMessageToolStripMenuItem.Size = new Size(249, 46);
            sendMessageToolStripMenuItem.Text = "SendMessage";
            sendMessageToolStripMenuItem.Click += sendMessageToolStripMenuItem_Click;
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Image = Properties.Resources.Email_321;
            emailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(249, 46);
            emailToolStripMenuItem.Text = "Email";
            emailToolStripMenuItem.Click += emailToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(249, 46);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 535);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 1;
            label1.Text = "#Records:";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(109, 535);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(21, 23);
            lbTotalRecords.TabIndex = 2;
            lbTotalRecords.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(388, 9);
            label3.Name = "label3";
            label3.Size = new Size(173, 32);
            label3.TabIndex = 3;
            label3.Text = "ManagePeople";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Manage_People;
            pictureBox1.Location = new Point(375, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 165);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Filter By :";
            // 
            // cbFilters
            // 
            cbFilters.AutoCompleteCustomSource.AddRange(new string[] { "PersonID", "NationalNo", "Gender", "Nationality" });
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None", "PersonID", "NationalNo", "FirstName", "SecondName", "LastName", "Gender", "Email", "Phone", "Nationality" });
            cbFilters.Location = new Point(77, 165);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(106, 23);
            cbFilters.TabIndex = 6;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(189, 166);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(126, 23);
            txtFilter.TabIndex = 7;
            txtFilter.KeyPress += txtFilter_KeyPress;
            txtFilter.Leave += txtFilter_Leave;
            // 
            // pbAddNew
            // 
            pbAddNew.BorderStyle = BorderStyle.Fixed3D;
            pbAddNew.Image = Properties.Resources.Add_Person_72;
            pbAddNew.Location = new Point(1025, 141);
            pbAddNew.Name = "pbAddNew";
            pbAddNew.Size = new Size(55, 44);
            pbAddNew.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNew.TabIndex = 8;
            pbAddNew.TabStop = false;
            pbAddNew.Click += pbAddNew_Click;
            // 
            // frmManagePepole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 566);
            Controls.Add(pbAddNew);
            Controls.Add(txtFilter);
            Controls.Add(cbFilters);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(lbTotalRecords);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmManagePepole";
            Text = "frmManagePepole";
            Load += frmManagePepole_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmOperationsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label lbTotalRecords;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox cbFilters;
        private TextBox txtFilter;
        private PictureBox pbAddNew;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn ThirdName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private ContextMenuStrip cmOperationsMenu;
        private ToolStripMenuItem cmsShowDetails;
        private ToolStripMenuItem editPersonInfoToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem deletePersonToolStripMenuItem1;
        private ToolStripMenuItem sendMessageToolStripMenuItem;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}