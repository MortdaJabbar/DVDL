namespace DVDL
{
    partial class frmMangeLicense
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgvLicenses = new DataGridView();
            cbFilter = new ComboBox();
            label2 = new Label();
            lbTotalRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(293, 197);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = " Driving Licenses";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(206, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Driver_License_48;
            pictureBox2.Location = new Point(448, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dgvLicenses
            // 
            dgvLicenses.AllowUserToAddRows = false;
            dgvLicenses.AllowUserToDeleteRows = false;
            dgvLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicenses.Location = new Point(12, 251);
            dgvLicenses.Name = "dgvLicenses";
            dgvLicenses.ReadOnly = true;
            dgvLicenses.Size = new Size(776, 159);
            dgvLicenses.TabIndex = 3;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "LiceneseID" });
            cbFilter.Location = new Point(14, 222);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 420);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 5;
            label2.Text = "TotalRecords:";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI", 12F);
            lbTotalRecords.Location = new Point(116, 420);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(19, 21);
            lbTotalRecords.TabIndex = 6;
            lbTotalRecords.Text = "0";
            // 
            // frmMangeLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTotalRecords);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(dgvLicenses);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmMangeLicense";
            Text = "frmManageInternationalLicense";
            Load += frmMangeLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvLicenses;
        private ComboBox cbFilter;
        private Label label2;
        private Label lbTotalRecords;
    }
}