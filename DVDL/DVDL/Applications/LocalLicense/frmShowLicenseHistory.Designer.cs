namespace DVDL
{
    partial class frmShowLicenseHistory
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
            pictureBox1 = new PictureBox();
            ctrPersonInfoWithFilter1 = new Pepole.ctrPersonInfoWithFilter();
            gbDrivingLicense = new GroupBox();
            LicensesTabs = new TabControl();
            tpLocalLicenses = new TabPage();
            dgvLicenses = new DataGridView();
            cmsOpOnLicenses = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            tpInternationalLicense = new TabPage();
            dgvInternationalLicense = new DataGridView();
            cmsOpOnInternaionalLicense = new ContextMenuStrip(components);
            showInternaionalLiceseInfoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDrivingLicense.SuspendLayout();
            LicensesTabs.SuspendLayout();
            tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicenses).BeginInit();
            cmsOpOnLicenses.SuspendLayout();
            tpInternationalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicense).BeginInit();
            cmsOpOnInternaionalLicense.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PersonLicenseHistory_512;
            pictureBox1.Location = new Point(40, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ctrPersonInfoWithFilter1
            // 
            ctrPersonInfoWithFilter1.FilterValue = "";
            ctrPersonInfoWithFilter1.GbFilterEnable = true;
            ctrPersonInfoWithFilter1.Location = new Point(242, 12);
            ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            ctrPersonInfoWithFilter1.Size = new Size(943, 383);
            ctrPersonInfoWithFilter1.TabIndex = 1;
            // 
            // gbDrivingLicense
            // 
            gbDrivingLicense.Controls.Add(LicensesTabs);
            gbDrivingLicense.Font = new Font("Segoe UI", 10F);
            gbDrivingLicense.Location = new Point(12, 410);
            gbDrivingLicense.Name = "gbDrivingLicense";
            gbDrivingLicense.Size = new Size(1179, 237);
            gbDrivingLicense.TabIndex = 2;
            gbDrivingLicense.TabStop = false;
            gbDrivingLicense.Text = "Driving License";
            // 
            // LicensesTabs
            // 
            LicensesTabs.Controls.Add(tpLocalLicenses);
            LicensesTabs.Controls.Add(tpInternationalLicense);
            LicensesTabs.Location = new Point(7, 24);
            LicensesTabs.Name = "LicensesTabs";
            LicensesTabs.SelectedIndex = 0;
            LicensesTabs.Size = new Size(1166, 207);
            LicensesTabs.TabIndex = 0;
            // 
            // tpLocalLicenses
            // 
            tpLocalLicenses.Controls.Add(dgvLicenses);
            tpLocalLicenses.Location = new Point(4, 26);
            tpLocalLicenses.Name = "tpLocalLicenses";
            tpLocalLicenses.Padding = new Padding(3);
            tpLocalLicenses.Size = new Size(1158, 177);
            tpLocalLicenses.TabIndex = 0;
            tpLocalLicenses.Text = "Licesnses";
            tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvLicenses
            // 
            dgvLicenses.AllowUserToAddRows = false;
            dgvLicenses.AllowUserToDeleteRows = false;
            dgvLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicenses.ContextMenuStrip = cmsOpOnLicenses;
            dgvLicenses.Location = new Point(6, 6);
            dgvLicenses.MultiSelect = false;
            dgvLicenses.Name = "dgvLicenses";
            dgvLicenses.ReadOnly = true;
            dgvLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLicenses.Size = new Size(1146, 150);
            dgvLicenses.TabIndex = 0;
            // 
            // cmsOpOnLicenses
            // 
            cmsOpOnLicenses.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            cmsOpOnLicenses.Name = "contextMenuStrip1";
            cmsOpOnLicenses.Size = new Size(235, 58);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showLicenseInfoToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            showLicenseInfoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            showLicenseInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(234, 54);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // tpInternationalLicense
            // 
            tpInternationalLicense.Controls.Add(dgvInternationalLicense);
            tpInternationalLicense.Location = new Point(4, 26);
            tpInternationalLicense.Name = "tpInternationalLicense";
            tpInternationalLicense.Padding = new Padding(3);
            tpInternationalLicense.Size = new Size(1158, 177);
            tpInternationalLicense.TabIndex = 1;
            tpInternationalLicense.Text = "International License";
            tpInternationalLicense.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicense
            // 
            dgvInternationalLicense.AllowUserToAddRows = false;
            dgvInternationalLicense.AllowUserToDeleteRows = false;
            dgvInternationalLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInternationalLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicense.ContextMenuStrip = cmsOpOnInternaionalLicense;
            dgvInternationalLicense.Location = new Point(6, 6);
            dgvInternationalLicense.MultiSelect = false;
            dgvInternationalLicense.Name = "dgvInternationalLicense";
            dgvInternationalLicense.ReadOnly = true;
            dgvInternationalLicense.Size = new Size(1146, 165);
            dgvInternationalLicense.TabIndex = 0;
            // 
            // cmsOpOnInternaionalLicense
            // 
            cmsOpOnInternaionalLicense.Items.AddRange(new ToolStripItem[] { showInternaionalLiceseInfoToolStripMenuItem });
            cmsOpOnInternaionalLicense.Name = "cmsOpOnInternaionalLicense";
            cmsOpOnInternaionalLicense.Size = new Size(297, 42);
            // 
            // showInternaionalLiceseInfoToolStripMenuItem
            // 
            showInternaionalLiceseInfoToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showInternaionalLiceseInfoToolStripMenuItem.Image = Properties.Resources.International_32;
            showInternaionalLiceseInfoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            showInternaionalLiceseInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showInternaionalLiceseInfoToolStripMenuItem.Name = "showInternaionalLiceseInfoToolStripMenuItem";
            showInternaionalLiceseInfoToolStripMenuItem.Size = new Size(296, 38);
            showInternaionalLiceseInfoToolStripMenuItem.Text = "Show Internaional Licese Info";
            showInternaionalLiceseInfoToolStripMenuItem.Click += showInternaionalLiceseInfoToolStripMenuItem_Click;
            // 
            // frmShowLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 659);
            Controls.Add(gbDrivingLicense);
            Controls.Add(ctrPersonInfoWithFilter1);
            Controls.Add(pictureBox1);
            Name = "frmShowLicenseHistory";
            Text = "frmShowLicenseHistory";
            Load += frmShowLicenseHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDrivingLicense.ResumeLayout(false);
            LicensesTabs.ResumeLayout(false);
            tpLocalLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLicenses).EndInit();
            cmsOpOnLicenses.ResumeLayout(false);
            tpInternationalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicense).EndInit();
            cmsOpOnInternaionalLicense.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Pepole.ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private GroupBox gbDrivingLicense;
        private TabControl LicensesTabs;
        private TabPage tpLocalLicenses;
        private TabPage tpInternationalLicense;
        private DataGridView dgvLicenses;
        private DataGridView dgvInternationalLicense;
        private ContextMenuStrip cmsOpOnLicenses;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private ContextMenuStrip cmsOpOnInternaionalLicense;
        private ToolStripMenuItem showInternaionalLiceseInfoToolStripMenuItem;
    }
}