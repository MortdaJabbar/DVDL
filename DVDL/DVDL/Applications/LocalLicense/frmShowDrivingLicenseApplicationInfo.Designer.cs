namespace DVDL.Applications.LocalLicense
{
    partial class frmShowDrivingLicenseApplicationInfo
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
            button1 = new Button();
            SuspendLayout();
            // 
            // ctrLocalDrivingLicenseCard1
            // 
            ctrLocalDrivingLicenseCard1.LocalDrivingLicenseID = -1;
            ctrLocalDrivingLicenseCard1.Location = new Point(41, 62);
            ctrLocalDrivingLicenseCard1.Name = "ctrLocalDrivingLicenseCard1";
            ctrLocalDrivingLicenseCard1.Size = new Size(724, 354);
            ctrLocalDrivingLicenseCard1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Maroon;
            lbTitle.Location = new Point(219, 29);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(277, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Driving License Application ";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(326, 411);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmShowDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(button1);
            Controls.Add(lbTitle);
            Controls.Add(ctrLocalDrivingLicenseCard1);
            Name = "frmShowDrivingLicenseApplicationInfo";
            Text = "frmShowDrivingLicenseApplicationInfo";
            Load += frmShowDrivingLicenseApplicationInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrLocalDrivingLicenseCard ctrLocalDrivingLicenseCard1;
        private Label lbTitle;
        private Button button1;
    }
}