namespace DVDL.Pepole
{
    partial class frmAddUpdatePerson
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
            lbTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtThirdName = new TextBox();
            txtFourthName = new TextBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            txtNationalNo = new TextBox();
            txtPhone = new TextBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            txtEmail = new TextBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            txtAddress = new TextBox();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            cbCountry = new ComboBox();
            label11 = new Label();
            PersonImage = new PictureBox();
            llSetImage = new LinkLabel();
            llRemoveImage = new LinkLabel();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnSave = new Button();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label12 = new Label();
            lbPersonID = new Label();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonImage).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(289, 32);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(154, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add New Person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 77);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 48);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 2;
            label2.Text = "FirstName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(317, 51);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 3;
            label3.Text = "SecondName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(493, 51);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 4;
            label4.Text = "ThirdName:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(663, 51);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 5;
            label5.Text = "FourthName:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(116, 76);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 26);
            txtFirstName.TabIndex = 6;
            txtFirstName.Tag = "First Name";
            txtFirstName.Validating += _EmptyTextBoxValidation;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(307, 76);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(142, 26);
            txtSecondName.TabIndex = 7;
            txtSecondName.Tag = "Second Name";
            txtSecondName.Validating += _EmptyTextBoxValidation;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(477, 77);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(145, 26);
            txtThirdName.TabIndex = 8;
            // 
            // txtFourthName
            // 
            txtFourthName.Location = new Point(663, 79);
            txtFourthName.Name = "txtFourthName";
            txtFourthName.Size = new Size(140, 26);
            txtFourthName.TabIndex = 9;
            txtFourthName.Tag = "FourthName";
            txtFourthName.Validating += _EmptyTextBoxValidation;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Person_32;
            pictureBox1.Location = new Point(73, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(-4, 129);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 11;
            label6.Text = "NationalNo:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(98, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // txtNationalNo
            // 
            txtNationalNo.Location = new Point(130, 131);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(129, 26);
            txtNationalNo.TabIndex = 13;
            txtNationalNo.Tag = "NationalNo";
            txtNationalNo.Validating += _txtNationalNoValidation;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(101, 171);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(158, 26);
            txtPhone.TabIndex = 16;
            txtPhone.Tag = "Phone";
            txtPhone.Validating += _txtPhoneValidation;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Phone_32;
            pictureBox3.Location = new Point(72, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(8, 169);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 14;
            label7.Text = "Phone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(98, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 26);
            txtEmail.TabIndex = 19;
            txtEmail.Validating += _txtEmailValidation;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Email_32;
            pictureBox4.Location = new Point(69, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(8, 212);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 17;
            label8.Text = "Email:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(8, 305);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(641, 72);
            txtAddress.TabIndex = 22;
            txtAddress.Tag = "Address";
            txtAddress.Validating += _EmptyTextBoxValidation;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Address_32;
            pictureBox5.Location = new Point(73, 259);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(1, 261);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 20;
            label9.Text = "Address:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/mm/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(422, 132);
            dateTimePicker1.MaxDate = new DateTime(2006, 1, 1, 22, 55, 31, 663);
            dateTimePicker1.MinDate = new DateTime(1924, 1, 1, 22, 55, 31, 664);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 26);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.Value = new DateTime(2006, 1, 1, 22, 55, 31, 663);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(317, 133);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 24;
            label10.Text = "BirthDate:";
            // 
            // cbCountry
            // 
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(422, 171);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(121, 28);
            cbCountry.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(330, 169);
            label11.Name = "label11";
            label11.Size = new Size(75, 23);
            label11.TabIndex = 26;
            label11.Text = "Country:";
            // 
            // PersonImage
            // 
            PersonImage.Image = Properties.Resources.Male_512;
            PersonImage.Location = new Point(663, 132);
            PersonImage.Name = "PersonImage";
            PersonImage.Size = new Size(178, 165);
            PersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            PersonImage.TabIndex = 27;
            PersonImage.TabStop = false;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Font = new Font("Segoe UI", 12F);
            llSetImage.Location = new Point(720, 305);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(79, 21);
            llSetImage.TabIndex = 28;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += _llSetImage_LinkClicked;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Font = new Font("Segoe UI", 12F);
            llRemoveImage.Location = new Point(720, 336);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(67, 21);
            llRemoveImage.TabIndex = 29;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += _llRemoveImage_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PersonImage);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtThirdName);
            groupBox1.Controls.Add(txtFourthName);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(txtNationalNo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 442);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "PersonInfo";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(317, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 36);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(477, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 36);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Woman_32;
            pictureBox7.Location = new Point(337, 259);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(26, 23);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Man_32;
            pictureBox6.Location = new Point(337, 214);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(26, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Microsoft Sans Serif", 12F);
            rbFemale.Location = new Point(369, 259);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 24);
            rbFemale.TabIndex = 31;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += _rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Segoe UI", 12F);
            rbMale.Location = new Point(369, 214);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 25);
            rbMale.TabIndex = 30;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += _rbMale_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 69);
            label12.Name = "label12";
            label12.Size = new Size(95, 25);
            label12.TabIndex = 31;
            label12.Text = "PersonID:";
            // 
            // lbPersonID
            // 
            lbPersonID.AutoSize = true;
            lbPersonID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPersonID.Location = new Point(113, 69);
            lbPersonID.Name = "lbPersonID";
            lbPersonID.Size = new Size(48, 25);
            lbPersonID.TabIndex = 32;
            lbPersonID.Text = "N/A";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(879, 552);
            Controls.Add(lbPersonID);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(lbTitle);
            Name = "frmAddUpdatePerson";
            Text = "frmAddUpdatePerson";
            Load += _frmAddUpdatePerson_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtFourthName;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private TextBox txtNationalNo;
        private TextBox txtPhone;
        private PictureBox pictureBox3;
        private Label label7;
        private TextBox txtEmail;
        private PictureBox pictureBox4;
        private Label label8;
        private TextBox txtAddress;
        private PictureBox pictureBox5;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private ComboBox cbCountry;
        private Label label11;
        private PictureBox PersonImage;
        private LinkLabel llSetImage;
        private LinkLabel llRemoveImage;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label label12;
        private Label lbPersonID;
        private OpenFileDialog openFileDialog1;
        public ErrorProvider errorProvider1;
        private Button btnSave;
        private Button btnClose;
    }
}