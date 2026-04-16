namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtLeftDir = new TextBox();
            txtRightDir = new TextBox();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            btnLeftDir = new Button();
            panel6 = new Panel();
            lvwLeftDir = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel3 = new Panel();
            btnCopyFromLeft = new Button();
            panel5 = new Panel();
            lvwRightDir = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel4 = new Panel();
            btnRightDir = new Button();
            panel2 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(24, 11);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(324, 67);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "FileCompare";
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.None;
            txtLeftDir.Location = new Point(8, 26);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(487, 27);
            txtLeftDir.TabIndex = 1;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.None;
            txtRightDir.Location = new Point(13, 23);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(492, 27);
            txtRightDir.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            splitContainer1.Location = new Point(1, 60);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1300, 531);
            splitContainer1.SplitterDistance = 651;
            splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnLeftDir);
            panel1.Controls.Add(txtLeftDir);
            panel1.Location = new Point(-8, 126);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(666, 75);
            panel1.TabIndex = 2;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(516, 19);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(134, 41);
            btnLeftDir.TabIndex = 3;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click_1;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(lvwLeftDir);
            panel6.Location = new Point(-8, 201);
            panel6.Name = "panel6";
            panel6.Size = new Size(666, 327);
            panel6.TabIndex = 4;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(3, 26);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(664, 278);
            lvwLeftDir.TabIndex = 1;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            lvwLeftDir.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "크기";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정일";
            columnHeader3.Width = 160;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(lblAppName);
            panel3.Controls.Add(btnCopyFromLeft);
            panel3.Location = new Point(-8, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(666, 81);
            panel3.TabIndex = 3;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(516, 35);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(118, 40);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click_1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(lvwRightDir);
            panel5.Location = new Point(-6, 201);
            panel5.Name = "panel5";
            panel5.Size = new Size(657, 330);
            panel5.TabIndex = 4;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(9, 29);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(651, 275);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "이름";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "크기";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "수정일";
            columnHeader6.Width = 160;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.SpringGreen;
            panel4.Controls.Add(btnRightDir);
            panel4.Controls.Add(txtRightDir);
            panel4.Location = new Point(2, 126);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(649, 75);
            panel4.TabIndex = 4;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRightDir.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(511, 16);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(123, 44);
            btnRightDir.TabIndex = 4;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnCopyFromRight);
            panel2.Location = new Point(-6, 45);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(657, 81);
            panel2.TabIndex = 3;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromRight.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(17, 33);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(113, 40);
            btnCopyFromRight.TabIndex = 2;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 666);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Padding = new Padding(50, 30, 50, 5);
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAppName;
        private TextBox txtLeftDir;
        private TextBox txtRightDir;
        private SplitContainer splitContainer1;
        private Panel panel3;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Button btnLeftDir;
        private Button btnCopyFromLeft;
        private ListView lvwRightDir;
        private Button btnRightDir;
        private Button btnCopyFromRight;
        private Panel panel6;
        private ListView lvwLeftDir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
