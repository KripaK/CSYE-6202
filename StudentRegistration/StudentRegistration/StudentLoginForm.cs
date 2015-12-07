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
    public partial class StudentLoginForm : Form
    {
        List<Student> mockStudentList;
        public StudentLoginForm(List<Student> mockStudentList)
        {
            InitializeComponent();
            this.mockStudentList = mockStudentList;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            string pass = passBox.Text;
            //   MainWindow obj = new MainWindow(mockStudentList);
            StudentRegistrationForm form = new StudentRegistrationForm(mockStudentList);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Invalid username or password");
            }
            if (string.Compare(text, "demouser") == 0 && string.Compare(pass, "demouser") == 0)
            {
                form.Show();
            }
            else
            {
                form.Show();
            }
        }
        private void StudentLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void signbutton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
