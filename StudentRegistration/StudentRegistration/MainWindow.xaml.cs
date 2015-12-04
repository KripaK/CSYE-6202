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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentRegistration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> mockStudentList = new List<Student>()
            {
                new Student("111-11-1212", "Bart", "Simpson", "Information Systems", "Full Time"),
                new Student("123-12-1234", "Maggie", "Simpson", "International Affairs", "Part Time"),
            };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            //string text = textBox.Text;
            //string pass = passwordBox.Password;
            //MainWindow obj = new MainWindow();
            StudentRegistrationForm form = new StudentRegistrationForm(mockStudentList);
            //if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            //{
            //    obj.Show();
            //}
            //else if (string.Compare(text, "demouser") == 0 && string.Compare(pass, "demouser") == 0)
            //{
            //    form.Show();
            //}
            //else
            //{
            form.Show();
            //}
        }

        private void signButton_Click_1(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            string pass = passwordBox.Password;
            // MainWindow obj = new MainWindow();
            try { 
            StudentRegistrationForm form = new StudentRegistrationForm(mockStudentList);
            
                if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
                {
                    // obj.Show();
                    MessageBox.Show("Invalid username or password");
                }
                else if (string.Compare(text, "demouser") == 0 && string.Compare(pass, "demouser") == 0)
                {
                    form.Show();
                }
                else
                {
                    form.Show();
                }
            }
            catch
            {
                MessageBox.Show("Exception");
            }
        }
    }
}
