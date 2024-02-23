namespace DVDL.Applications.LocalLicense
{
    partial class ctrDrivingLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrDrivingLicenseInfo1 = new ctrDrivingLicenseInfo();
            gbFilter = new GroupBox();
            pbSearch = new PictureBox();
            txtFilter = new TextBox();
            label1 = new Label();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            SuspendLayout();
            // 
            // ctrDrivingLicenseInfo1
            // 
            ctrDrivingLicenseInfo1.Location = new Point(3, 90);
            ctrDrivingLicenseInfo1.Name = "ctrDrivingLicenseInfo1";
            ctrDrivingLicenseInfo1.Size = new Size(711, 318);
            ctrDrivingLicenseInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(pbSearch);
            gbFilter.Controls.Add(txtFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Location = new Point(17, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(679, 81);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // pbSearch
            // 
            pbSearch.BorderStyle = BorderStyle.FixedSingle;
            pbSearch.Image = Properties.Resources.LicenseView_400;
            pbSearch.Location = new Point(399, 22);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(100, 50);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 2;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(92, 31);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(202, 23);
            txtFilter.TabIndex = 1;
            txtFilter.KeyDown += txtFilter_KeyDown;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 0;
            label1.Text = "LicenseID:";
            // 
            // ctrDrivingLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrDrivingLicenseInfo1);
            Name = "ctrDrivingLicenseInfoWithFilter";
            Size = new Size(717, 424);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrDrivingLicenseInfo ctrDrivingLicenseInfo1;
        private GroupBox gbFilter;
        private Label label1;
        private TextBox txtFilter;
        private PictureBox pbSearch;
    }
}
