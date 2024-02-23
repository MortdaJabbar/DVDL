namespace DVDL.Applications
{
    partial class frmManageApplicationTypes
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            cmsEditApplicationType = new ContextMenuStrip(components);
            editApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lbTotalRecords = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmsEditApplicationType.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(249, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(290, 218);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 1;
            label1.Text = "Mange Application Types";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ContextMenuStrip = cmsEditApplicationType;
            dataGridView1.Location = new Point(2, 249);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(882, 176);
            dataGridView1.TabIndex = 2;
            // 
            // cmsEditApplicationType
            // 
            cmsEditApplicationType.Items.AddRange(new ToolStripItem[] { editApplicationTypeToolStripMenuItem });
            cmsEditApplicationType.Name = "cmsEditApplicationType";
            cmsEditApplicationType.Size = new Size(238, 42);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            editApplicationTypeToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            editApplicationTypeToolStripMenuItem.Image = Properties.Resources.edit_32;
            editApplicationTypeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            editApplicationTypeToolStripMenuItem.Size = new Size(237, 38);
            editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            editApplicationTypeToolStripMenuItem.Click += editApplicationTypeToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 432);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 3;
            label2.Text = "#Records: ";
            // 
            // lbTotalRecords
            // 
            lbTotalRecords.AutoSize = true;
            lbTotalRecords.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRecords.Location = new Point(119, 432);
            lbTotalRecords.Name = "lbTotalRecords";
            lbTotalRecords.Size = new Size(40, 30);
            lbTotalRecords.TabIndex = 4;
            lbTotalRecords.Text = "???";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(765, 431);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 471);
            Controls.Add(btnClose);
            Controls.Add(lbTotalRecords);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmManageApplicationTypes";
            Text = "frmManageApplicationTypes";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmsEditApplicationType.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private ContextMenuStrip cmsEditApplicationType;
        private ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private Label label2;
        private Label lbTotalRecords;
        private Button btnClose;
    }
}