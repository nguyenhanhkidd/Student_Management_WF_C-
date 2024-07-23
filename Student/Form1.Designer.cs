namespace Student
{
    partial class Form1
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
            this.lsvStudent = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvStudent
            // 
            this.lsvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvStudent.HideSelection = false;
            this.lsvStudent.Location = new System.Drawing.Point(0, 430);
            this.lsvStudent.Name = "lsvStudent";
            this.lsvStudent.Size = new System.Drawing.Size(1134, 190);
            this.lsvStudent.TabIndex = 0;
            this.lsvStudent.UseCompatibleStateImageBehavior = false;
            this.lsvStudent.View = System.Windows.Forms.View.Details;
            this.lsvStudent.SelectedIndexChanged += new System.EventHandler(this.lsvStudent_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbCourse);
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.lbCourse);
            this.groupBox1.Controls.Add(this.lbDescription);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbSex);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(832, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 42);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(601, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 42);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(360, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(113, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "SE07201",
            "SE07202",
            "SE07203"});
            this.cbCourse.Location = new System.Drawing.Point(470, 115);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(195, 28);
            this.cbCourse.TabIndex = 10;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(578, 44);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(93, 24);
            this.rbF.TabIndex = 8;
            this.rbF.TabStop = true;
            this.rbF.Text = "Female";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(470, 42);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(72, 24);
            this.rbM.TabIndex = 7;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(151, 115);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(210, 26);
            this.tbName.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(151, 192);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(210, 26);
            this.tbPhone.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(722, 79);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(197, 130);
            this.tbDescription.TabIndex = 12;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(151, 47);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(210, 26);
            this.tbID.TabIndex = 1;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(404, 121);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(66, 20);
            this.lbCourse.TabIndex = 9;
            this.lbCourse.Text = "Course";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(770, 46);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(100, 20);
            this.lbDescription.TabIndex = 11;
            this.lbDescription.Text = "Description";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(47, 198);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(60, 20);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Phone";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(404, 46);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(39, 20);
            this.lbSex.TabIndex = 6;
            this.lbSex.Text = "Sex";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(47, 118);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(47, 46);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvStudent);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
    }
}

