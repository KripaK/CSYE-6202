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
    public partial class AdminFlightAdd : Form
    {
        private SqlConnection connection = null;
        public AdminFlightAdd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string flightName = flightText.Text;
            string date = dateText.Text;
            string destination = destText.Text;
            string arrival = arrivalText.Text;
            string carrier = carrierText.Text;
            string class_name = classText.Text;

            Flight flight = new Flight(flightName, date, destination, arrival, carrier, class_name);

            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from FlightTable where flight_name = '" + flightName + "'";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = string.Format("Insert Into FlightTable" +
                "(flight_name, date, destination, arrival, carrier_name, class) Values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", flight.FlightName, flight.Date, flight.Destination, flight.Arrival, flight.CarrierName, flight.Class);

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
        }
    }
}
