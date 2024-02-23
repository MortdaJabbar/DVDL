namespace DVDL
{
    partial class frmManageDetainAndReleaseLicense
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
            lbTitle = new Label();
            pictureBox1 = new PictureBox();
            dgvDetainedLicenses = new DataGridView();
            cmsOperation = new ContextMenuStrip(components);
            showPersonDetailToolStripMenuItem = new ToolStripMenuItem();
            showPersonHistoryLicenseToolStripMenuItem = new ToolStripMenuItem();
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseLicenseToolStripMenuItem = new ToolStripMenuItem();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            label1 = new Label();
            lbTotalRecords = new Label();
            pbDetain = new PictureBox();
            pbRelease = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).BeginInit();
            cmsOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRelease).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(282, 206);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(170, 23);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "List Detained Licence";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detain_512;
            pictureBox1.Location = new Point(184, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.AllowUserToAddRows = false;
            dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dgvDetainedLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetainedLicenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDetainedLicenses.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetainedLicenses.ContextMenuStrip = cmsOperation;
            dgvDetainedLicenses.Location = new Point(12, 306);
            dgvDetainedLicenses.MultiSelect = false;
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.ReadOnly = true;
            dgvDetainedLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetainedLicenses.Size = new Size(836, 173);
            dgvDetainedLicenses.TabIndex = 2;
            // 
            // cmsOperation
            // 
            cmsOperation.Items.AddRange(new ToolStripItem[] { showPersonDetailToolStripMenuItem, showPersonHistoryLicenseToolStripMenuItem, showLicenseInfoToolStripMenuItem, detainLicenseToolStripMenuItem, releaseLicenseToolStripMenuItem });
            cmsOperation.Name = "cmsOperation";
            cmsOperation.Size = new Size(326, 376);
            // 
            // showPersonDetailToolStripMenuItem
            // 
            showPersonDetailToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showPersonDetailToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailToolStripMenuItem.Name = "showPersonDetailToolStripMenuItem";
            showPersonDetailToolStripMenuItem.Size = new Size(325, 70);
            showPersonDetailToolStripMenuItem.Text = "Show Person Detail";
            showPersonDetailToolStripMenuItem.Click += showPersonDetailToolStripMenuItem_Click;
            // 
            // showPersonHistoryLicenseToolStripMenuItem
            // 
            showPersonHistoryLicenseToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showPersonHistoryLicenseToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonHistoryLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonHistoryLicenseToolStripMenuItem.Name = "showPersonHistoryLicenseToolStripMenuItem";
            showPersonHistoryLicenseToolStripMenuItem.Size = new Size(325, 70);
            showPersonHistoryLicenseToolStripMenuItem.Text = "Show Person History License";
            showPersonHistoryLicenseToolStripMenuItem.Click += showPersonHistoryLicenseToolStripMenuItem_Click;
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showLicenseInfoToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            showLicenseInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(325, 70);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            detainLicenseToolStripMenuItem.Image = Properties.Resources.Detain_64;
            detainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(325, 70);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            detainLicenseToolStripMenuItem.Click += detainLicenseToolStripMenuItem_Click;
            // 
            // releaseLicenseToolStripMenuItem
            // 
            releaseLicenseToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            releaseLicenseToolStripMenuItem.Image = Properties.Resources.Release_Detained_License_64;
            releaseLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            releaseLicenseToolStripMenuItem.Size = new Size(325, 70);
            releaseLicenseToolStripMenuItem.Text = "Release License";
            releaseLicenseToolStripMenuItem.Click += releaseLicenseToolStripMenuItem_Click;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "DetainID", "LicenseID" });
            cbFilter.Location = new Point(12, 277);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 3;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(139, 277);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(186, 23);
            txtFilter.TabIndex = 4;
            txtFilter.KeyDown += txtFilter_KeyDown;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 497);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 5;
            label1.Text = "#Records:";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(101, 497);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(19, 21);
            lbTotalRecords.TabIndex = 6;
            lbTotalRecords.Text = "0";
            // 
            // pbDetain
            // 
            pbDetain.Image = Properties.Resources.Detain_64;
            pbDetain.Location = new Point(795, 245);
            pbDetain.Name = "pbDetain";
            pbDetain.Size = new Size(53, 55);
            pbDetain.SizeMode = PictureBoxSizeMode.Zoom;
            pbDetain.TabIndex = 7;
            pbDetain.TabStop = false;
            pbDetain.Click += pbDetain_Click;
            // 
            // pbRelease
            // 
            pbRelease.Image = Properties.Resources.Release_Detained_License_64;
            pbRelease.Location = new Point(720, 245);
            pbRelease.Name = "pbRelease";
            pbRelease.Size = new Size(53, 55);
            pbRelease.SizeMode = PictureBoxSizeMode.Zoom;
            pbRelease.TabIndex = 8;
            pbRelease.TabStop = false;
            pbRelease.Click += pbRelease_Click;
            // 
            // frmManageDetainAndReleaseLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 527);
            Controls.Add(pbRelease);
            Controls.Add(pbDetain);
            Controls.Add(lbTotalRecords);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(pictureBox1);
            Controls.Add(lbTitle);
            Name = "frmManageDetainAndReleaseLicense";
            Text = "frmManageDetainAndReleaseLicense";
            Load += frmManageDetainAndReleaseLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).EndInit();
            cmsOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDetain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRelease).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private PictureBox pictureBox1;
        private DataGridView dgvDetainedLicenses;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private Label label1;
        private Label lbTotalRecords;
        private ContextMenuStrip cmsOperation;
        private ToolStripMenuItem showPersonDetailToolStripMenuItem;
        private ToolStripMenuItem showPersonHistoryLicenseToolStripMenuItem;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private PictureBox pbDetain;
        private PictureBox pbRelease;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}