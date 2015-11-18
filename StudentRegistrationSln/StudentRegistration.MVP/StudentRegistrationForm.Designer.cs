namespace StudentRegistration.MVP
{
	partial class StudentRegistrationForm
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
			this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
			this.groupBoxEnrollmentType = new System.Windows.Forms.GroupBox();
			this.radioButtonPartTime = new System.Windows.Forms.RadioButton();
			this.radioButtonFullTime = new System.Windows.Forms.RadioButton();
			this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblStudentID = new System.Windows.Forms.Label();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.groupBoxStudentInfo.SuspendLayout();
			this.groupBoxEnrollmentType.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxStudentInfo
			// 
			this.groupBoxStudentInfo.Controls.Add(this.groupBoxEnrollmentType);
			this.groupBoxStudentInfo.Controls.Add(this.comboBoxDepartment);
			this.groupBoxStudentInfo.Controls.Add(this.textBox4);
			this.groupBoxStudentInfo.Controls.Add(this.textBox3);
			this.groupBoxStudentInfo.Controls.Add(this.textBox2);
			this.groupBoxStudentInfo.Controls.Add(this.lblDepartment);
			this.groupBoxStudentInfo.Controls.Add(this.lblLastName);
			this.groupBoxStudentInfo.Controls.Add(this.lblFirstName);
			this.groupBoxStudentInfo.Controls.Add(this.lblStudentID);
			this.groupBoxStudentInfo.Location = new System.Drawing.Point(13, 13);
			this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
			this.groupBoxStudentInfo.Size = new System.Drawing.Size(601, 231);
			this.groupBoxStudentInfo.TabIndex = 0;
			this.groupBoxStudentInfo.TabStop = false;
			this.groupBoxStudentInfo.Text = "Student Info";
			// 
			// groupBoxEnrollmentType
			// 
			this.groupBoxEnrollmentType.Controls.Add(this.radioButtonPartTime);
			this.groupBoxEnrollmentType.Controls.Add(this.radioButtonFullTime);
			this.groupBoxEnrollmentType.Location = new System.Drawing.Point(316, 33);
			this.groupBoxEnrollmentType.Name = "groupBoxEnrollmentType";
			this.groupBoxEnrollmentType.Size = new System.Drawing.Size(257, 141);
			this.groupBoxEnrollmentType.TabIndex = 9;
			this.groupBoxEnrollmentType.TabStop = false;
			this.groupBoxEnrollmentType.Text = "Enrollment Type";
			// 
			// radioButtonPartTime
			// 
			this.radioButtonPartTime.AutoSize = true;
			this.radioButtonPartTime.Location = new System.Drawing.Point(141, 62);
			this.radioButtonPartTime.Name = "radioButtonPartTime";
			this.radioButtonPartTime.Size = new System.Drawing.Size(90, 21);
			this.radioButtonPartTime.TabIndex = 1;
			this.radioButtonPartTime.TabStop = true;
			this.radioButtonPartTime.Text = "Part Time";
			this.radioButtonPartTime.UseVisualStyleBackColor = true;
			// 
			// radioButtonFullTime
			// 
			this.radioButtonFullTime.AutoSize = true;
			this.radioButtonFullTime.Location = new System.Drawing.Point(7, 62);
			this.radioButtonFullTime.Name = "radioButtonFullTime";
			this.radioButtonFullTime.Size = new System.Drawing.Size(86, 21);
			this.radioButtonFullTime.TabIndex = 0;
			this.radioButtonFullTime.TabStop = true;
			this.radioButtonFullTime.Text = "Full Time";
			this.radioButtonFullTime.UseVisualStyleBackColor = true;
			// 
			// comboBoxDepartment
			// 
			this.comboBoxDepartment.FormattingEnabled = true;
			this.comboBoxDepartment.Location = new System.Drawing.Point(108, 146);
			this.comboBoxDepartment.Name = "comboBoxDepartment";
			this.comboBoxDepartment.Size = new System.Drawing.Size(170, 24);
			this.comboBoxDepartment.TabIndex = 8;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(108, 108);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(170, 22);
			this.textBox4.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(108, 68);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(170, 22);
			this.textBox3.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(108, 30);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(170, 22);
			this.textBox2.TabIndex = 5;
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Location = new System.Drawing.Point(19, 153);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(82, 17);
			this.lblDepartment.TabIndex = 3;
			this.lblDepartment.Text = "Department";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(19, 113);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(76, 17);
			this.lblLastName.TabIndex = 2;
			this.lblLastName.Text = "Last Name";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(19, 73);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(76, 17);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "First Name";
			// 
			// lblStudentID
			// 
			this.lblStudentID.AutoSize = true;
			this.lblStudentID.Location = new System.Drawing.Point(19, 33);
			this.lblStudentID.Name = "lblStudentID";
			this.lblStudentID.Size = new System.Drawing.Size(74, 17);
			this.lblStudentID.TabIndex = 0;
			this.lblStudentID.Text = "Student ID";
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.AllowUserToAddRows = false;
			this.dataGridViewStudents.AllowUserToDeleteRows = false;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridViewStudents.Location = new System.Drawing.Point(13, 261);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.ReadOnly = true;
			this.dataGridViewStudents.RowTemplate.Height = 24;
			this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewStudents.Size = new System.Drawing.Size(601, 356);
			this.dataGridViewStudents.TabIndex = 3;
			this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.HandleDataGridViewStudentsSelectionChanged);
			//	

			// StudentRegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 629);
			this.Controls.Add(this.dataGridViewStudents);
			this.Controls.Add(this.groupBoxStudentInfo);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(647, 670);
			this.Name = "StudentRegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Registration Form";
			this.groupBoxStudentInfo.ResumeLayout(false);
			this.groupBoxStudentInfo.PerformLayout();
			this.groupBoxEnrollmentType.ResumeLayout(false);
			this.groupBoxEnrollmentType.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxStudentInfo;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblStudentID;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBoxDepartment;
		private System.Windows.Forms.GroupBox groupBoxEnrollmentType;
		private System.Windows.Forms.RadioButton radioButtonPartTime;
		private System.Windows.Forms.RadioButton radioButtonFullTime;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
	}
}

