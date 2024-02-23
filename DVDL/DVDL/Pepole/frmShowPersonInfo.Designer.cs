namespace DVDL.Pepole
{
    partial class frmShowPersonInfo
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
            ctrPersonInfo1 = new ctrPersonInfo();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrPersonInfo1
            // 
            ctrPersonInfo1.AutoScroll = true;
            ctrPersonInfo1.AutoSize = true;
            ctrPersonInfo1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ctrPersonInfo1.Location = new Point(12, 134);
            ctrPersonInfo1.Name = "ctrPersonInfo1";
            ctrPersonInfo1.Size = new Size(827, 241);
            ctrPersonInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "Person Information";
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(961, 385);
            Controls.Add(label1);
            Controls.Add(ctrPersonInfo1);
            Name = "frmShowPersonInfo";
            Text = "frmShowPersonInfo";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrPersonInfo ctrPersonInfo1;
        private Label label1;
    }
}