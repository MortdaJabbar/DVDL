namespace DVDL.Tests
{
    partial class frmTestAppointment
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
            pbTestPicture = new PictureBox();
            lbTestAppointmentTitle = new Label();
            ctrLocalDrivingLicenseCard1 = new Applications.LocalLicense.ctrLocalDrivingLicenseCard();
            label2 = new Label();
            pbAddNewAppointment = new PictureBox();
            label3 = new Label();
            lbTotalRecords = new Label();
            dgvAppointments = new DataGridView();
            cmsAppointmentOperaions = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbTestPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            cmsAppointmentOperaions.SuspendLayout();
            SuspendLayout();
            // 
            // pbTestPicture
            // 
            pbTestPicture.Image = Properties.Resources.Vision_512;
            pbTestPicture.Location = new Point(247, 12);
            pbTestPicture.Name = "pbTestPicture";
            pbTestPicture.Size = new Size(272, 106);
            pbTestPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestPicture.TabIndex = 0;
            pbTestPicture.TabStop = false;
            // 
            // lbTestAppointmentTitle
            // 
            lbTestAppointmentTitle.AutoSize = true;
            lbTestAppointmentTitle.Font = new Font("Segoe UI", 14F);
            lbTestAppointmentTitle.ForeColor = Color.DarkRed;
            lbTestAppointmentTitle.Location = new Point(277, 134);
            lbTestAppointmentTitle.Name = "lbTestAppointmentTitle";
            lbTestAppointmentTitle.Size = new Size(216, 25);
            lbTestAppointmentTitle.TabIndex = 1;
            lbTestAppointmentTitle.Text = "Vision Test Appointment";
            // 
            // ctrLocalDrivingLicenseCard1
            // 
            ctrLocalDrivingLicenseCard1.LocalDrivingLicenseID = -1;
            ctrLocalDrivingLicenseCard1.Location = new Point(12, 162);
            ctrLocalDrivingLicenseCard1.Name = "ctrLocalDrivingLicenseCard1";
            ctrLocalDrivingLicenseCard1.Size = new Size(733, 346);
            ctrLocalDrivingLicenseCard1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 514);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Appointments:";
            // 
            // pbAddNewAppointment
            // 
            pbAddNewAppointment.Image = Properties.Resources.AddAppointment_32;
            pbAddNewAppointment.Location = new Point(713, 514);
            pbAddNewAppointment.Name = "pbAddNewAppointment";
            pbAddNewAppointment.Size = new Size(32, 25);
            pbAddNewAppointment.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewAppointment.TabIndex = 5;
            pbAddNewAppointment.TabStop = false;
            pbAddNewAppointment.Click += pbAddNewAppointment_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 683);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 6;
            label3.Text = "TotalRecords:";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(129, 683);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(40, 20);
            lbTotalRecords.TabIndex = 7;
            lbTotalRecords.Text = "[???]";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.ContextMenuStrip = cmsAppointmentOperaions;
            dgvAppointments.Location = new Point(23, 545);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(722, 124);
            dgvAppointments.TabIndex = 8;
            // 
            // cmsAppointmentOperaions
            // 
            cmsAppointmentOperaions.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            cmsAppointmentOperaions.Name = "cmsAppointmentOperaions";
            cmsAppointmentOperaions.Size = new Size(197, 102);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(196, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_32;
            takeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(196, 38);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // frmTestAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(761, 711);
            Controls.Add(dgvAppointments);
            Controls.Add(lbTotalRecords);
            Controls.Add(label3);
            Controls.Add(pbAddNewAppointment);
            Controls.Add(label2);
            Controls.Add(ctrLocalDrivingLicenseCard1);
            Controls.Add(lbTestAppointmentTitle);
            Controls.Add(pbTestPicture);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmTestAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVisionTest";
            Load += frmVisionTestAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)pbTestPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewAppointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            cmsAppointmentOperaions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTestPicture;
        private Label lbTestAppointmentTitle;
        private Applications.LocalLicense.ctrLocalDrivingLicenseCard ctrLocalDrivingLicenseCard1;
        private Label label2;
        private PictureBox pbAddNewAppointment;
        private Label label3;
        private Label lbTotalRecords;
        private DataGridView dgvAppointments;
        private ContextMenuStrip cmsAppointmentOperaions;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}