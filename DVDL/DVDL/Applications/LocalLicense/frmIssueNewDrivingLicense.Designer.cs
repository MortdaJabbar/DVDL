namespace DVDL.Applications.LocalLicense
{
    partial class frmIssueNewDrivingLicense
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
            ctrLocalDrivingLicenseCard1 = new ctrLocalDrivingLicenseCard();
            lbTitle = new Label();
            txtNotes = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnIssue = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrLocalDrivingLicenseCard1
            // 
            ctrLocalDrivingLicenseCard1.LocalDrivingLicenseID = -1;
            ctrLocalDrivingLicenseCard1.Location = new Point(12, 37);
            ctrLocalDrivingLicenseCard1.Name = "ctrLocalDrivingLicenseCard1";
            ctrLocalDrivingLicenseCard1.Size = new Size(724, 337);
            ctrLocalDrivingLicenseCard1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(218, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(239, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Issue New Driving License ";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(105, 380);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(631, 74);
            txtNotes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 383);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 3;
            label1.Text = "Notes:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(64, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnIssue
            // 
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI", 12F);
            btnIssue.Image = Properties.Resources.Lost_Driving_License_32;
            btnIssue.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssue.Location = new Point(606, 460);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(92, 30);
            btnIssue.TabIndex = 5;
            btnIssue.Text = "Issue";
            btnIssue.TextAlign = ContentAlignment.MiddleRight;
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(489, 460);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 30);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmIssueNewDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 493);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtNotes);
            Controls.Add(lbTitle);
            Controls.Add(ctrLocalDrivingLicenseCard1);
            Name = "frmIssueNewDrivingLicense";
            Text = "frmIssueNewDrivingLicense";
            Load += frmIssueNewDrivingLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrLocalDrivingLicenseCard ctrLocalDrivingLicenseCard1;
        private Label lbTitle;
        private TextBox txtNotes;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnIssue;
        private Button btnClose;
    }
}