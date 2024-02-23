namespace DVDL.Tests
{
    partial class frmManageTestType
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
            lbTitle = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            lable1 = new Label();
            lbTotalRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(281, 257);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(200, 30);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(135, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(747, 150);
            dataGridView1.TabIndex = 2;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable1.Location = new Point(23, 455);
            lable1.Name = "lable1";
            lable1.Size = new Size(109, 21);
            lable1.TabIndex = 3;
            lable1.Text = "TotalRecords:";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(135, 455);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(19, 21);
            lbTotalRecords.TabIndex = 4;
            lbTotalRecords.Text = "0";
            // 
            // frmManageTestType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(lbTotalRecords);
            Controls.Add(lable1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(lbTitle);
            Name = "frmManageTestType";
            Text = "frmManageTestType";
            Load += frmManageTestType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lable1;
        private Label lbTotalRecords;
    }
}