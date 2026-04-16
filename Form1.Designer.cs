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
            panel6 = new Panel();
            listView1 = new ListView();
            panel3 = new Panel();
            btnLeftDir = new Button();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            panel5 = new Panel();
            lvwRightDir = new ListView();
            panel4 = new Panel();
            btnRightDir = new Button();
            panel2 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
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
            lblAppName.Location = new Point(8, 5);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(324, 67);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "FileCompare";
            // 
            // txtLeftDir
            // 
            txtLeftDir.Location = new Point(8, 23);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(487, 27);
            txtLeftDir.TabIndex = 1;
            // 
            // txtRightDir
            // 
            txtRightDir.Location = new Point(17, 23);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(507, 27);
            txtRightDir.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(25, 65);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1317, 428);
            splitContainer1.SplitterDistance = 661;
            splitContainer1.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(listView1);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 162);
            panel6.Name = "panel6";
            panel6.Size = new Size(661, 266);
            panel6.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Location = new Point(8, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(650, 255);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(btnLeftDir);
            panel3.Controls.Add(txtLeftDir);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 78);
            panel3.TabIndex = 3;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(541, 6);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(89, 61);
            btnLeftDir.TabIndex = 3;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(661, 81);
            panel1.TabIndex = 2;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(512, 33);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(118, 40);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(lvwRightDir);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 156);
            panel5.Name = "panel5";
            panel5.Size = new Size(652, 272);
            panel5.TabIndex = 4;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Location = new Point(3, 6);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(636, 258);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SpringGreen;
            panel4.Controls.Add(btnRightDir);
            panel4.Controls.Add(txtRightDir);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 81);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(652, 75);
            panel4.TabIndex = 4;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRightDir.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(539, 6);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(94, 61);
            btnRightDir.TabIndex = 4;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(btnCopyFromRight);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(652, 81);
            panel2.TabIndex = 3;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopyFromRight.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(8, 33);
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
            ClientSize = new Size(1354, 514);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Padding = new Padding(50, 30, 50, 5);
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private ListView listView1;
    }
}
