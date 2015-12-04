using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class EditStudentForm : Form
    {
        private List<Student> mockStudentList;
        string firstName, lastName, nuid, dept, enrollType;

        private void button2_Click(object sender, EventArgs e)
        {
            firstText.Clear();
            lastText.Clear();
            studentText.Clear();
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            firstName = firstText.Text;
            lastName = lastText.Text;
            nuid = studentText.Text;
            dept = comboBoxDepartment.SelectedItem.ToString();
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrEmpty(nuid) || string.IsNullOrWhiteSpace(nuid))
            {
                StudentRegistrationWarning popup = new StudentRegistrationWarning();
                DialogResult dialogresult = popup.ShowDialog();
                if (dialogresult == DialogResult.OK)
                {
                    popup.Close();
                }
                popup.Dispose();
            }
             
            else
            {
                mockStudentList.Find(p => p.StudentID == nuid).FirstName = firstName;
                mockStudentList.Find(p => p.StudentID == nuid).LastName = lastName;
            }
            this.Close();
        }

        public EditStudentForm(List<Student> mockStudentList)
        {
            InitializeComponent();
            this.mockStudentList = mockStudentList;
            LoadDepartments();
            LoadDefaults();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = firstText.Text;
            lastName = lastText.Text;
            nuid = studentText.Text;
            dept = comboBoxDepartment.SelectedItem.ToString();
            if (radioButtonFullTime.Checked == true)
            {
                enrollType = "Full Time";
            }
            else
            {
                enrollType = "Part Time";
            }

        }

        private void LoadDefaults()
        {
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;

        }

        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }
        private void EditStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
