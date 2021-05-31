
namespace TimeTableManagementSystemNew
{
    partial class Add_Student
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerateId = new System.Windows.Forms.Button();
            this.txtBoxSubGroupId = new System.Windows.Forms.TextBox();
            this.txtBoxGroupId = new System.Windows.Forms.TextBox();
            this.txtBoxProgramme = new System.Windows.Forms.ComboBox();
            this.SubGroupNumber = new System.Windows.Forms.NumericUpDown();
            this.GroupNumber = new System.Windows.Forms.NumericUpDown();
            this.txtBoxAcedemicYearAndSemester = new System.Windows.Forms.TextBox();
            this.lblSubGroupId = new System.Windows.Forms.Label();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblSubGroupNumber = new System.Windows.Forms.Label();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.lblAcademicYearAndSemester = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(778, 183);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 72;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToResizeRows = false;
            this.dgvStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudentList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvStudentList.Location = new System.Drawing.Point(739, 250);
            this.dgvStudentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 24;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(591, 314);
            this.dgvStudentList.TabIndex = 70;
            this.dgvStudentList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudentList_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(460, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(511, 51);
            this.label7.TabIndex = 68;
            this.label7.Text = "Manage Student Groups";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(873, 180);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(442, 34);
            this.txtBoxSearch.TabIndex = 71;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Location = new System.Drawing.Point(475, 203);
            this.txtBoxStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(225, 22);
            this.txtBoxStudentId.TabIndex = 73;
            this.txtBoxStudentId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 39);
            this.panel2.TabIndex = 67;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1317, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1492, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TimeTableManagementSystemNew.Properties.Resources.icons8_reply_arrow_24;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(0, 849);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2051, 20);
            this.panel1.TabIndex = 66;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1041, 654);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 50);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.toolTip5.SetToolTip(this.btnDelete, "Delete added fields");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(840, 654);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 50);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Update";
            this.toolTip4.SetToolTip(this.btnUpdate, "Click to Update the data");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(645, 654);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 50);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.toolTip3.SetToolTip(this.btnClear, "Clear the data Fields");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(445, 654);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 50);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Add";
            this.toolTip2.SetToolTip(this.btnSave, "Click to Add");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btnGenerateId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerateId.ForeColor = System.Drawing.Color.White;
            this.btnGenerateId.Location = new System.Drawing.Point(180, 654);
            this.btnGenerateId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(220, 50);
            this.btnGenerateId.TabIndex = 61;
            this.btnGenerateId.Text = "Generate ID\'s";
            this.toolTip1.SetToolTip(this.btnGenerateId, "Click to Generate Group ID\'s");
            this.btnGenerateId.UseVisualStyleBackColor = false;
            this.btnGenerateId.Click += new System.EventHandler(this.btnGenerateId_Click);
            // 
            // txtBoxSubGroupId
            // 
            this.txtBoxSubGroupId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxSubGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxSubGroupId.Location = new System.Drawing.Point(401, 597);
            this.txtBoxSubGroupId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSubGroupId.Name = "txtBoxSubGroupId";
            this.txtBoxSubGroupId.ReadOnly = true;
            this.txtBoxSubGroupId.Size = new System.Drawing.Size(300, 34);
            this.txtBoxSubGroupId.TabIndex = 60;
            this.txtBoxSubGroupId.TextChanged += new System.EventHandler(this.txtBoxSubGroupId_TextChanged);
            // 
            // txtBoxGroupId
            // 
            this.txtBoxGroupId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxGroupId.Location = new System.Drawing.Point(401, 526);
            this.txtBoxGroupId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxGroupId.Name = "txtBoxGroupId";
            this.txtBoxGroupId.ReadOnly = true;
            this.txtBoxGroupId.Size = new System.Drawing.Size(300, 34);
            this.txtBoxGroupId.TabIndex = 59;
            // 
            // txtBoxProgramme
            // 
            this.txtBoxProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxProgramme.FormattingEnabled = true;
            this.txtBoxProgramme.Items.AddRange(new object[] {
            "IT",
            "CSSE",
            "IM",
            "CSE"});
            this.txtBoxProgramme.Location = new System.Drawing.Point(401, 313);
            this.txtBoxProgramme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxProgramme.Name = "txtBoxProgramme";
            this.txtBoxProgramme.Size = new System.Drawing.Size(300, 37);
            this.txtBoxProgramme.TabIndex = 58;
            // 
            // SubGroupNumber
            // 
            this.SubGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.SubGroupNumber.Location = new System.Drawing.Point(401, 455);
            this.SubGroupNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubGroupNumber.Name = "SubGroupNumber";
            this.SubGroupNumber.Size = new System.Drawing.Size(300, 34);
            this.SubGroupNumber.TabIndex = 57;
            // 
            // GroupNumber
            // 
            this.GroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.GroupNumber.Location = new System.Drawing.Point(401, 385);
            this.GroupNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupNumber.Name = "GroupNumber";
            this.GroupNumber.Size = new System.Drawing.Size(300, 34);
            this.GroupNumber.TabIndex = 56;
            // 
            // txtBoxAcedemicYearAndSemester
            // 
            this.txtBoxAcedemicYearAndSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxAcedemicYearAndSemester.Location = new System.Drawing.Point(401, 247);
            this.txtBoxAcedemicYearAndSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAcedemicYearAndSemester.Name = "txtBoxAcedemicYearAndSemester";
            this.txtBoxAcedemicYearAndSemester.Size = new System.Drawing.Size(300, 34);
            this.txtBoxAcedemicYearAndSemester.TabIndex = 55;
            // 
            // lblSubGroupId
            // 
            this.lblSubGroupId.AutoSize = true;
            this.lblSubGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblSubGroupId.Location = new System.Drawing.Point(51, 601);
            this.lblSubGroupId.Name = "lblSubGroupId";
            this.lblSubGroupId.Size = new System.Drawing.Size(172, 29);
            this.lblSubGroupId.TabIndex = 54;
            this.lblSubGroupId.Text = "Sub - Group ID";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblGroupId.Location = new System.Drawing.Point(51, 530);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(109, 29);
            this.lblGroupId.TabIndex = 53;
            this.lblGroupId.Text = "Group ID";
            // 
            // lblSubGroupNumber
            // 
            this.lblSubGroupNumber.AutoSize = true;
            this.lblSubGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblSubGroupNumber.Location = new System.Drawing.Point(51, 460);
            this.lblSubGroupNumber.Name = "lblSubGroupNumber";
            this.lblSubGroupNumber.Size = new System.Drawing.Size(236, 29);
            this.lblSubGroupNumber.TabIndex = 52;
            this.lblSubGroupNumber.Text = "Sub - Group Number";
            // 
            // lblGroupNumber
            // 
            this.lblGroupNumber.AutoSize = true;
            this.lblGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblGroupNumber.Location = new System.Drawing.Point(51, 390);
            this.lblGroupNumber.Name = "lblGroupNumber";
            this.lblGroupNumber.Size = new System.Drawing.Size(173, 29);
            this.lblGroupNumber.TabIndex = 51;
            this.lblGroupNumber.Text = "Group Number";
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblProgramme.Location = new System.Drawing.Point(51, 320);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(140, 29);
            this.lblProgramme.TabIndex = 50;
            this.lblProgramme.Text = "Programme";
            // 
            // lblAcademicYearAndSemester
            // 
            this.lblAcademicYearAndSemester.AutoSize = true;
            this.lblAcademicYearAndSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearAndSemester.Location = new System.Drawing.Point(51, 250);
            this.lblAcademicYearAndSemester.Name = "lblAcademicYearAndSemester";
            this.lblAcademicYearAndSemester.Size = new System.Drawing.Size(291, 29);
            this.lblAcademicYearAndSemester.TabIndex = 49;
            this.lblAcademicYearAndSemester.Text = "Acadamic Year & Semester";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeTableManagementSystemNew.Properties.Resources.A__2_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel3.Location = new System.Drawing.Point(0, 748);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1360, 20);
            this.panel3.TabIndex = 74;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.txtBoxStudentId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.txtBoxSubGroupId);
            this.Controls.Add(this.txtBoxGroupId);
            this.Controls.Add(this.txtBoxProgramme);
            this.Controls.Add(this.SubGroupNumber);
            this.Controls.Add(this.GroupNumber);
            this.Controls.Add(this.txtBoxAcedemicYearAndSemester);
            this.Controls.Add(this.lblSubGroupId);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.lblSubGroupNumber);
            this.Controls.Add(this.lblGroupNumber);
            this.Controls.Add(this.lblProgramme);
            this.Controls.Add(this.lblAcademicYearAndSemester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student";
            this.Load += new System.EventHandler(this.Add_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerateId;
        private System.Windows.Forms.TextBox txtBoxSubGroupId;
        private System.Windows.Forms.TextBox txtBoxGroupId;
        private System.Windows.Forms.ComboBox txtBoxProgramme;
        private System.Windows.Forms.NumericUpDown SubGroupNumber;
        private System.Windows.Forms.NumericUpDown GroupNumber;
        private System.Windows.Forms.TextBox txtBoxAcedemicYearAndSemester;
        private System.Windows.Forms.Label lblSubGroupId;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblSubGroupNumber;
        private System.Windows.Forms.Label lblGroupNumber;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.Label lblAcademicYearAndSemester;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}