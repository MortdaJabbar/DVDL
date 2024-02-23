namespace DVDL.Pepole
{
    partial class frmFindAddPerson
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
            label1 = new Label();
            ctrPersonInfoWithFilter1 = new ctrPersonInfoWithFilter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "Find User";
            // 
            // ctrPersonInfoWithFilter1
            // 
            ctrPersonInfoWithFilter1.Location = new Point(2, 44);
            ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            ctrPersonInfoWithFilter1.Size = new Size(957, 412);
            ctrPersonInfoWithFilter1.TabIndex = 1;
            // 
            // frmFindAddPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 474);
            Controls.Add(ctrPersonInfoWithFilter1);
            Controls.Add(label1);
            Name = "frmFindAddPerson";
            Text = "frmFindAddPerson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
    }
}