
namespace TimeTableManagementSystemNew
{
    partial class AddSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSession));
            this.cmbSelEmp = new System.Windows.Forms.ComboBox();
            this.cmbSelTag = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblAddSession = new System.Windows.Forms.Label();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            this.cmbGrp = new System.Windows.Forms.ComboBox();
            this.lblSelSub = new System.Windows.Forms.Label();
            this.lblSelEmp = new System.Windows.Forms.Label();
            this.lblSelGrp = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSelectTag = new System.Windows.Forms.Label();
            this.lblSelectEmp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numStudents = new System.Windows.Forms.NumericUpDown();
            this.comSubCode = new System.Windows.Forms.ComboBox();
            this.lblSubCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelected = new System.Windows.Forms.ComboBox();
            this.format = new System.Windows.Forms.ToolTip(this.components);
            this.clear = new System.Windows.Forms.ToolTip(this.components);
            this.view = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelEmp
            // 
            this.cmbSelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelEmp.FormattingEnabled = true;
            this.cmbSelEmp.Location = new System.Drawing.Point(388, 212);
            this.cmbSelEmp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelEmp.Name = "cmbSelEmp";
            this.cmbSelEmp.Size = new System.Drawing.Size(292, 37);
            this.cmbSelEmp.TabIndex = 85;
            this.cmbSelEmp.SelectedIndexChanged += new System.EventHandler(this.cmbSelEmp_SelectedIndexChanged);
            // 
            // cmbSelTag
            // 
            this.cmbSelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelTag.FormattingEnabled = true;
            this.cmbSelTag.Location = new System.Drawing.Point(388, 438);
            this.cmbSelTag.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelTag.Name = "cmbSelTag";
            this.cmbSelTag.Size = new System.Drawing.Size(292, 37);
            this.cmbSelTag.TabIndex = 86;
            this.cmbSelTag.SelectedIndexChanged += new System.EventHandler(this.cmbSelTag_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(609, 666);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(160, 55);
            this.btnView.TabIndex = 83;
            this.btnView.Text = "Add";
            this.view.SetToolTip(this.btnView, "Click to view inserted data.");
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(820, 666);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 55);
            this.btnClear.TabIndex = 82;
            this.btnClear.Text = "Clear";
            this.clear.SetToolTip(this.btnClear, "Click to clear data from the form.");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(388, 666);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(160, 55);
            this.btnOk.TabIndex = 81;
            this.btnOk.Text = "Format";
            this.format.SetToolTip(this.btnOk, "Click here to generate the format of generated session.");
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAddSession
            // 
            this.lblAddSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddSession.AutoSize = true;
            this.lblAddSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSession.Location = new System.Drawing.Point(600, 100);
            this.lblAddSession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddSession.Name = "lblAddSession";
            this.lblAddSession.Size = new System.Drawing.Size(278, 52);
            this.lblAddSession.TabIndex = 80;
            this.lblAddSession.Text = "Add Session";
            this.lblAddSession.Click += new System.EventHandler(this.lblAddSession_Click);
            // 
            // cmbSub
            // 
            this.cmbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Location = new System.Drawing.Point(388, 383);
            this.cmbSub.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(292, 37);
            this.cmbSub.TabIndex = 78;
            this.cmbSub.SelectedIndexChanged += new System.EventHandler(this.cmbSub_SelectedIndexChanged);
            // 
            // cmbGrp
            // 
            this.cmbGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrp.FormattingEnabled = true;
            this.cmbGrp.Location = new System.Drawing.Point(388, 498);
            this.cmbGrp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrp.Name = "cmbGrp";
            this.cmbGrp.Size = new System.Drawing.Size(292, 37);
            this.cmbGrp.TabIndex = 77;
            this.cmbGrp.SelectedIndexChanged += new System.EventHandler(this.cmbGrp_SelectedIndexChanged);
            // 
            // lblSelSub
            // 
            this.lblSelSub.AutoSize = true;
            this.lblSelSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelSub.Location = new System.Drawing.Point(101, 385);
            this.lblSelSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelSub.Name = "lblSelSub";
            this.lblSelSub.Size = new System.Drawing.Size(168, 29);
            this.lblSelSub.TabIndex = 75;
            this.lblSelSub.Text = "Select Subject";
            // 
            // lblSelEmp
            // 
            this.lblSelEmp.AutoSize = true;
            this.lblSelEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblSelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelEmp.Location = new System.Drawing.Point(101, 271);
            this.lblSelEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelEmp.Name = "lblSelEmp";
            this.lblSelEmp.Size = new System.Drawing.Size(224, 29);
            this.lblSelEmp.TabIndex = 74;
            this.lblSelEmp.Text = "Selected Employee";
            // 
            // lblSelGrp
            // 
            this.lblSelGrp.AutoSize = true;
            this.lblSelGrp.BackColor = System.Drawing.Color.Transparent;
            this.lblSelGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelGrp.Location = new System.Drawing.Point(103, 501);
            this.lblSelGrp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelGrp.Name = "lblSelGrp";
            this.lblSelGrp.Size = new System.Drawing.Size(154, 29);
            this.lblSelGrp.TabIndex = 73;
            this.lblSelGrp.Text = "Select Group";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.BackColor = System.Drawing.Color.Transparent;
            this.lblStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStu.Location = new System.Drawing.Point(101, 558);
            this.lblStu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(226, 29);
            this.lblStu.TabIndex = 72;
            this.lblStu.Text = "Number of Students";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(101, 615);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(189, 29);
            this.lblDuration.TabIndex = 71;
            this.lblDuration.Text = "Duration (Hours)";
            // 
            // lblSelectTag
            // 
            this.lblSelectTag.AutoSize = true;
            this.lblSelectTag.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTag.Location = new System.Drawing.Point(103, 441);
            this.lblSelectTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectTag.Name = "lblSelectTag";
            this.lblSelectTag.Size = new System.Drawing.Size(130, 29);
            this.lblSelectTag.TabIndex = 70;
            this.lblSelectTag.Text = "Select Tag";
            // 
            // lblSelectEmp
            // 
            this.lblSelectEmp.AutoSize = true;
            this.lblSelectEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEmp.Location = new System.Drawing.Point(103, 214);
            this.lblSelectEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectEmp.Name = "lblSelectEmp";
            this.lblSelectEmp.Size = new System.Drawing.Size(202, 29);
            this.lblSelectEmp.TabIndex = 69;
            this.lblSelectEmp.Text = "Select Employee ";
            this.lblSelectEmp.Click += new System.EventHandler(this.lblSelectEmp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 743);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 25);
            this.panel2.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 39);
            this.panel1.TabIndex = 67;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
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
            this.pictureBox2.Location = new System.Drawing.Point(1320, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // numStudents
            // 
            this.numStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStudents.Location = new System.Drawing.Point(388, 555);
            this.numStudents.Margin = new System.Windows.Forms.Padding(4);
            this.numStudents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStudents.Name = "numStudents";
            this.numStudents.Size = new System.Drawing.Size(293, 34);
            this.numStudents.TabIndex = 88;
            // 
            // comSubCode
            // 
            this.comSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comSubCode.FormattingEnabled = true;
            this.comSubCode.Location = new System.Drawing.Point(388, 325);
            this.comSubCode.Margin = new System.Windows.Forms.Padding(4);
            this.comSubCode.Name = "comSubCode";
            this.comSubCode.Size = new System.Drawing.Size(292, 37);
            this.comSubCode.TabIndex = 90;
            this.comSubCode.SelectedIndexChanged += new System.EventHandler(this.comSubCode_SelectedIndexChanged);
            // 
            // lblSubCode
            // 
            this.lblSubCode.AutoSize = true;
            this.lblSubCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCode.Location = new System.Drawing.Point(103, 327);
            this.lblSubCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCode.Name = "lblSubCode";
            this.lblSubCode.Size = new System.Drawing.Size(233, 29);
            this.lblSubCode.TabIndex = 89;
            this.lblSubCode.Text = "Select Subject Code";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(711, 436);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(611, 23);
            this.textBox1.TabIndex = 93;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 35);
            this.label1.TabIndex = 94;
            this.label1.Text = "The format of a generated session";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSelected
            // 
            this.cmbSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelected.FormattingEnabled = true;
            this.cmbSelected.Location = new System.Drawing.Point(388, 268);
            this.cmbSelected.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelected.Name = "cmbSelected";
            this.cmbSelected.Size = new System.Drawing.Size(292, 37);
            this.cmbSelected.TabIndex = 96;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1024, 666);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 55);
            this.button1.TabIndex = 98;
            this.button1.Text = "View";
            this.view.SetToolTip(this.button1, "Click to view inserted data.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(388, 610);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 34);
            this.textBox2.TabIndex = 99;
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSelected);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comSubCode);
            this.Controls.Add(this.lblSubCode);
            this.Controls.Add(this.numStudents);
            this.Controls.Add(this.cmbSelEmp);
            this.Controls.Add(this.cmbSelTag);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAddSession);
            this.Controls.Add(this.cmbSub);
            this.Controls.Add(this.cmbGrp);
            this.Controls.Add(this.lblSelSub);
            this.Controls.Add(this.lblSelEmp);
            this.Controls.Add(this.lblSelGrp);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblSelectTag);
            this.Controls.Add(this.lblSelectEmp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSession";
            this.Load += new System.EventHandler(this.AddSession_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSelEmp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbSelTag;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblAddSession;
        private System.Windows.Forms.ComboBox cmbSub;
        private System.Windows.Forms.ComboBox cmbGrp;
        private System.Windows.Forms.Label lblSelSub;
        private System.Windows.Forms.Label lblSelEmp;
        private System.Windows.Forms.Label lblSelGrp;
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSelectTag;
        private System.Windows.Forms.Label lblSelectEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numStudents;
        private System.Windows.Forms.ComboBox comSubCode;
        private System.Windows.Forms.Label lblSubCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelected;
        private System.Windows.Forms.ToolTip format;
        private System.Windows.Forms.ToolTip clear;
        private System.Windows.Forms.ToolTip view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}