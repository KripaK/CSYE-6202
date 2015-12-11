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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;

            //Passenger pass = new Passenger(firstName, lastName, dob, passportNumber, flightName);

            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            //String query = "insert into LoginTable (username, password, firstname) values" + "('{0}', '{1}', '{2}')"  '" + firstName + "' and last_name = '" + lastName + "' ";

            //String query = "select * from LoginTable where username = '" + userText.Text + "'and password = '" + this.passwordText.Text + "'";
            SqlConnection con = new SqlConnection(str);

            //SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;

            con.Open();
            SqlCommand cmd = new SqlCommand(" Insert into LoginTable (username, password, firstname) VALUES('" + userName + "','" + password + "' ,'" + name + "')", con);
            cmd.ExecuteNonQuery();

            dbr = cmd.ExecuteReader();
        }
    }
}
