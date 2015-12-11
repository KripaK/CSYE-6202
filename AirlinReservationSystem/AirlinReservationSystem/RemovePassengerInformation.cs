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
    public partial class RemovePassengerInformation : Form
    {
        string flight;
        private SqlConnection connection = null;
        public RemovePassengerInformation(string flight)
        {
            InitializeComponent();
            this.flight = flight;
          //  populatTable();
        }

        private void RemovePassengerInformation_Load(object sender, EventArgs e)
        {

        }
        private void populatTable()
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select first_name, last_name FROM PassengerTable where flight_name =  '" + flight + "'";
                
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
          //  fullDataGrid.ReadOnly = true;
            //fullDataGrid.DataSource = ds.Tables[0];
        }

        private void fullDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string firstName = userText.Text;
            string lastName = lastText.Text;

            //Passenger pass = new Passenger(firstName, lastName, dob, passportNumber, flightName);

            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "delete from PassengerTable where first_name = '" + firstName + "' and last_name = '" + lastName + "' ";

            //String query = "select * from LoginTable where username = '" + userText.Text + "'and password = '" + this.passwordText.Text + "'";
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;

            con.Open();

            dbr = cmd.ExecuteReader();
            //SqlConnection con = new SqlConnection(str);
            //con.Open();
            //// execute this insert statement using our connection
            //using (SqlCommand command = new SqlCommand(query, connection))
            //{
            //    command.ExecuteNonQuery();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightListView form = new FlightListView();
            form.Show();
            this.Hide();
        }
    }
}
