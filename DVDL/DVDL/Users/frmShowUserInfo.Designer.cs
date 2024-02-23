namespace DVDL.Users
{
    partial class frmShowUserInfo
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
            ctrUserInfo1 = new ctrUserInfo();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrUserInfo1
            // 
            ctrUserInfo1.Location = new Point(12, 124);
            ctrUserInfo1.Name = "ctrUserInfo1";
            ctrUserInfo1.Size = new Size(941, 463);
            ctrUserInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(397, 60);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 1;
            label1.Text = "User Information";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(731, 597);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 36);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 658);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrUserInfo1);
            Name = "frmShowUserInfo";
            Text = "frmShowUserInfo";
            Load += frmShowUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrUserInfo ctrUserInfo1;
        private Label label1;
        private Button btnClose;
    }
}