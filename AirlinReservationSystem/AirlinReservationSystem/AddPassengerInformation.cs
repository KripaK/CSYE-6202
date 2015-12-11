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
    public partial class AddPassengerInformation : Form
    {
        string flightName;
        private SqlConnection connection = null;

        Random randomizer = new Random();

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft=30;
        public AddPassengerInformation(string flightName)
        {
            InitializeComponent();
            this.flightName = flightName;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string firstName = firstText.Text;
            string lastName = lastText.Text;
            string dob = dobText.Text;
            string passportNumber = passportText.Text;

            Passenger pass = new Passenger(firstName, lastName, dob, passportNumber, flightName);

            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from FlightTable where flight_name = '" + flightName + "'";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = string.Format("Insert Into PassengerTable" +
                "(first_name, last_name, dob, passport_number, flight_name) Values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}')", pass.FirstName, pass.LastName, pass.DOB, pass.PassNumber, pass.flightName);

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
            FlightListView form = new FlightListView();
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
           
                FlightListView form = new FlightListView();
                form.Show();
                this.Hide();
            }
        }
    }
}
