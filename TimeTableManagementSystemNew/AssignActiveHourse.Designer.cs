
namespace TimeTableManagementSystemNew
{
    partial class AssignActiveHourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignActiveHourse));
            this.delete = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.textRank = new System.Windows.Forms.TextBox();
            this.WeekPanel = new System.Windows.Forms.CheckedListBox();
            this.AssID = new System.Windows.Forms.TextBox();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblHrs = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.update = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numHrs = new System.Windows.Forms.NumericUpDown();
            this.cmbEmpName = new System.Windows.Forms.ComboBox();
            this.lblAssignActiveHrs = new System.Windows.Forms.Label();
            this.lblActiveHours = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.GrdActiveHrs = new System.Windows.Forms.DataGridView();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblWorkingDays = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdActiveHrs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(921, 661);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 55);
            this.btnDelete.TabIndex = 124;
            this.btnDelete.Text = "Delete";
            this.delete.SetToolTip(this.btnDelete, "Click to delete selected row data from the database.");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(464, 661);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 55);
            this.btnClear.TabIndex = 122;
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
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(229, 661);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 55);
            this.btnSave.TabIndex = 121;
            this.btnSave.Text = "Save";
            this.save.SetToolTip(this.btnSave, "Click to save data in to the database.");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textRank
            // 
            this.textRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRank.Location = new System.Drawing.Point(428, 286);
            this.textRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRank.Name = "textRank";
            this.textRank.Size = new System.Drawing.Size(292, 34);
            this.textRank.TabIndex = 137;
            // 
            // WeekPanel
            // 
            this.WeekPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeekPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekPanel.FormattingEnabled = true;
            this.WeekPanel.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.WeekPanel.Location = new System.Drawing.Point(429, 417);
            this.WeekPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeekPanel.Name = "WeekPanel";
            this.WeekPanel.Size = new System.Drawing.Size(316, 120);
            this.WeekPanel.TabIndex = 136;
            this.WeekPanel.SelectedIndexChanged += new System.EventHandler(this.WeekPanel_SelectedIndexChanged);
            // 
            // AssID
            // 
            this.AssID.Location = new System.Drawing.Point(589, 185);
            this.AssID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssID.Name = "AssID";
            this.AssID.Size = new System.Drawing.Size(132, 22);
            this.AssID.TabIndex = 135;
            this.AssID.Visible = false;
            this.AssID.TextChanged += new System.EventHandler(this.AssID_TextChanged);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.BackColor = System.Drawing.Color.Transparent;
            this.lblMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMins.Location = new System.Drawing.Point(663, 601);
            this.lblMins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(97, 29);
            this.lblMins.TabIndex = 134;
            this.lblMins.Text = "Minutes";
            // 
            // lblHrs
            // 
            this.lblHrs.AutoSize = true;
            this.lblHrs.BackColor = System.Drawing.Color.Transparent;
            this.lblHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrs.Location = new System.Drawing.Point(499, 598);
            this.lblHrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHrs.Name = "lblHrs";
            this.lblHrs.Size = new System.Drawing.Size(77, 29);
            this.lblHrs.TabIndex = 133;
            this.lblHrs.Text = "Hours";
            // 
            // numDays
            // 
            this.numDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDays.Location = new System.Drawing.Point(428, 352);
            this.numDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(293, 34);
            this.numDays.TabIndex = 132;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(695, 661);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 55);
            this.btnUpdate.TabIndex = 123;
            this.btnUpdate.Text = "Update";
            this.update.SetToolTip(this.btnUpdate, "Click to update data in database");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numMin
            // 
            this.numMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMin.Location = new System.Drawing.Point(583, 598);
            this.numMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(67, 34);
            this.numMin.TabIndex = 131;
            // 
            // numHrs
            // 
            this.numHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHrs.Location = new System.Drawing.Point(420, 598);
            this.numHrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numHrs.Name = "numHrs";
            this.numHrs.Size = new System.Drawing.Size(67, 34);
            this.numHrs.TabIndex = 130;
            // 
            // cmbEmpName
            // 
            this.cmbEmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpName.FormattingEnabled = true;
            this.cmbEmpName.Location = new System.Drawing.Point(429, 217);
            this.cmbEmpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmpName.Name = "cmbEmpName";
            this.cmbEmpName.Size = new System.Drawing.Size(292, 37);
            this.cmbEmpName.TabIndex = 129;
            this.cmbEmpName.SelectedIndexChanged += new System.EventHandler(this.cmbEmpName_SelectedIndexChanged);
            // 
            // lblAssignActiveHrs
            // 
            this.lblAssignActiveHrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssignActiveHrs.AutoSize = true;
            this.lblAssignActiveHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblAssignActiveHrs.Location = new System.Drawing.Point(580, 100);
            this.lblAssignActiveHrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignActiveHrs.Name = "lblAssignActiveHrs";
            this.lblAssignActiveHrs.Size = new System.Drawing.Size(428, 51);
            this.lblAssignActiveHrs.TabIndex = 120;
            this.lblAssignActiveHrs.Text = "Assign Active Hours";
            // 
            // lblActiveHours
            // 
            this.lblActiveHours.AutoSize = true;
            this.lblActiveHours.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveHours.Location = new System.Drawing.Point(156, 603);
            this.lblActiveHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveHours.Name = "lblActiveHours";
            this.lblActiveHours.Size = new System.Drawing.Size(147, 29);
            this.lblActiveHours.TabIndex = 119;
            this.lblActiveHours.Text = "Active Hours";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(939, 266);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(376, 34);
            this.txtboxSearch.TabIndex = 127;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(812, 266);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 126;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrdActiveHrs
            // 
            this.GrdActiveHrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdActiveHrs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdActiveHrs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GrdActiveHrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdActiveHrs.Location = new System.Drawing.Point(797, 320);
            this.GrdActiveHrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrdActiveHrs.Name = "GrdActiveHrs";
            this.GrdActiveHrs.RowHeadersWidth = 51;
            this.GrdActiveHrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdActiveHrs.Size = new System.Drawing.Size(519, 308);
            this.GrdActiveHrs.TabIndex = 125;
            this.GrdActiveHrs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdActiveHrs_CellClick);
            this.GrdActiveHrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdActiveHrs_CellContentClick);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblDays.Location = new System.Drawing.Point(152, 354);
            this.lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(185, 29);
            this.lblDays.TabIndex = 118;
            this.lblDays.Text = "Number of Days";
            // 
            // lblWorkingDays
            // 
            this.lblWorkingDays.AutoSize = true;
            this.lblWorkingDays.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblWorkingDays.Location = new System.Drawing.Point(156, 417);
            this.lblWorkingDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingDays.Name = "lblWorkingDays";
            this.lblWorkingDays.Size = new System.Drawing.Size(177, 29);
            this.lblWorkingDays.TabIndex = 117;
            this.lblWorkingDays.Text = "Working Day(s)";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BackColor = System.Drawing.Color.Transparent;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblRank.Location = new System.Drawing.Point(151, 288);
            this.lblRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(68, 29);
            this.lblRank.TabIndex = 116;
            this.lblRank.Text = "Rank";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblEmpName.Location = new System.Drawing.Point(152, 219);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(193, 29);
            this.lblEmpName.TabIndex = 115;
            this.lblEmpName.Text = "Employee Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 748);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 20);
            this.panel2.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 39);
            this.panel1.TabIndex = 113;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1317, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeTableManagementSystemNew.Properties.Resources.A__2_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-19, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 138;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AssignActiveHourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textRank);
            this.Controls.Add(this.AssID);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.lblHrs);
            this.Controls.Add(this.numDays);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.numHrs);
            this.Controls.Add(this.cmbEmpName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAssignActiveHrs);
            this.Controls.Add(this.lblActiveHours);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.GrdActiveHrs);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblWorkingDays);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WeekPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssignActiveHourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignActiveHourse";
            this.Load += new System.EventHandler(this.AssignActiveHourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdActiveHrs)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.TextBox textRank;
        private System.Windows.Forms.CheckedListBox WeekPanel;
        private System.Windows.Forms.TextBox AssID;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblHrs;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.ToolTip update;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHrs;
        private System.Windows.Forms.ComboBox cmbEmpName;
        private System.Windows.Forms.Label lblAssignActiveHrs;
        private System.Windows.Forms.Label lblActiveHours;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView GrdActiveHrs;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblWorkingDays;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}