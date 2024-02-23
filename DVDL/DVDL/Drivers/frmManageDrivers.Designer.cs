namespace DVDL.Drivers
{
    partial class frmManageDrivers
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
            label1 = new Label();
            dgvDrivers = new DataGridView();
            cmsOperation = new ContextMenuStrip(components);
            showPersonDetialsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lbTotalRecords = new Label();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            cmsOperation.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Driver_Main;
            pictureBox1.Location = new Point(209, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(297, 229);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 1;
            label1.Text = "Manage Drivers";
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrivers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.ContextMenuStrip = cmsOperation;
            dgvDrivers.Location = new Point(12, 299);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(776, 160);
            dgvDrivers.TabIndex = 2;
            // 
            // cmsOperation
            // 
            cmsOperation.Items.AddRange(new ToolStripItem[] { showPersonDetialsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmsOperation.Name = "cmsOperation";
            cmsOperation.Size = new Size(293, 80);
            // 
            // showPersonDetialsToolStripMenuItem
            // 
            showPersonDetialsToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showPersonDetialsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetialsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetialsToolStripMenuItem.Name = "showPersonDetialsToolStripMenuItem";
            showPersonDetialsToolStripMenuItem.Size = new Size(292, 38);
            showPersonDetialsToolStripMenuItem.Text = "Show Person Detials";
            showPersonDetialsToolStripMenuItem.Click += showPersonDetialsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(292, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 466);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 3;
            label2.Text = "#Records: ";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(116, 471);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(23, 25);
            lbTotalRecords.TabIndex = 4;
            lbTotalRecords.Text = "0";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Segoe UI", 10F);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "DriverID", "NationalNo" });
            cbFilter.Location = new Point(18, 270);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 25);
            cbFilter.TabIndex = 5;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(145, 270);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(157, 23);
            txtFilter.TabIndex = 6;
            txtFilter.KeyDown += txtFilter_KeyDown;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // frmManageDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(lbTotalRecords);
            Controls.Add(label2);
            Controls.Add(dgvDrivers);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmManageDrivers";
            Text = "frmManageDrivers";
            Load += frmManageDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            cmsOperation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvDrivers;
        private Label label2;
        private Label lbTotalRecords;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private ContextMenuStrip cmsOperation;
        private ToolStripMenuItem showPersonDetialsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}