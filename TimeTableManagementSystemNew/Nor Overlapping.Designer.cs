
namespace TimeTableManagementSystemNew
{
    partial class Nor_Overlapping
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAcademicYearAndSemester = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRelatedTag = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not Overlapping";
            // 
            // lblAcademicYearAndSemester
            // 
            this.lblAcademicYearAndSemester.AutoSize = true;
            this.lblAcademicYearAndSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearAndSemester.Location = new System.Drawing.Point(300, 352);
            this.lblAcademicYearAndSemester.Name = "lblAcademicYearAndSemester";
            this.lblAcademicYearAndSemester.Size = new System.Drawing.Size(129, 29);
            this.lblAcademicYearAndSemester.TabIndex = 51;
            this.lblAcademicYearAndSemester.Text = "Category 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(850, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Category 2";
            // 
            // txtBoxRelatedTag
            // 
            this.txtBoxRelatedTag.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F);
            this.txtBoxRelatedTag.FormattingEnabled = true;
            this.txtBoxRelatedTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab",
            "Evaluation"});
            this.txtBoxRelatedTag.Location = new System.Drawing.Point(435, 351);
            this.txtBoxRelatedTag.Name = "txtBoxRelatedTag";
            this.txtBoxRelatedTag.Size = new System.Drawing.Size(300, 34);
            this.txtBoxRelatedTag.TabIndex = 62;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab",
            "Evaluation"});
            this.comboBox1.Location = new System.Drawing.Point(985, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 34);
            this.comboBox1.TabIndex = 63;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(829, 743);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(629, 743);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Nor_Overlapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxRelatedTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAcademicYearAndSemester);
            this.Controls.Add(this.label1);
            this.Name = "Nor_Overlapping";
            this.Size = new System.Drawing.Size(1500, 857);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAcademicYearAndSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtBoxRelatedTag;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}
