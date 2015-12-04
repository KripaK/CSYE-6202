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
    public partial class StudentRegistrationForm : Form
    {
        private List<Student> mockStudentList;
        public StudentRegistrationForm(List<Student> mockStudentList)
        {
            InitializeComponent();
            Init();

            this.mockStudentList = mockStudentList;
        }

        private void Init()
        {
            LoadDepartments();
            LoadDataGridWithMockData();
            LoadDefaults();
            //HandleDataGridViewStudentsSelectionChanged();
        }

        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        // since we don't know ADO.NET and/or File I/O we will get static mock data
        private void LoadDataGridWithMockData()
        {
            //mockStudentList = new List<Student>()
            //{
            //    new Student("111-11-1212", "Bart", "Simpson", "Information Systems", "Full Time"),
            //    new Student("123-12-1234", "Maggie", "Simpson", "International Affairs", "Part Time"),
            //};

            // dirty workaround to make sure that we can bind to the static mock list
            var bindingList = new BindingList<Student>(mockStudentList);
            var source = new BindingSource(bindingList, null); 
            dataGridViewStudents.DataSource = source;
        }

        private void LoadDefaults()
        {
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;

        }


        private void HandleDataGridViewStudentsSelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                studentText.Text = row.Cells[0].Value.ToString();
                firstText.Text = row.Cells[1].Value.ToString();
                lastText.Text = row.Cells[2].Value.ToString();

                comboBoxDepartment.SelectedIndex = comboBoxDepartment.Items.IndexOf(row.Cells[3].Value.ToString());

                // enrollment type selection driven by the grid itself
                var enrollmentType = row.Cells[4].Value.ToString();
                if (radioButtonFullTime.Text == enrollmentType)
                {
                    radioButtonFullTime.Checked = true;
                }
                else if (radioButtonPartTime.Text == enrollmentType)
                {
                    radioButtonPartTime.Checked = true;
                }
            }
        }
        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudentForm form = new NewStudentForm(mockStudentList);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveStudentForm form = new RemoveStudentForm(mockStudentList);
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditStudentForm form = new EditStudentForm(mockStudentList);
            form.Show();
            this.Hide();
        }
    }
}
