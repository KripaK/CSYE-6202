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
    public partial class AdminFlightModification : Form
    {
        string flight_name;
        public AdminFlightModification()
        {
            InitializeComponent();
            populatTable();
           populateTable();
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            AdminFlightAdd form = new AdminFlightAdd();
            form.Show();
        }

        private void AdminFlightModification_Load(object sender, EventArgs e)
        {

        }
        private void populatTable()
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select * from FlightTable";
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
            String query = "select * from CrewTable";
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            crewDataGrid.ReadOnly = true;
            crewDataGrid.DataSource = ds.Tables[0];
        }

        private void flightDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//get the Row Index             
            DataGridViewRow row = flightDataGrid.Rows[i];
            flight_name = row.Cells[0].Value.ToString();

            //populateTable(flight_name);
        }

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "delete from FlightTable where flight_name = '" + flight_name + "'";

            //String query = "select * from LoginTable where username = '" + userText.Text + "'and password = '" + this.passwordText.Text + "'";
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;

            con.Open();

            dbr = cmd.ExecuteReader();

            String query2 = "delete from CrewTable where flight_name = '" + flight_name + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);

            SqlDataReader dbr2;
            dbr2 = cmd2.ExecuteReader();

        }

        private void DeleteCrewButton_Click(object sender, EventArgs e)
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "delete from CrewTable where flight_name = '" + flight_name + "'";

            //String query = "select * from LoginTable where username = '" + userText.Text + "'and password = '" + this.passwordText.Text + "'";
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;

            con.Open();

            dbr = cmd.ExecuteReader();
        }

        private void AddCrewButton_Click(object sender, EventArgs e)
        {
            AdminAddCrew form = new AdminAddCrew(flight_name);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFlow form = new AdminFlow();
            form.Show();
        }
    }
}
