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
    public partial class AddFlight : Form
    {
        string flightName;
        public AddFlight(string flightName)
        {
            InitializeComponent();
            
            this.flightName = flightName;
            populatTable();
            populateTable();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }
        private void populatTable()
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from FlightTable where flight_name = '" + flightName + "'";
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            flightDataGrid.ReadOnly = true;
            flightDataGrid.DataSource = ds.Tables[0];
        }

        private void populateTable()
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from PassengerTable where flight_name = '" + flightName + "'";
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGrid.ReadOnly = true;
            dataGrid.DataSource = ds.Tables[0];
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            AddPassengerInformation form = new AddPassengerInformation(flightName);
            form.Show();
            this.Hide();
        }

        private void flightDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;//get the Row Index             
            //DataGridViewRow row = flightDataGrid.Rows[i];
            //string flight = row.Cells[0].Value.ToString();

            //RemovePassengerInformation form = new RemovePassengerInformation(flight);
            //form.Show();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemovePassengerInformation form = new RemovePassengerInformation(flightName);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightListView form = new FlightListView();
            form.Show();
            this.Hide();
        }
    }
}
