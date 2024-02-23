namespace DVDL.Tests
{
    partial class frmSechdualTest
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
            pbTestImage = new PictureBox();
            lbTitle = new Label();
            gbSechdualTest = new GroupBox();
            lbTakedTestTitle = new Label();
            dtDate = new DateTimePicker();
            lbFees = new Label();
            lbTrial = new Label();
            lbName = new Label();
            lbDrivingClass = new Label();
            lbLDLAppID = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lable1 = new Label();
            gbRetakeTestInfo = new GroupBox();
            lbRAppFees = new Label();
            lbRTestAppID = new Label();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            lbTotalFees = new Label();
            pictureBox9 = new PictureBox();
            label9 = new Label();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbTestImage).BeginInit();
            gbSechdualTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbRetakeTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pbTestImage
            // 
            pbTestImage.Image = Properties.Resources.Vision_512;
            pbTestImage.Location = new Point(87, 13);
            pbTestImage.Name = "pbTestImage";
            pbTestImage.Size = new Size(165, 83);
            pbTestImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestImage.TabIndex = 0;
            pbTestImage.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(103, 108);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(142, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Sechdule Test";
            // 
            // gbSechdualTest
            // 
            gbSechdualTest.Controls.Add(lbTakedTestTitle);
            gbSechdualTest.Controls.Add(dtDate);
            gbSechdualTest.Controls.Add(lbFees);
            gbSechdualTest.Controls.Add(lbTrial);
            gbSechdualTest.Controls.Add(lbName);
            gbSechdualTest.Controls.Add(lbDrivingClass);
            gbSechdualTest.Controls.Add(lbLDLAppID);
            gbSechdualTest.Controls.Add(pictureBox7);
            gbSechdualTest.Controls.Add(label6);
            gbSechdualTest.Controls.Add(pictureBox6);
            gbSechdualTest.Controls.Add(label5);
            gbSechdualTest.Controls.Add(pictureBox5);
            gbSechdualTest.Controls.Add(label4);
            gbSechdualTest.Controls.Add(pictureBox4);
            gbSechdualTest.Controls.Add(label3);
            gbSechdualTest.Controls.Add(pictureBox3);
            gbSechdualTest.Controls.Add(label2);
            gbSechdualTest.Controls.Add(pictureBox2);
            gbSechdualTest.Controls.Add(lable1);
            gbSechdualTest.Controls.Add(pbTestImage);
            gbSechdualTest.Controls.Add(lbTitle);
            gbSechdualTest.Location = new Point(4, 12);
            gbSechdualTest.Name = "gbSechdualTest";
            gbSechdualTest.Size = new Size(397, 386);
            gbSechdualTest.TabIndex = 2;
            gbSechdualTest.TabStop = false;
            gbSechdualTest.Text = "Vision Test";
            // 
            // lbTakedTestTitle
            // 
            lbTakedTestTitle.AutoSize = true;
            lbTakedTestTitle.Font = new Font("Segoe UI", 12F);
            lbTakedTestTitle.ForeColor = Color.Maroon;
            lbTakedTestTitle.Location = new Point(50, 138);
            lbTakedTestTitle.Name = "lbTakedTestTitle";
            lbTakedTestTitle.Size = new Size(240, 21);
            lbTakedTestTitle.TabIndex = 21;
            lbTakedTestTitle.Text = "This Test Has Been Already Taken ";
            lbTakedTestTitle.Visible = false;
            // 
            // dtDate
            // 
            dtDate.CustomFormat = "dd-mm-yy";
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(80, 316);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(106, 23);
            dtDate.TabIndex = 20;
            // 
            // lbFees
            // 
            lbFees.AutoSize = true;
            lbFees.Font = new Font("Segoe UI", 12F);
            lbFees.Location = new Point(87, 350);
            lbFees.Name = "lbFees";
            lbFees.Size = new Size(19, 21);
            lbFees.TabIndex = 19;
            lbFees.Text = "0";
            // 
            // lbTrial
            // 
            lbTrial.AutoSize = true;
            lbTrial.Font = new Font("Segoe UI", 12F);
            lbTrial.Location = new Point(87, 280);
            lbTrial.Name = "lbTrial";
            lbTrial.Size = new Size(19, 21);
            lbTrial.TabIndex = 17;
            lbTrial.Text = "0";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F);
            lbName.Location = new Point(87, 249);
            lbName.Name = "lbName";
            lbName.Size = new Size(41, 21);
            lbName.TabIndex = 16;
            lbName.Text = "[???]";
            // 
            // lbDrivingClass
            // 
            lbDrivingClass.AutoSize = true;
            lbDrivingClass.Font = new Font("Segoe UI", 12F);
            lbDrivingClass.Location = new Point(128, 213);
            lbDrivingClass.Name = "lbDrivingClass";
            lbDrivingClass.Size = new Size(41, 21);
            lbDrivingClass.TabIndex = 15;
            lbDrivingClass.Text = "[???]";
            // 
            // lbLDLAppID
            // 
            lbLDLAppID.AutoSize = true;
            lbLDLAppID.Font = new Font("Segoe UI", 12F);
            lbLDLAppID.Location = new Point(112, 175);
            lbLDLAppID.Name = "lbLDLAppID";
            lbLDLAppID.Size = new Size(41, 21);
            lbLDLAppID.TabIndex = 14;
            lbLDLAppID.Text = "[???]";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.money_32;
            pictureBox7.Location = new Point(50, 350);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(19, 19);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(8, 350);
            label6.Name = "label6";
            label6.Size = new Size(39, 19);
            label6.TabIndex = 12;
            label6.Text = "Fees:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(50, 316);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(19, 19);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(8, 316);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 10;
            label5.Text = "Date:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Count_32;
            pictureBox5.Location = new Point(50, 280);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(8, 280);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 8;
            label4.Text = "Trial:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Person_32;
            pictureBox4.Location = new Point(62, 249);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(8, 249);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LocalDriving_License;
            pictureBox3.Location = new Point(103, 213);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(8, 213);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 4;
            label2.Text = "Driving Class:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(80, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Segoe UI", 10F);
            lable1.Location = new Point(8, 175);
            lable1.Name = "lable1";
            lable1.Size = new Size(75, 19);
            lable1.TabIndex = 2;
            lable1.Text = "LDLAppID:";
            // 
            // gbRetakeTestInfo
            // 
            gbRetakeTestInfo.Controls.Add(lbRAppFees);
            gbRetakeTestInfo.Controls.Add(lbRTestAppID);
            gbRetakeTestInfo.Controls.Add(pictureBox10);
            gbRetakeTestInfo.Controls.Add(label11);
            gbRetakeTestInfo.Controls.Add(lbTotalFees);
            gbRetakeTestInfo.Controls.Add(pictureBox9);
            gbRetakeTestInfo.Controls.Add(label9);
            gbRetakeTestInfo.Controls.Add(pictureBox8);
            gbRetakeTestInfo.Controls.Add(label7);
            gbRetakeTestInfo.Enabled = false;
            gbRetakeTestInfo.Location = new Point(12, 416);
            gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            gbRetakeTestInfo.Size = new Size(389, 128);
            gbRetakeTestInfo.TabIndex = 3;
            gbRetakeTestInfo.TabStop = false;
            gbRetakeTestInfo.Text = "Retake Test Info";
            // 
            // lbRAppFees
            // 
            lbRAppFees.AutoSize = true;
            lbRAppFees.Font = new Font("Segoe UI", 12F);
            lbRAppFees.Location = new Point(120, 31);
            lbRAppFees.Name = "lbRAppFees";
            lbRAppFees.Size = new Size(19, 21);
            lbRAppFees.TabIndex = 28;
            lbRAppFees.Text = "0";
            // 
            // lbRTestAppID
            // 
            lbRTestAppID.AutoSize = true;
            lbRTestAppID.Font = new Font("Segoe UI", 12F);
            lbRTestAppID.Location = new Point(135, 61);
            lbRTestAppID.Name = "lbRTestAppID";
            lbRTestAppID.Size = new Size(38, 21);
            lbRTestAppID.TabIndex = 27;
            lbRTestAppID.Text = "N/A";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Number_32;
            pictureBox10.Location = new Point(103, 61);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(26, 19);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(6, 61);
            label11.Name = "label11";
            label11.Size = new Size(95, 19);
            label11.TabIndex = 25;
            label11.Text = "R Test App ID:";
            // 
            // lbTotalFees
            // 
            lbTotalFees.AutoSize = true;
            lbTotalFees.Font = new Font("Segoe UI", 12F);
            lbTotalFees.Location = new Point(297, 26);
            lbTotalFees.Name = "lbTotalFees";
            lbTotalFees.Size = new Size(19, 21);
            lbTotalFees.TabIndex = 24;
            lbTotalFees.Text = "0";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.money_32;
            pictureBox9.Location = new Point(272, 29);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(19, 19);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(194, 29);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 22;
            label9.Text = "Total Fees:";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.money_32;
            pictureBox8.Location = new Point(95, 31);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(19, 19);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 3;
            label7.Text = "R App Fees:";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(294, 556);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(28, 556);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmSechdualTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 598);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(gbRetakeTestInfo);
            Controls.Add(gbSechdualTest);
            Name = "frmSechdualTest";
            Text = "frmSechdualTest";
            Load += frmVisionTest_Load;
            ((System.ComponentModel.ISupportInitialize)pbTestImage).EndInit();
            gbSechdualTest.ResumeLayout(false);
            gbSechdualTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbRetakeTestInfo.ResumeLayout(false);
            gbRetakeTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbTestImage;
        private Label lbTitle;
        private GroupBox gbSechdualTest;
        private Label lable1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox7;
        private Label lbDrivingClass;
        private Label lbLDLAppID;
        private Label lbFees;
        private Label lbTrial;
        private Label lbName;
        private GroupBox gbRetakeTestInfo;
        private DateTimePicker dtDate;
        private Label label7;
        private PictureBox pictureBox8;
        private Label lbTotalFees;
        private PictureBox pictureBox9;
        private Label label9;
        private Label lbRTestAppID;
        private PictureBox pictureBox10;
        private Label label11;
        private Label lbRAppFees;
        private Button btnSave;
        private Button btnClose;
        private Label lbTakedTestTitle;
    }
}