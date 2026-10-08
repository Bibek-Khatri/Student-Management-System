namespace Student_Management_System
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
            label1 = new Label();
            StudentId = new Label();
            StudentName = new Label();
            StudentRollno = new Label();
            Section = new Label();
            Age = new Label();
            label7 = new Label();
            Phonenumber = new Label();
            StdID = new TextBox();
            StdName = new TextBox();
            StdRoll = new TextBox();
            StdSec = new TextBox();
            StdAge = new TextBox();
            StdAddress = new TextBox();
            StdPhone = new TextBox();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            Clear = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(365, 31);
            label1.Name = "label1";
            label1.Size = new Size(240, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Management System";
            // 
            // StudentId
            // 
            StudentId.AutoSize = true;
            StudentId.Location = new Point(89, 138);
            StudentId.Name = "StudentId";
            StudentId.Size = new Size(79, 20);
            StudentId.TabIndex = 1;
            StudentId.Text = "Student ID";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Location = new Point(89, 184);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(49, 20);
            StudentName.TabIndex = 2;
            StudentName.Text = "Name";
            // 
            // StudentRollno
            // 
            StudentRollno.AutoSize = true;
            StudentRollno.Location = new Point(89, 228);
            StudentRollno.Name = "StudentRollno";
            StudentRollno.Size = new Size(59, 20);
            StudentRollno.TabIndex = 3;
            StudentRollno.Text = "Roll no.";
            // 
            // Section
            // 
            Section.AutoSize = true;
            Section.Location = new Point(89, 274);
            Section.Name = "Section";
            Section.Size = new Size(58, 20);
            Section.TabIndex = 4;
            Section.Text = "Section";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(89, 318);
            Age.Name = "Age";
            Age.Size = new Size(36, 20);
            Age.TabIndex = 5;
            Age.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 365);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // Phonenumber
            // 
            Phonenumber.AutoSize = true;
            Phonenumber.Location = new Point(89, 408);
            Phonenumber.Name = "Phonenumber";
            Phonenumber.Size = new Size(49, 20);
            Phonenumber.TabIndex = 7;
            Phonenumber.Text = "Ph no.";
            // 
            // StdID
            // 
            StdID.Location = new Point(170, 138);
            StdID.Name = "StdID";
            StdID.ReadOnly = true;
            StdID.Size = new Size(179, 27);
            StdID.TabIndex = 8;
            // 
            // StdName
            // 
            StdName.Location = new Point(170, 184);
            StdName.Name = "StdName";
            StdName.Size = new Size(179, 27);
            StdName.TabIndex = 9;
            // 
            // StdRoll
            // 
            StdRoll.Location = new Point(170, 228);
            StdRoll.Name = "StdRoll";
            StdRoll.Size = new Size(179, 27);
            StdRoll.TabIndex = 10;
            // 
            // StdSec
            // 
            StdSec.Location = new Point(170, 274);
            StdSec.Name = "StdSec";
            StdSec.Size = new Size(179, 27);
            StdSec.TabIndex = 11;
            // 
            // StdAge
            // 
            StdAge.Location = new Point(170, 318);
            StdAge.Name = "StdAge";
            StdAge.Size = new Size(179, 27);
            StdAge.TabIndex = 12;
            // 
            // StdAddress
            // 
            StdAddress.Location = new Point(170, 365);
            StdAddress.Name = "StdAddress";
            StdAddress.Size = new Size(179, 27);
            StdAddress.TabIndex = 13;
            // 
            // StdPhone
            // 
            StdPhone.Location = new Point(170, 408);
            StdPhone.Name = "StdPhone";
            StdPhone.Size = new Size(179, 27);
            StdPhone.TabIndex = 14;
            // 
            // Add
            // 
            Add.Location = new Point(70, 454);
            Add.Name = "Add";
            Add.Size = new Size(99, 30);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Update
            // 
            Update.Location = new Point(187, 454);
            Update.Name = "Update";
            Update.Size = new Size(99, 30);
            Update.TabIndex = 16;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(310, 454);
            Delete.Name = "Delete";
            Delete.Size = new Size(99, 30);
            Delete.TabIndex = 17;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Location = new Point(187, 506);
            Clear.Name = "Clear";
            Clear.Size = new Size(99, 30);
            Clear.TabIndex = 18;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(502, 471);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 574);
            Controls.Add(dataGridView1);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(StdPhone);
            Controls.Add(StdAddress);
            Controls.Add(StdAge);
            Controls.Add(StdSec);
            Controls.Add(StdRoll);
            Controls.Add(StdName);
            Controls.Add(StdID);
            Controls.Add(Phonenumber);
            Controls.Add(label7);
            Controls.Add(Age);
            Controls.Add(Section);
            Controls.Add(StudentRollno);
            Controls.Add(StudentName);
            Controls.Add(StudentId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label StudentId;
        private Label StudentName;
        private Label StudentRollno;
        private Label Section;
        private Label Age;
        private Label label7;
        private Label Phonenumber;
        private TextBox StdID;
        private TextBox StdName;
        private TextBox StdRoll;
        private TextBox StdSec;
        private TextBox StdAge;
        private TextBox StdAddress;
        private TextBox StdPhone;
        private Button Add;
        private Button Update;
        private Button Delete;
        private Button Clear;
        private DataGridView dataGridView1;
    }
}
