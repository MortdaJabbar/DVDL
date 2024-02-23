namespace DVDL.Users
{
    partial class frmLoginUser
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
            pictureBox1 = new PictureBox();
            lbTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ckRememberMe = new CheckBox();
            btnLogin = new Button();
            errorProvider1 = new ErrorProvider(components);
            pbClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WallPaper2;
            pictureBox1.Location = new Point(-14, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(564, 51);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(126, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "System Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(500, 161);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 2;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(505, 190);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User_32__2;
            pictureBox2.Location = new Point(477, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(477, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(580, 160);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(178, 23);
            txtUserName.TabIndex = 6;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(580, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 7;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // ckRememberMe
            // 
            ckRememberMe.AutoSize = true;
            ckRememberMe.Checked = true;
            ckRememberMe.CheckState = CheckState.Checked;
            ckRememberMe.Font = new Font("Segoe UI", 11F);
            ckRememberMe.Location = new Point(477, 229);
            ckRememberMe.Name = "ckRememberMe";
            ckRememberMe.Size = new Size(126, 24);
            ckRememberMe.TabIndex = 8;
            ckRememberMe.Text = "Remember Me";
            ckRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(564, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 39);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.Close_64;
            pbClose.Location = new Point(747, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(41, 31);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 10;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // frmLoginUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(pbClose);
            Controls.Add(btnLogin);
            Controls.Add(ckRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginUser";
            Load += frmLoginUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbTitle;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private CheckBox ckRememberMe;
        private Button btnLogin;
        private ErrorProvider errorProvider1;
        private PictureBox pbClose;
    }
}