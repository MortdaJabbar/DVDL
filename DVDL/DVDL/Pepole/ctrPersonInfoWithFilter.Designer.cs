namespace DVDL.Pepole
{
    partial class ctrPersonInfoWithFilter
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
            ctrPersonInfo1 = new ctrPersonInfo();
            groupBox1 = new GroupBox();
            pbAddNew = new PictureBox();
            pbFind = new PictureBox();
            txtFilter = new TextBox();
            cbFilter = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFind).BeginInit();
            SuspendLayout();
            // 
            // ctrPersonInfo1
            // 
            ctrPersonInfo1.Location = new Point(51, 132);
            ctrPersonInfo1.Name = "ctrPersonInfo1";
            ctrPersonInfo1.Size = new Size(862, 274);
            ctrPersonInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbAddNew);
            groupBox1.Controls.Add(pbFind);
            groupBox1.Controls.Add(txtFilter);
            groupBox1.Controls.Add(cbFilter);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // pbAddNew
            // 
            pbAddNew.BorderStyle = BorderStyle.FixedSingle;
            pbAddNew.Image = Properties.Resources.Add_Person_40;
            pbAddNew.Location = new Point(452, 62);
            pbAddNew.Name = "pbAddNew";
            pbAddNew.Size = new Size(59, 38);
            pbAddNew.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNew.TabIndex = 3;
            pbAddNew.TabStop = false;
            pbAddNew.Click += pbAddNew_Click;
            // 
            // pbFind
            // 
            pbFind.BorderStyle = BorderStyle.FixedSingle;
            pbFind.Image = Properties.Resources.SearchPerson;
            pbFind.Location = new Point(376, 62);
            pbFind.Name = "pbFind";
            pbFind.Size = new Size(59, 38);
            pbFind.SizeMode = PictureBoxSizeMode.Zoom;
            pbFind.TabIndex = 2;
            pbFind.TabStop = false;
            pbFind.Click += pbFind_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(173, 71);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(177, 29);
            txtFilter.TabIndex = 1;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "PersonID", "NationalNo" });
            cbFilter.Location = new Point(16, 71);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 29);
            cbFilter.TabIndex = 0;
            // 
            // ctrPersonInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrPersonInfo1);
            Name = "ctrPersonInfoWithFilter";
            Size = new Size(957, 381);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFind).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrPersonInfo ctrPersonInfo1;
        private GroupBox groupBox1;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private PictureBox pbFind;
        private PictureBox pbAddNew;
    }
}
