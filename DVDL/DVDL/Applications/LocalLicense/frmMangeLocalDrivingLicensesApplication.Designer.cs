namespace DVDL.Applications.LocalLicense
{
    partial class frmMangeLocalDrivingLicensesApplication
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvLocalDrivingLicenses = new DataGridView();
            cmsOperationOnLDLA = new ContextMenuStrip(components);
            SechdualTestChoice = new ToolStripMenuItem();
            VisionTestChoice = new ToolStripMenuItem();
            WrittenTestChoice = new ToolStripMenuItem();
            StreetTestChoice = new ToolStripMenuItem();
            label2 = new Label();
            lbTotalRecords = new Label();
            BtnClose = new Button();
            label3 = new Label();
            txtFilter = new TextBox();
            cbFilter = new ComboBox();
            pbAddNewLocalDrivingLicense = new PictureBox();
            LDLApplicationInfoChoice = new ToolStripMenuItem();
            EditApplicationChoice = new ToolStripMenuItem();
            DeleteApplicationChoice = new ToolStripMenuItem();
            CancelApplicationChoice = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeChoice = new ToolStripMenuItem();
            showDrivingLiceneInfoChoice = new ToolStripMenuItem();
            ShowLicenseHistoryChoice = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenses).BeginInit();
            cmsOperationOnLDLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNewLocalDrivingLicense).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(208, 178);
            label1.Name = "label1";
            label1.Size = new Size(332, 30);
            label1.TabIndex = 0;
            label1.Text = " Local Driving License Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Local_Driving_License_512;
            pictureBox1.Location = new Point(208, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvLocalDrivingLicenses
            // 
            dgvLocalDrivingLicenses.AllowUserToAddRows = false;
            dgvLocalDrivingLicenses.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocalDrivingLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenses.ContextMenuStrip = cmsOperationOnLDLA;
            dgvLocalDrivingLicenses.Location = new Point(12, 271);
            dgvLocalDrivingLicenses.MultiSelect = false;
            dgvLocalDrivingLicenses.Name = "dgvLocalDrivingLicenses";
            dgvLocalDrivingLicenses.ReadOnly = true;
            dgvLocalDrivingLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocalDrivingLicenses.Size = new Size(849, 175);
            dgvLocalDrivingLicenses.TabIndex = 2;
            // 
            // cmsOperationOnLDLA
            // 
            cmsOperationOnLDLA.Items.AddRange(new ToolStripItem[] { LDLApplicationInfoChoice, EditApplicationChoice, DeleteApplicationChoice, CancelApplicationChoice, SechdualTestChoice, issueDrivingLicenseFirstTimeChoice, showDrivingLiceneInfoChoice, ShowLicenseHistoryChoice });
            cmsOperationOnLDLA.Name = "cmsOperationOnLDLA";
            cmsOperationOnLDLA.Size = new Size(262, 330);
            cmsOperationOnLDLA.Opening += cmsOperationOnLDLA_Opening;
            // 
            // SechdualTestChoice
            // 
            SechdualTestChoice.DropDownItems.AddRange(new ToolStripItem[] { VisionTestChoice, WrittenTestChoice, StreetTestChoice });
            SechdualTestChoice.Font = new Font("Segoe UI", 12F);
            SechdualTestChoice.Image = Properties.Resources.Schedule_Test_32;
            SechdualTestChoice.ImageScaling = ToolStripItemImageScaling.None;
            SechdualTestChoice.Name = "SechdualTestChoice";
            SechdualTestChoice.Size = new Size(261, 38);
            SechdualTestChoice.Text = "Sechdual Test";
            // 
            // VisionTestChoice
            // 
            VisionTestChoice.Image = Properties.Resources.Vision_Test_Schdule;
            VisionTestChoice.ImageScaling = ToolStripItemImageScaling.None;
            VisionTestChoice.Name = "VisionTestChoice";
            VisionTestChoice.Size = new Size(196, 38);
            VisionTestChoice.Text = "Vision Test";
            VisionTestChoice.Click += sechdualVisionTestToolStripMenuItem_Click;
            // 
            // WrittenTestChoice
            // 
            WrittenTestChoice.Image = Properties.Resources.Written_Test_32_Sechdule;
            WrittenTestChoice.ImageScaling = ToolStripItemImageScaling.None;
            WrittenTestChoice.Name = "WrittenTestChoice";
            WrittenTestChoice.Size = new Size(196, 38);
            WrittenTestChoice.Text = " Written Test";
            WrittenTestChoice.Click += sechdualWritingTestToolStripMenuItem_Click;
            // 
            // StreetTestChoice
            // 
            StreetTestChoice.Image = Properties.Resources.Street_Test_32;
            StreetTestChoice.ImageAlign = ContentAlignment.MiddleLeft;
            StreetTestChoice.ImageScaling = ToolStripItemImageScaling.None;
            StreetTestChoice.Name = "StreetTestChoice";
            StreetTestChoice.Size = new Size(196, 38);
            StreetTestChoice.Text = "Street Test";
            StreetTestChoice.Click += StreetTestChoice_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 450);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 3;
            label2.Text = "TotalRecord: ";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold | FontStyle.Italic);
            lbTotalRecords.Location = new Point(143, 452);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(53, 28);
            lbTotalRecords.TabIndex = 4;
            lbTotalRecords.Text = "[???]";
            // 
            // BtnClose
            // 
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnClose.Image = Properties.Resources.Close_32;
            BtnClose.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClose.Location = new Point(764, 450);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(97, 35);
            BtnClose.TabIndex = 5;
            BtnClose.Text = "Close";
            BtnClose.TextAlign = ContentAlignment.MiddleRight;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 6;
            label3.Text = "Filter:";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(197, 242);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(137, 23);
            txtFilter.TabIndex = 7;
            txtFilter.Visible = false;
            txtFilter.KeyDown += txtFilter_KeyDown;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "LDLApplicationID", "NationalNo" });
            cbFilter.Location = new Point(70, 242);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 8;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // pbAddNewLocalDrivingLicense
            // 
            pbAddNewLocalDrivingLicense.Image = Properties.Resources.New_Application_64;
            pbAddNewLocalDrivingLicense.Location = new Point(816, 211);
            pbAddNewLocalDrivingLicense.Name = "pbAddNewLocalDrivingLicense";
            pbAddNewLocalDrivingLicense.Size = new Size(45, 50);
            pbAddNewLocalDrivingLicense.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewLocalDrivingLicense.TabIndex = 9;
            pbAddNewLocalDrivingLicense.TabStop = false;
            pbAddNewLocalDrivingLicense.Click += pbAddNewLocalDrivingLicense_Click;
            // 
            // LDLApplicationInfoChoice
            // 
            LDLApplicationInfoChoice.Image = Properties.Resources.PersonDetails_32;
            LDLApplicationInfoChoice.ImageAlign = ContentAlignment.MiddleLeft;
            LDLApplicationInfoChoice.ImageScaling = ToolStripItemImageScaling.None;
            LDLApplicationInfoChoice.Name = "LDLApplicationInfoChoice";
            LDLApplicationInfoChoice.Size = new Size(261, 38);
            LDLApplicationInfoChoice.Text = "Show LDLApplication Info";
            LDLApplicationInfoChoice.Click += LDLApplicationInfoChoice_Click;
            // 
            // EditApplicationChoice
            // 
            EditApplicationChoice.Image = Properties.Resources.edit_32;
            EditApplicationChoice.ImageAlign = ContentAlignment.MiddleLeft;
            EditApplicationChoice.ImageScaling = ToolStripItemImageScaling.None;
            EditApplicationChoice.Name = "EditApplicationChoice";
            EditApplicationChoice.Size = new Size(261, 38);
            EditApplicationChoice.Text = "Edit Application";
            EditApplicationChoice.Click += EditApplicationChoice_Click;
            // 
            // DeleteApplicationChoice
            // 
            DeleteApplicationChoice.Image = Properties.Resources.Delete_32_2;
            DeleteApplicationChoice.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteApplicationChoice.ImageScaling = ToolStripItemImageScaling.None;
            DeleteApplicationChoice.Name = "DeleteApplicationChoice";
            DeleteApplicationChoice.Size = new Size(261, 38);
            DeleteApplicationChoice.Text = "Delete Application";
            DeleteApplicationChoice.Click += DeleteApplicationChoice_Click;
            // 
            // CancelApplicationChoice
            // 
            CancelApplicationChoice.Image = Properties.Resources.Delete_32;
            CancelApplicationChoice.ImageAlign = ContentAlignment.MiddleLeft;
            CancelApplicationChoice.ImageScaling = ToolStripItemImageScaling.None;
            CancelApplicationChoice.Name = "CancelApplicationChoice";
            CancelApplicationChoice.Size = new Size(261, 38);
            CancelApplicationChoice.Text = "Cancel Application";
            CancelApplicationChoice.Click += CancelApplicationChoice_Click;
            // 
            // issueDrivingLicenseFirstTimeChoice
            // 
            issueDrivingLicenseFirstTimeChoice.Image = Properties.Resources.IssueDrivingLicense_32;
            issueDrivingLicenseFirstTimeChoice.ImageScaling = ToolStripItemImageScaling.None;
            issueDrivingLicenseFirstTimeChoice.Name = "issueDrivingLicenseFirstTimeChoice";
            issueDrivingLicenseFirstTimeChoice.Size = new Size(261, 38);
            issueDrivingLicenseFirstTimeChoice.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeChoice.Click += issueDrivingLicenseFirstTimeChoice_Click;
            // 
            // showDrivingLiceneInfoChoice
            // 
            showDrivingLiceneInfoChoice.Image = Properties.Resources.License_View_32;
            showDrivingLiceneInfoChoice.ImageAlign = ContentAlignment.MiddleLeft;
            showDrivingLiceneInfoChoice.ImageScaling = ToolStripItemImageScaling.None;
            showDrivingLiceneInfoChoice.Name = "showDrivingLiceneInfoChoice";
            showDrivingLiceneInfoChoice.Size = new Size(261, 38);
            showDrivingLiceneInfoChoice.Text = "Show Driving Licene Info";
            showDrivingLiceneInfoChoice.Click += showDrivingLiceneInfoChoice_Click;
            // 
            // ShowLicenseHistoryChoice
            // 
            ShowLicenseHistoryChoice.Image = Properties.Resources.PersonLicenseHistory_32;
            ShowLicenseHistoryChoice.ImageAlign = ContentAlignment.MiddleLeft;
            ShowLicenseHistoryChoice.ImageScaling = ToolStripItemImageScaling.None;
            ShowLicenseHistoryChoice.Name = "ShowLicenseHistoryChoice";
            ShowLicenseHistoryChoice.Size = new Size(261, 38);
            ShowLicenseHistoryChoice.Text = "Show Licenses History";
            ShowLicenseHistoryChoice.Click += ShowLicenseHistoryChoice_Click;
            // 
            // frmMangeLocalDrivingLicensesApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 489);
            Controls.Add(pbAddNewLocalDrivingLicense);
            Controls.Add(cbFilter);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(BtnClose);
            Controls.Add(lbTotalRecords);
            Controls.Add(label2);
            Controls.Add(dgvLocalDrivingLicenses);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmMangeLocalDrivingLicensesApplication";
            Text = "frmMangeLocalDrivingApplicationLicenses";
            Load += frmMangeLocalDrivingLicensesApplication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenses).EndInit();
            cmsOperationOnLDLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAddNewLocalDrivingLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvLocalDrivingLicenses;
        private Label label2;
        private Label lbTotalRecords;
        private Button BtnClose;
        private Label label3;
        private TextBox txtFilter;
        private ComboBox cbFilter;
        private PictureBox pbAddNewLocalDrivingLicense;
        private ContextMenuStrip cmsOperationOnLDLA;
        private ToolStripMenuItem SechdualTestChoice;
        private ToolStripMenuItem VisionTestChoice;
        private ToolStripMenuItem WrittenTestChoice;
        private ToolStripMenuItem StreetTestChoice;
        private ToolStripMenuItem LDLApplicationInfoChoice;
        private ToolStripMenuItem EditApplicationChoice;
        private ToolStripMenuItem DeleteApplicationChoice;
        private ToolStripMenuItem CancelApplicationChoice;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeChoice;
        private ToolStripMenuItem showDrivingLiceneInfoChoice;
        private ToolStripMenuItem ShowLicenseHistoryChoice;
    }
}