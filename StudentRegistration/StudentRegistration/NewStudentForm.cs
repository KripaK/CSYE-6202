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
    public partial class NewStudentForm : Form
    {
        private List<Student> mockStudentList;
        string firstName, lastName, nuid, dept, enrollType;

        public NewStudentForm(List<Student> mockStudentList)
        {
            InitializeComponent();
            LoadDepartments();
            LoadDefaults();
            this.mockStudentList = mockStudentList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstText.Clear();
            lastText.Clear();
            studentText.Clear();
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                StudentRegistrationWarning popup = new StudentRegistrationWarning();
                DialogResult dialogresult = popup.ShowDialog();
                if (dialogresult == DialogResult.OK)
                {
                    popup.Close();
                }
                popup.Dispose();
                this.Close();
            }
            else if (check() == true)
            {
                RemoveStudentRegistration popup2 = new RemoveStudentRegistration();
                DialogResult dialogresult2 = popup2.ShowDialog();
                if (dialogresult2 == DialogResult.No)
                {
                    popup2.Close();
                    this.Close();
                }
                else
                {
                    loadData();
                    StudentRegistrationForm form = new StudentRegistrationForm(mockStudentList);
                    form.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            firstText.Clear();
            lastText.Clear();
            studentText.Clear();
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;
        }

        //public NewStudentForm(List<Student> mockStudentList)
        //{
        //    this.mockStudentList = mockStudentList;
        //}

        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void LoadDefaults()
        {
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;

        }

        private void loadData()
        {
            firstName = firstText.Text; ;
            lastName = lastText.Text;
            nuid = studentText.Text;
            //if(string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrEmpty(nuid) || string.IsNullOrWhiteSpace(nuid))
            //{
            //    StudentRegistrationWarning popup = new StudentRegistrationWarning();
            //    DialogResult dialogresult = popup.ShowDialog();
            //    if (dialogresult == DialogResult.OK)
            //    {
            //        popup.Close();
            //    }
            //    popup.Dispose();
            //}
            dept = comboBoxDepartment.SelectedItem.ToString();
            if (radioButtonFullTime.Checked == true)
            {
                enrollType = "Full Time";
            }
            else
            {
                enrollType = "Part Time";
            }
            Student student = new Student(nuid, firstName, lastName, dept, enrollType);
            mockStudentList.Add(student);
            //mockStudentList = new List<Student>() { (new Student(nuid, firstName, lastName, dept, enrollType)) };

        }

        private Boolean check()
        {
            if ((string.IsNullOrEmpty(firstText.Text)) || (string.IsNullOrWhiteSpace(firstText.Text)) || (string.IsNullOrEmpty(lastText.Text)) || (string.IsNullOrWhiteSpace(lastText.Text)) || (string.IsNullOrEmpty(studentText.Text)) || (string.IsNullOrWhiteSpace(studentText.Text)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void NewStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
