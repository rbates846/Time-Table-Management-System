
namespace TimeTableManagementSystemNew
{
    partial class ManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubject));
            this.delete = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.numEvaHours = new System.Windows.Forms.NumericUpDown();
            this.numLabHourse = new System.Windows.Forms.NumericUpDown();
            this.numTuteHours = new System.Windows.Forms.NumericUpDown();
            this.numLecHourse = new System.Windows.Forms.NumericUpDown();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.txtSubtName = new System.Windows.Forms.TextBox();
            this.radioButton2nd = new System.Windows.Forms.RadioButton();
            this.radioButton1st = new System.Windows.Forms.RadioButton();
            this.cmbOffered = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.GrdSubjectData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEvaHours = new System.Windows.Forms.Label();
            this.lblLecHours = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSubCode = new System.Windows.Forms.Label();
            this.lblTuteHours = new System.Windows.Forms.Label();
            this.lblLabHours = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblOffered = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEvaHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLabHourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTuteHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLecHourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSubjectData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(935, 679);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 55);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.Text = "Delete";
            this.delete.SetToolTip(this.btnDelete, "Click to delete selected row data from database.");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(495, 679);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 55);
            this.btnClear.TabIndex = 89;
            this.btnClear.Text = "Clear";
            this.clear.SetToolTip(this.btnClear, "Click to clear data from form.");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(275, 679);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 55);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Save";
            this.save.SetToolTip(this.btnSave, "Click to save data in to the database.");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMid
            // 
            this.txtMid.Location = new System.Drawing.Point(604, 192);
            this.txtMid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(132, 22);
            this.txtMid.TabIndex = 105;
            this.txtMid.Visible = false;
            // 
            // numEvaHours
            // 
            this.numEvaHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEvaHours.Location = new System.Drawing.Point(447, 610);
            this.numEvaHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numEvaHours.Name = "numEvaHours";
            this.numEvaHours.Size = new System.Drawing.Size(293, 34);
            this.numEvaHours.TabIndex = 104;
            // 
            // numLabHourse
            // 
            this.numLabHourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabHourse.Location = new System.Drawing.Point(447, 555);
            this.numLabHourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numLabHourse.Name = "numLabHourse";
            this.numLabHourse.Size = new System.Drawing.Size(293, 34);
            this.numLabHourse.TabIndex = 103;
            // 
            // numTuteHours
            // 
            this.numTuteHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTuteHours.Location = new System.Drawing.Point(447, 498);
            this.numTuteHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTuteHours.Name = "numTuteHours";
            this.numTuteHours.Size = new System.Drawing.Size(293, 34);
            this.numTuteHours.TabIndex = 102;
            // 
            // numLecHourse
            // 
            this.numLecHourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLecHourse.Location = new System.Drawing.Point(444, 442);
            this.numLecHourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numLecHourse.Name = "numLecHourse";
            this.numLecHourse.Size = new System.Drawing.Size(293, 34);
            this.numLecHourse.TabIndex = 101;
            // 
            // txtSubCode
            // 
            this.txtSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCode.Location = new System.Drawing.Point(444, 383);
            this.txtSubCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(292, 34);
            this.txtSubCode.TabIndex = 100;
            // 
            // txtSubtName
            // 
            this.txtSubtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtName.Location = new System.Drawing.Point(444, 327);
            this.txtSubtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtName.Name = "txtSubtName";
            this.txtSubtName.Size = new System.Drawing.Size(292, 34);
            this.txtSubtName.TabIndex = 99;
            // 
            // radioButton2nd
            // 
            this.radioButton2nd.AutoSize = true;
            this.radioButton2nd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2nd.Location = new System.Drawing.Point(591, 288);
            this.radioButton2nd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2nd.Name = "radioButton2nd";
            this.radioButton2nd.Size = new System.Drawing.Size(139, 24);
            this.radioButton2nd.TabIndex = 98;
            this.radioButton2nd.TabStop = true;
            this.radioButton2nd.Text = "2 nd Semester";
            this.radioButton2nd.UseVisualStyleBackColor = true;
            this.radioButton2nd.CheckedChanged += new System.EventHandler(this.radioButton2nd_CheckedChanged);
            // 
            // radioButton1st
            // 
            this.radioButton1st.AutoSize = true;
            this.radioButton1st.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1st.Location = new System.Drawing.Point(444, 289);
            this.radioButton1st.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1st.Name = "radioButton1st";
            this.radioButton1st.Size = new System.Drawing.Size(130, 24);
            this.radioButton1st.TabIndex = 97;
            this.radioButton1st.TabStop = true;
            this.radioButton1st.Text = "1st Semester";
            this.radioButton1st.UseVisualStyleBackColor = true;
            this.radioButton1st.CheckedChanged += new System.EventHandler(this.radioButton1st_CheckedChanged);
            // 
            // cmbOffered
            // 
            this.cmbOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffered.FormattingEnabled = true;
            this.cmbOffered.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbOffered.Location = new System.Drawing.Point(444, 240);
            this.cmbOffered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOffered.Name = "cmbOffered";
            this.cmbOffered.Size = new System.Drawing.Size(292, 37);
            this.cmbOffered.TabIndex = 96;
            this.cmbOffered.SelectedIndexChanged += new System.EventHandler(this.cmbOffered_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1317, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(713, 679);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 55);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.update.SetToolTip(this.btnUpdate, "Click to update data in database");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(877, 240);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(420, 34);
            this.txtboxSearch.TabIndex = 94;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(776, 242);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 93;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrdSubjectData
            // 
            this.GrdSubjectData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdSubjectData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdSubjectData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GrdSubjectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSubjectData.Location = new System.Drawing.Point(773, 288);
            this.GrdSubjectData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrdSubjectData.Name = "GrdSubjectData";
            this.GrdSubjectData.RowHeadersWidth = 51;
            this.GrdSubjectData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdSubjectData.Size = new System.Drawing.Size(525, 286);
            this.GrdSubjectData.TabIndex = 92;
            this.GrdSubjectData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSubjectData_CellClick);
            this.GrdSubjectData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSubjectData_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 52);
            this.label1.TabIndex = 87;
            this.label1.Text = "Manage Subject";
            // 
            // lblEvaHours
            // 
            this.lblEvaHours.AutoSize = true;
            this.lblEvaHours.BackColor = System.Drawing.Color.Transparent;
            this.lblEvaHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaHours.Location = new System.Drawing.Point(67, 615);
            this.lblEvaHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvaHours.Name = "lblEvaHours";
            this.lblEvaHours.Size = new System.Drawing.Size(313, 29);
            this.lblEvaHours.TabIndex = 86;
            this.lblEvaHours.Text = "Number of Evaluation Hours";
            // 
            // lblLecHours
            // 
            this.lblLecHours.AutoSize = true;
            this.lblLecHours.BackColor = System.Drawing.Color.Transparent;
            this.lblLecHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecHours.Location = new System.Drawing.Point(64, 452);
            this.lblLecHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecHours.Name = "lblLecHours";
            this.lblLecHours.Size = new System.Drawing.Size(282, 29);
            this.lblLecHours.TabIndex = 85;
            this.lblLecHours.Text = "Number of Lecture Hours";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(64, 334);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(165, 29);
            this.lblSubject.TabIndex = 84;
            this.lblSubject.Text = "Subject Name";
            // 
            // lblSubCode
            // 
            this.lblSubCode.AutoSize = true;
            this.lblSubCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCode.Location = new System.Drawing.Point(64, 389);
            this.lblSubCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCode.Name = "lblSubCode";
            this.lblSubCode.Size = new System.Drawing.Size(159, 29);
            this.lblSubCode.TabIndex = 83;
            this.lblSubCode.Text = "Subject Code";
            // 
            // lblTuteHours
            // 
            this.lblTuteHours.AutoSize = true;
            this.lblTuteHours.BackColor = System.Drawing.Color.Transparent;
            this.lblTuteHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuteHours.Location = new System.Drawing.Point(67, 503);
            this.lblTuteHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuteHours.Name = "lblTuteHours";
            this.lblTuteHours.Size = new System.Drawing.Size(284, 29);
            this.lblTuteHours.TabIndex = 82;
            this.lblTuteHours.Text = "Number of Tutorial Hours";
            // 
            // lblLabHours
            // 
            this.lblLabHours.AutoSize = true;
            this.lblLabHours.BackColor = System.Drawing.Color.Transparent;
            this.lblLabHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabHours.Location = new System.Drawing.Point(67, 560);
            this.lblLabHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabHours.Name = "lblLabHours";
            this.lblLabHours.Size = new System.Drawing.Size(242, 29);
            this.lblLabHours.TabIndex = 81;
            this.lblLabHours.Text = "Number of Lab Hours";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(67, 293);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(204, 29);
            this.lblEmpID.TabIndex = 80;
            this.lblEmpID.Text = "Offered Semester";
            // 
            // lblOffered
            // 
            this.lblOffered.AutoSize = true;
            this.lblOffered.BackColor = System.Drawing.Color.Transparent;
            this.lblOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffered.Location = new System.Drawing.Point(64, 246);
            this.lblOffered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffered.Name = "lblOffered";
            this.lblOffered.Size = new System.Drawing.Size(151, 29);
            this.lblOffered.TabIndex = 79;
            this.lblOffered.Text = "Offered Year";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 743);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 25);
            this.panel2.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 39);
            this.panel1.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // ManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.txtMid);
            this.Controls.Add(this.numEvaHours);
            this.Controls.Add(this.numLabHourse);
            this.Controls.Add(this.numTuteHours);
            this.Controls.Add(this.numLecHourse);
            this.Controls.Add(this.txtSubCode);
            this.Controls.Add(this.txtSubtName);
            this.Controls.Add(this.radioButton2nd);
            this.Controls.Add(this.radioButton1st);
            this.Controls.Add(this.cmbOffered);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.GrdSubjectData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEvaHours);
            this.Controls.Add(this.lblLecHours);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblSubCode);
            this.Controls.Add(this.lblTuteHours);
            this.Controls.Add(this.lblLabHours);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblOffered);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSubject";
            this.Load += new System.EventHandler(this.ManageSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEvaHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLabHourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTuteHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLecHourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSubjectData)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip delete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip clear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip save;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMid;
        private System.Windows.Forms.NumericUpDown numEvaHours;
        private System.Windows.Forms.NumericUpDown numLabHourse;
        private System.Windows.Forms.NumericUpDown numTuteHours;
        private System.Windows.Forms.NumericUpDown numLecHourse;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.TextBox txtSubtName;
        private System.Windows.Forms.RadioButton radioButton2nd;
        private System.Windows.Forms.RadioButton radioButton1st;
        private System.Windows.Forms.ComboBox cmbOffered;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip update;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView GrdSubjectData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvaHours;
        private System.Windows.Forms.Label lblLecHours;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblSubCode;
        private System.Windows.Forms.Label lblTuteHours;
        private System.Windows.Forms.Label lblLabHours;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblOffered;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}