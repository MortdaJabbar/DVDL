namespace DVDL.Users
{
    partial class ctrUserInfo
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
            ctrPersonInfo1 = new Pepole.ctrPersonInfo();
            groupBox1 = new GroupBox();
            lbIsActive = new Label();
            lbUserID = new Label();
            lbUserName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrPersonInfo1
            // 
            ctrPersonInfo1.Location = new Point(3, 3);
            ctrPersonInfo1.Name = "ctrPersonInfo1";
            ctrPersonInfo1.Size = new Size(826, 318);
            ctrPersonInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbIsActive);
            groupBox1.Controls.Add(lbUserID);
            groupBox1.Controls.Add(lbUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(832, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User";
            // 
            // lbIsActive
            // 
            lbIsActive.AutoSize = true;
            lbIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbIsActive.Location = new Point(621, 63);
            lbIsActive.Name = "lbIsActive";
            lbIsActive.Size = new Size(31, 21);
            lbIsActive.TabIndex = 5;
            lbIsActive.Text = "???";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbUserID.Location = new Point(344, 63);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(31, 21);
            lbUserID.TabIndex = 4;
            lbUserID.Text = "???";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbUserName.Location = new Point(99, 63);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(31, 21);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(549, 63);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "IsActive:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(278, 63);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 1;
            label2.Text = "UserID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // ctrUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrPersonInfo1);
            Name = "ctrUserInfo";
            Size = new Size(1021, 480);
            Load += ctrUserInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Pepole.ctrPersonInfo ctrPersonInfo1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbUserName;
        private Label lbUserID;
        private Label lbIsActive;
    }
}
