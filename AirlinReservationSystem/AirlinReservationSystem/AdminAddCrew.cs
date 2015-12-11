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
    public partial class AdminAddCrew : Form
    {
        private SqlConnection connection = null;
        string flightName;

        public AdminAddCrew(string flightName)
        {
            InitializeComponent();
            this.flightName = flightName;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string firstName = firstText.Text;
            string lastName = lastText.Text;
            //string dob = dobText.Text;
            //string passportNumber = passportText.Text;

            Crew crew = new Crew(firstName, lastName, flightName);

            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from FlightTable where flight_name = '" + flightName + "'";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = string.Format("Insert Into CrewTable" +
                "(first_name, last_name, flight_name) Values" +
                "('{0}', '{1}', '{2}')", crew.FirstName, crew.LastName, crew.FlightName);

            // execute this insert statement using our connection
            OpenConnection(str);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void OpenConnection(string connectionString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFlightModification form = new AdminFlightModification();
            form.Show();
            this.Hide();
        }
    }
}
