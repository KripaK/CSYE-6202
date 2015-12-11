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
    public partial class FlightListView : Form
    {
        public FlightListView()
        {
            InitializeComponent();
            populatTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void populatTable()
        {
            String str = @"Data Source=KRIPAKALYAN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AirlineManagement";
            //sqlConnection.Open();
            String query = "select flight_name from FlightTable";
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            flightDataGrid.ReadOnly = true;
            flightDataGrid.DataSource = ds.Tables[0];
        }

        private void flightDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//get the Row Index             
            DataGridViewRow row = flightDataGrid.Rows[i];
            string flight = row.Cells[0].Value.ToString();

            AddFlight form = new AddFlight(flight);
            form.Show();
        }

        private void FlightListView_Load(object sender, EventArgs e)
        {

        }
    }
}
