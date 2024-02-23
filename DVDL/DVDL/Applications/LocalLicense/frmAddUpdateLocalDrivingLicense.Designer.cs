namespace DVDL.Applications.LocalLicense
{
    partial class frmAddUpdateLocalDrivingLicense
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
            lbTitle = new Label();
            Tabs = new TabControl();
            PersonInfoTab = new TabPage();
            btnNext = new Button();
            ctrPersonInfoWithFilter1 = new Pepole.ctrPersonInfoWithFilter();
            ApplicationInfoTab = new TabPage();
            btnSave = new Button();
            lbCreatedBy = new Label();
            lbApplicationFees = new Label();
            cbLicenseClasses = new ComboBox();
            lbApplicationDate = new Label();
            lbID = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            Tabs.SuspendLayout();
            PersonInfoTab.SuspendLayout();
            ApplicationInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Brown;
            lbTitle.Location = new Point(219, 26);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(338, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "New Local Driving License Application";
            // 
            // Tabs
            // 
            Tabs.Controls.Add(PersonInfoTab);
            Tabs.Controls.Add(ApplicationInfoTab);
            Tabs.Location = new Point(12, 64);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(942, 490);
            Tabs.TabIndex = 1;
            // 
            // PersonInfoTab
            // 
            PersonInfoTab.Controls.Add(btnNext);
            PersonInfoTab.Controls.Add(ctrPersonInfoWithFilter1);
            PersonInfoTab.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonInfoTab.Location = new Point(4, 24);
            PersonInfoTab.Name = "PersonInfoTab";
            PersonInfoTab.Padding = new Padding(3);
            PersonInfoTab.Size = new Size(934, 462);
            PersonInfoTab.TabIndex = 0;
            PersonInfoTab.Text = "PersonInfo";
            PersonInfoTab.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.FlatAppearance.BorderColor = Color.Black;
            btnNext.FlatAppearance.BorderSize = 2;
            btnNext.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(812, 421);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(85, 38);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrPersonInfoWithFilter1
            // 
            ctrPersonInfoWithFilter1.Location = new Point(-6, 3);
            ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            ctrPersonInfoWithFilter1.Size = new Size(934, 342);
            ctrPersonInfoWithFilter1.TabIndex = 0;
            ctrPersonInfoWithFilter1.OnPersonSelected += ctrPersonInfoWithFilter1_OnPersonSelected;
            ctrPersonInfoWithFilter1.OnPersonAdded += ctrPersonInfoWithFilter1_OnPersonAdded;
            // 
            // ApplicationInfoTab
            // 
            ApplicationInfoTab.Controls.Add(btnSave);
            ApplicationInfoTab.Controls.Add(lbCreatedBy);
            ApplicationInfoTab.Controls.Add(lbApplicationFees);
            ApplicationInfoTab.Controls.Add(cbLicenseClasses);
            ApplicationInfoTab.Controls.Add(lbApplicationDate);
            ApplicationInfoTab.Controls.Add(lbID);
            ApplicationInfoTab.Controls.Add(pictureBox5);
            ApplicationInfoTab.Controls.Add(pictureBox4);
            ApplicationInfoTab.Controls.Add(pictureBox3);
            ApplicationInfoTab.Controls.Add(pictureBox2);
            ApplicationInfoTab.Controls.Add(pictureBox1);
            ApplicationInfoTab.Controls.Add(label5);
            ApplicationInfoTab.Controls.Add(label4);
            ApplicationInfoTab.Controls.Add(label3);
            ApplicationInfoTab.Controls.Add(label2);
            ApplicationInfoTab.Controls.Add(label1);
            ApplicationInfoTab.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicationInfoTab.Location = new Point(4, 24);
            ApplicationInfoTab.Name = "ApplicationInfoTab";
            ApplicationInfoTab.Padding = new Padding(3);
            ApplicationInfoTab.Size = new Size(934, 462);
            ApplicationInfoTab.TabIndex = 1;
            ApplicationInfoTab.Text = "ApplicationInfo";
            ApplicationInfoTab.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(843, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 38);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbCreatedBy.Location = new Point(183, 224);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(41, 21);
            lbCreatedBy.TabIndex = 14;
            lbCreatedBy.Text = "[???]";
            // 
            // lbApplicationFees
            // 
            lbApplicationFees.AutoSize = true;
            lbApplicationFees.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbApplicationFees.Location = new Point(183, 180);
            lbApplicationFees.Name = "lbApplicationFees";
            lbApplicationFees.Size = new Size(41, 21);
            lbApplicationFees.TabIndex = 13;
            lbApplicationFees.Text = "[???]";
            // 
            // cbLicenseClasses
            // 
            cbLicenseClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClasses.FlatStyle = FlatStyle.Flat;
            cbLicenseClasses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbLicenseClasses.FormattingEnabled = true;
            cbLicenseClasses.Location = new Point(183, 132);
            cbLicenseClasses.Name = "cbLicenseClasses";
            cbLicenseClasses.Size = new Size(294, 29);
            cbLicenseClasses.TabIndex = 12;
            // 
            // lbApplicationDate
            // 
            lbApplicationDate.AutoSize = true;
            lbApplicationDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbApplicationDate.Location = new Point(183, 84);
            lbApplicationDate.Name = "lbApplicationDate";
            lbApplicationDate.Size = new Size(41, 21);
            lbApplicationDate.TabIndex = 11;
            lbApplicationDate.Text = "[???]";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbID.Location = new Point(183, 35);
            lbID.Name = "lbID";
            lbID.Size = new Size(41, 21);
            lbID.TabIndex = 10;
            lbID.Text = "[???]";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User_32__2;
            pictureBox5.Location = new Point(145, 224);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(145, 180);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.License_Type_32;
            pictureBox3.Location = new Point(135, 130);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(145, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(145, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(6, 224);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 4;
            label5.Text = "Created By: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 180);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 3;
            label4.Text = "ApplicationFees: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "LicenseClass: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 1;
            label2.Text = "ApplicationDate: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "D.L.ApplicationID: ";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(819, 574);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddUpdateLocalDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 616);
            Controls.Add(btnClose);
            Controls.Add(Tabs);
            Controls.Add(lbTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddUpdateLocalDrivingLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateLocalDrivingLicense";
            Load += frmAddUpdateLocalDrivingLicense_Load;
            Tabs.ResumeLayout(false);
            PersonInfoTab.ResumeLayout(false);
            ApplicationInfoTab.ResumeLayout(false);
            ApplicationInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TabControl Tabs;
        private TabPage PersonInfoTab;
        private TabPage ApplicationInfoTab;
        private Pepole.ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lbID;
        private Label lbApplicationDate;
        private ComboBox cbLicenseClasses;
        private Label lbApplicationFees;
        private Label lbCreatedBy;
        private Button btnNext;
        private Button btnClose;
        private Button btnSave;
    }
}