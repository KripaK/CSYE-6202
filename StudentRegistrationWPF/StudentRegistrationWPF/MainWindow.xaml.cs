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

namespace StudentRegistrationWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            string pass = passwordBox.Password;
            //Boolean check;
            int count = 0;
            MainWindow obj = new MainWindow();
            try
            {
                StudentRegistrationForm form = new StudentRegistrationForm(mockStudentList);

                if (check() == false)
                {
                    // obj.Show();
                    MessageBox.Show("Empty field/s");
                }
                else if (string.Compare(text, "demouser") == 0 && string.Compare(pass, "demouser") == 0)
                {
                    form.Show();
                }
                else if (string.Compare(text, "demouser") != 0 && string.Compare(pass, "demouser") != 0)
                {
                    count = count + 1;
                    if (count > 2)
                    {
                        MessageBox.Show("Entered wrong username and password three times");
                        obj.Close();

                    }
                    MessageBox.Show("Invalid username or password");
                    textBox.Clear();
                    passwordBox.Clear();
                }

                else
                {
                    obj.Close();
                }
            }
            catch
            {
                MessageBox.Show("Exception");

            }
        }

        private Boolean check()
        {
            if ((string.IsNullOrEmpty(textBox.Text)) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
