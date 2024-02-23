namespace DVDL.InternationalLicense
{
    partial class frmShowInternationalLicense
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
            ctrInternationalLicense1 = new ctrInternationalLicense();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrInternationalLicense1
            // 
            ctrInternationalLicense1.Location = new Point(12, 229);
            ctrInternationalLicense1.Name = "ctrInternationalLicense1";
            ctrInternationalLicense1.Size = new Size(687, 199);
            ctrInternationalLicense1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(200, 201);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 1;
            label1.Text = "Show International License Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseView_400;
            pictureBox1.Location = new Point(89, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(537, 434);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 41);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 478);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ctrInternationalLicense1);
            Name = "frmShowInternationalLicense";
            Text = "frmShowInternationalLicense";
            Load += frmShowInternationalLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrInternationalLicense ctrInternationalLicense1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnClose;
    }
}