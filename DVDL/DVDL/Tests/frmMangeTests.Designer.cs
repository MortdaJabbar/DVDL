namespace DVDL.Tests
{
    partial class frmMangeTests
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            cmsEditTestType = new ContextMenuStrip(components);
            editTestTypeToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lbTotalRecord = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmsEditTestType.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(327, 226);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Tests Type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Schedule_Test_512;
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = cmsEditTestType;
            dataGridView1.Location = new Point(22, 299);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 150);
            dataGridView1.TabIndex = 2;
            // 
            // cmsEditTestType
            // 
            cmsEditTestType.Items.AddRange(new ToolStripItem[] { editTestTypeToolStripMenuItem });
            cmsEditTestType.Name = "cmsEditTestType";
            cmsEditTestType.Size = new Size(194, 42);
            // 
            // editTestTypeToolStripMenuItem
            // 
            editTestTypeToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editTestTypeToolStripMenuItem.Image = Properties.Resources.edit_32;
            editTestTypeToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            editTestTypeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            editTestTypeToolStripMenuItem.Size = new Size(193, 38);
            editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            editTestTypeToolStripMenuItem.Click += editTestTypeToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 475);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "#Record:";
            // 
            // lbTotalRecord
            // 
            lbTotalRecord.AutoSize = true;
            lbTotalRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRecord.Location = new Point(104, 475);
            lbTotalRecord.Name = "lbTotalRecord";
            lbTotalRecord.Size = new Size(31, 21);
            lbTotalRecord.TabIndex = 4;
            lbTotalRecord.Text = "???";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(644, 455);
            button1.Name = "button1";
            button1.Size = new Size(101, 41);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMangeTests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(button1);
            Controls.Add(lbTotalRecord);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmMangeTests";
            Text = "frmMangeTests";
            Load += frmMangeTests_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmsEditTestType.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label lbTotalRecord;
        private ContextMenuStrip cmsEditTestType;
        private ToolStripMenuItem editTestTypeToolStripMenuItem;
        private Button button1;
    }
}