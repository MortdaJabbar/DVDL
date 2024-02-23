namespace DVDL.Users
{
    partial class frmAddUpdateUser
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
            Tabs = new TabControl();
            PersonInfoTab = new TabPage();
            btnNext = new Button();
            ctrPersonInfoWithFilter1 = new Pepole.ctrPersonInfoWithFilter();
            UserInfoTab = new TabPage();
            btnClose = new Button();
            btnSave = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lbUserID = new Label();
            chkisActive = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            Tabs.SuspendLayout();
            PersonInfoTab.SuspendLayout();
            UserInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Firebrick;
            lbTitle.Location = new Point(310, 22);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(83, 19);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add User";
            // 
            // Tabs
            // 
            Tabs.Controls.Add(PersonInfoTab);
            Tabs.Controls.Add(UserInfoTab);
            Tabs.Location = new Point(12, 44);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1070, 508);
            Tabs.TabIndex = 1;
            // 
            // PersonInfoTab
            // 
            PersonInfoTab.BackColor = SystemColors.Control;
            PersonInfoTab.Controls.Add(btnNext);
            PersonInfoTab.Controls.Add(ctrPersonInfoWithFilter1);
            PersonInfoTab.Font = new Font("Sitka Heading", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PersonInfoTab.Location = new Point(4, 24);
            PersonInfoTab.Name = "PersonInfoTab";
            PersonInfoTab.Padding = new Padding(3);
            PersonInfoTab.Size = new Size(1062, 480);
            PersonInfoTab.TabIndex = 0;
            PersonInfoTab.Text = "PersonInfo";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.ImageAlign = ContentAlignment.BottomLeft;
            btnNext.Location = new Point(787, 432);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(93, 42);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrPersonInfoWithFilter1
            // 
            ctrPersonInfoWithFilter1.FilterValue = "";
            ctrPersonInfoWithFilter1.GbFilterEnable = true;
            ctrPersonInfoWithFilter1.Location = new Point(6, 6);
            ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            ctrPersonInfoWithFilter1.Size = new Size(899, 400);
            ctrPersonInfoWithFilter1.TabIndex = 0;
            ctrPersonInfoWithFilter1.OnPersonSelected += ctrPersonInfoWithFilter1_OnPersonSelected;
            ctrPersonInfoWithFilter1.OnPersonAdded += ctrPersonInfoWithFilter1_OnPersonAdded;
            // 
            // UserInfoTab
            // 
            UserInfoTab.BackColor = SystemColors.Control;
            UserInfoTab.Controls.Add(btnClose);
            UserInfoTab.Controls.Add(btnSave);
            UserInfoTab.Controls.Add(txtConfirmPassword);
            UserInfoTab.Controls.Add(txtPassword);
            UserInfoTab.Controls.Add(txtUserName);
            UserInfoTab.Controls.Add(lbUserID);
            UserInfoTab.Controls.Add(chkisActive);
            UserInfoTab.Controls.Add(label4);
            UserInfoTab.Controls.Add(label3);
            UserInfoTab.Controls.Add(label2);
            UserInfoTab.Controls.Add(label1);
            UserInfoTab.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserInfoTab.Location = new Point(4, 24);
            UserInfoTab.Name = "UserInfoTab";
            UserInfoTab.Padding = new Padding(3);
            UserInfoTab.Size = new Size(192, 72);
            UserInfoTab.TabIndex = 1;
            UserInfoTab.Text = "UserInfo";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(733, 430);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(108, 44);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(867, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 44);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            txtConfirmPassword.Location = new Point(182, 137);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(154, 25);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.Validating += txtConfirmPassword_Validation;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            txtPassword.Location = new Point(125, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(154, 25);
            txtPassword.TabIndex = 8;
            txtPassword.Validating += txtPassword_Validation;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            txtUserName.Location = new Point(125, 65);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(154, 25);
            txtUserName.TabIndex = 7;
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Font = new Font("Georgia", 12F, FontStyle.Italic);
            lbUserID.Location = new Point(100, 32);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(32, 18);
            lbUserID.TabIndex = 6;
            lbUserID.Text = "???";
            // 
            // chkisActive
            // 
            chkisActive.AutoSize = true;
            chkisActive.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold | FontStyle.Italic);
            chkisActive.Location = new Point(28, 174);
            chkisActive.Name = "chkisActive";
            chkisActive.Size = new Size(89, 27);
            chkisActive.TabIndex = 5;
            chkisActive.Text = "IsActive";
            chkisActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Italic);
            label4.Location = new Point(28, 137);
            label4.Name = "label4";
            label4.Size = new Size(148, 18);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Italic);
            label3.Location = new Point(28, 101);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Italic);
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 1;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Italic);
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 0;
            label1.Text = "UserID:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 564);
            Controls.Add(Tabs);
            Controls.Add(lbTitle);
            Name = "frmAddUpdateUser";
            Text = "frmAddUpdateUser";
            Load += frmAddUpdateUser_Load;
            Tabs.ResumeLayout(false);
            PersonInfoTab.ResumeLayout(false);
            UserInfoTab.ResumeLayout(false);
            UserInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TabControl Tabs;
        private TabPage PersonInfoTab;
        private TabPage UserInfoTab;
        private Pepole.ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkisActive;
        private Label lbUserID;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ErrorProvider errorProvider1;
        private Button btnSave;
        private Button btnClose;
    }
}