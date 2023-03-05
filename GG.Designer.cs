namespace Program
{
    partial class GG
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmajor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbN2 = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.playerToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.playerToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.newToolStripMenuItem.Text = "Open File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem});
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(75, 29);
            this.playerToolStripMenuItem1.Text = "Player";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.newPlayerToolStripMenuItem.Text = "New Player";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnLastName,
            this.ColumnStudentID,
            this.ColumnMajor,
            this.ColumnDisplayName,
            this.ColumnMail,
            this.ColumnPhone,
            this.ColumnAge});
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(766, 488);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.DataPropertyName = "LastName";
            this.ColumnLastName.HeaderText = "LastName";
            this.ColumnLastName.MinimumWidth = 8;
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.Width = 150;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.DataPropertyName = "StudentID";
            this.ColumnStudentID.HeaderText = "StudentID";
            this.ColumnStudentID.MinimumWidth = 8;
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.Width = 150;
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.DataPropertyName = "Major";
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.MinimumWidth = 8;
            this.ColumnMajor.Name = "ColumnMajor";
            this.ColumnMajor.Width = 150;
            // 
            // ColumnDisplayName
            // 
            this.ColumnDisplayName.DataPropertyName = "DisplayName";
            this.ColumnDisplayName.HeaderText = "DisplayName";
            this.ColumnDisplayName.MinimumWidth = 8;
            this.ColumnDisplayName.Name = "ColumnDisplayName";
            this.ColumnDisplayName.Width = 150;
            // 
            // ColumnMail
            // 
            this.ColumnMail.DataPropertyName = "Mail";
            this.ColumnMail.HeaderText = "Mail";
            this.ColumnMail.MinimumWidth = 8;
            this.ColumnMail.Name = "ColumnMail";
            this.ColumnMail.Width = 150;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "Phone";
            this.ColumnPhone.HeaderText = "Phone";
            this.ColumnPhone.MinimumWidth = 8;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 150;
            // 
            // ColumnAge
            // 
            this.ColumnAge.DataPropertyName = "Age";
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.MinimumWidth = 8;
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "สาขา";
            // 
            // tbmajor
            // 
            this.tbmajor.Location = new System.Drawing.Point(896, 166);
            this.tbmajor.Name = "tbmajor";
            this.tbmajor.Size = new System.Drawing.Size(150, 31);
            this.tbmajor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "รหัสนักศึกษา";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(896, 129);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(150, 31);
            this.tbID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "นามสกุล";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ชื่อ";
            // 
            // tbN2
            // 
            this.tbN2.Location = new System.Drawing.Point(896, 92);
            this.tbN2.Name = "tbN2";
            this.tbN2.Size = new System.Drawing.Size(150, 31);
            this.tbN2.TabIndex = 10;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(896, 55);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(150, 31);
            this.tbN.TabIndex = 9;
            // 
            // GG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbmajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbN2);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GG";
            this.Text = "GG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem1;
        private ToolStripMenuItem newPlayerToolStripMenuItem;
        private Label label4;
        private TextBox tbmajor;
        private Label label3;
        private TextBox tbID;
        private Label label2;
        private Label label1;
        private TextBox tbN2;
        private TextBox tbN;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnStudentID;
        private DataGridViewTextBoxColumn ColumnMajor;
        private DataGridViewTextBoxColumn ColumnDisplayName;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAge;
    }
}