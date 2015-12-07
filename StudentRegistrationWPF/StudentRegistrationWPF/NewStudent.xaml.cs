using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentRegistrationWPF
{
    /// <summary>
    /// Interaction logic for NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        private List<Student> mockStudentList;
        string firstName, lastName, nuid, dept, enrollType;
        public NewStudent(List<Student> mockStudentList)
        {
            InitializeComponent();
            LoadDepartments();
            LoadDefaults();
            this.mockStudentList = mockStudentList;
        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            loadData();
            StudentRegistrationForm form = new StudentRegistrationForm(mockStudentList);
            form.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            firstText.Clear();
            lastText.Clear();
            studentText.Clear();
            radioButtonFullTime.Select();
            comboBoxDepartment.SelectedIndex = 0;
        }

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
            firstName = "bags";
            lastName = "hamsa";
            nuid = "111-233-545";
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
    }
}
