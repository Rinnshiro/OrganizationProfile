namespace OrganizationProfile
{
    partial class frmRegistration
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
			lblTitle = new Label();
			txtStudentNo = new TextBox();
			cbPrograms = new ComboBox();
			txtLastName = new TextBox();
			txtFirstName = new TextBox();
			txtMiddleInitial = new TextBox();
			txtAge = new TextBox();
			cbGender = new ComboBox();
			datePickerBirthday = new DateTimePicker();
			txtContactNo = new TextBox();
			btnRegister = new Button();
			lblStudentNo = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			lblContactNo = new Label();
			label5 = new Label();
			lblFirstName = new Label();
			lblProgram = new Label();
			lblMiddleInitial = new Label();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.Black;
			lblTitle.Location = new Point(20, 15);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(151, 33);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Registration";
			// 
			// txtStudentNo
			// 
			txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
			txtStudentNo.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtStudentNo.Location = new Point(110, 60);
			txtStudentNo.Name = "txtStudentNo";
			txtStudentNo.Size = new Size(150, 23);
			txtStudentNo.TabIndex = 1;
			// 
			// cbPrograms
			// 
			cbPrograms.BackColor = Color.White;
			cbPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPrograms.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbPrograms.FormattingEnabled = true;
			cbPrograms.Location = new Point(422, 61);
			cbPrograms.Name = "cbPrograms";
			cbPrograms.Size = new Size(222, 23);
			cbPrograms.TabIndex = 2;
			// 
			// txtLastName
			// 
			txtLastName.BorderStyle = BorderStyle.FixedSingle;
			txtLastName.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtLastName.Location = new Point(110, 95);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(150, 23);
			txtLastName.TabIndex = 3;
			// 
			// txtFirstName
			// 
			txtFirstName.BorderStyle = BorderStyle.FixedSingle;
			txtFirstName.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtFirstName.Location = new Point(422, 95);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(150, 23);
			txtFirstName.TabIndex = 4;
			// 
			// txtMiddleInitial
			// 
			txtMiddleInitial.BorderStyle = BorderStyle.FixedSingle;
			txtMiddleInitial.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtMiddleInitial.Location = new Point(619, 95);
			txtMiddleInitial.MaxLength = 1;
			txtMiddleInitial.Name = "txtMiddleInitial";
			txtMiddleInitial.Size = new Size(40, 23);
			txtMiddleInitial.TabIndex = 5;
			// 
			// txtAge
			// 
			txtAge.BorderStyle = BorderStyle.FixedSingle;
			txtAge.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtAge.Location = new Point(110, 130);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(100, 23);
			txtAge.TabIndex = 6;
			// 
			// cbGender
			// 
			cbGender.BackColor = Color.White;
			cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
			cbGender.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbGender.FormattingEnabled = true;
			cbGender.Items.AddRange(new object[] { "Male", "Female" });
			cbGender.Location = new Point(422, 131);
			cbGender.Name = "cbGender";
			cbGender.Size = new Size(164, 23);
			cbGender.TabIndex = 7;
			// 
			// datePickerBirthday
			// 
			datePickerBirthday.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			datePickerBirthday.Location = new Point(110, 165);
			datePickerBirthday.Name = "datePickerBirthday";
			datePickerBirthday.Size = new Size(196, 22);
			datePickerBirthday.TabIndex = 8;
			// 
			// txtContactNo
			// 
			txtContactNo.BorderStyle = BorderStyle.FixedSingle;
			txtContactNo.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtContactNo.Location = new Point(422, 163);
			txtContactNo.Name = "txtContactNo";
			txtContactNo.Size = new Size(150, 23);
			txtContactNo.TabIndex = 9;
			// 
			// btnRegister
			// 
			btnRegister.BackColor = Color.Black;
			btnRegister.FlatAppearance.BorderSize = 0;
			btnRegister.FlatStyle = FlatStyle.Popup;
			btnRegister.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnRegister.ForeColor = Color.White;
			btnRegister.Location = new Point(279, 249);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(137, 44);
			btnRegister.TabIndex = 10;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = false;
			btnRegister.Click += btnRegister_Click;
			// 
			// lblStudentNo
			// 
			lblStudentNo.AutoSize = true;
			lblStudentNo.Font = new Font("Calibri", 12F, FontStyle.Bold);
			lblStudentNo.ForeColor = Color.Black;
			lblStudentNo.Location = new Point(11, 61);
			lblStudentNo.Name = "lblStudentNo";
			lblStudentNo.Size = new Size(92, 19);
			lblStudentNo.TabIndex = 11;
			lblStudentNo.Text = "Student No.";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(12, 95);
			label1.Name = "label1";
			label1.Size = new Size(80, 19);
			label1.TabIndex = 12;
			label1.Text = "Last Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(59, 131);
			label2.Name = "label2";
			label2.Size = new Size(35, 19);
			label2.TabIndex = 13;
			label2.Text = "Age";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(27, 167);
			label3.Name = "label3";
			label3.Size = new Size(68, 19);
			label3.TabIndex = 14;
			label3.Text = "Birthday";
			// 
			// lblContactNo
			// 
			lblContactNo.AutoSize = true;
			lblContactNo.Font = new Font("Calibri", 12F, FontStyle.Bold);
			lblContactNo.ForeColor = Color.Black;
			lblContactNo.Location = new Point(326, 165);
			lblContactNo.Name = "lblContactNo";
			lblContactNo.Size = new Size(90, 19);
			lblContactNo.TabIndex = 15;
			lblContactNo.Text = "Contact No.";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(357, 130);
			label5.Name = "label5";
			label5.Size = new Size(59, 19);
			label5.TabIndex = 16;
			label5.Text = "Gender";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Font = new Font("Calibri", 12F, FontStyle.Bold);
			lblFirstName.ForeColor = Color.Black;
			lblFirstName.Location = new Point(334, 95);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(82, 19);
			lblFirstName.TabIndex = 17;
			lblFirstName.Text = "First Name";
			// 
			// lblProgram
			// 
			lblProgram.AutoSize = true;
			lblProgram.Font = new Font("Calibri", 12F, FontStyle.Bold);
			lblProgram.ForeColor = Color.Black;
			lblProgram.Location = new Point(348, 62);
			lblProgram.Name = "lblProgram";
			lblProgram.Size = new Size(68, 19);
			lblProgram.TabIndex = 18;
			lblProgram.Text = "Program";
			// 
			// lblMiddleInitial
			// 
			lblMiddleInitial.AutoSize = true;
			lblMiddleInitial.Font = new Font("Calibri", 12F, FontStyle.Bold);
			lblMiddleInitial.ForeColor = Color.Black;
			lblMiddleInitial.Location = new Point(578, 95);
			lblMiddleInitial.Name = "lblMiddleInitial";
			lblMiddleInitial.Size = new Size(35, 19);
			lblMiddleInitial.TabIndex = 19;
			lblMiddleInitial.Text = "M.I.";
			// 
			// frmRegistration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(782, 361);
			Controls.Add(lblMiddleInitial);
			Controls.Add(lblProgram);
			Controls.Add(lblFirstName);
			Controls.Add(label5);
			Controls.Add(lblContactNo);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lblStudentNo);
			Controls.Add(btnRegister);
			Controls.Add(txtContactNo);
			Controls.Add(datePickerBirthday);
			Controls.Add(cbGender);
			Controls.Add(txtAge);
			Controls.Add(txtMiddleInitial);
			Controls.Add(txtFirstName);
			Controls.Add(txtLastName);
			Controls.Add(cbPrograms);
			Controls.Add(txtStudentNo);
			Controls.Add(lblTitle);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "frmRegistration";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Organization Profile";
			Load += frmRegistration_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTitle;
        private TextBox txtStudentNo;
        private ComboBox cbPrograms;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtAge;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private TextBox txtContactNo;
        private Button btnRegister;
        private Label lblStudentNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblContactNo;
        private Label label5;
        private Label lblFirstName;
        private Label lblProgram;
        private Label lblMiddleInitial;
    }
}