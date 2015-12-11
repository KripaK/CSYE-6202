using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirlinReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from LoginTable where username = '" + userText.Text + "'and password = '" + this.passwordText.Text + "'";
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;

            con.Open();

            dbr = cmd.ExecuteReader();

            int count = 0;

            while (dbr.Read())

            {

                count = count + 1;

            }

            if (count >= 1)

            {
                if (check() == true)
                {
                    AdminFlow form = new AdminFlow();
                    form.Show();
                }
                else
                {
                    FlightListView form = new FlightListView();
                    form.Show();
                }
                MessageBox.Show("username and password is correct");

            }

            //else if (count > 1)

            //{

            //    MessageBox.Show("Duplicate username and password", "login page");

            //}

            else

            {

                MessageBox.Show(" username and password incorrect", "login page");

            }
        
    }
        public Boolean check()
        {
            if (string.Compare(userText.Text, "admin")==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistration form = new UserRegistration();
            form.Show();
        }
    }
}
