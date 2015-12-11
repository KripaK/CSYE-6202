using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinReservationSystem
{
    public partial class AdminFlow : Form
    {
        public AdminFlow()
        {
            InitializeComponent();
        }

        private void AdminFlow_Load(object sender, EventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            FlightListView form = new FlightListView();
            form.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminFlightModification form = new AdminFlightModification();
            form.Show();
        }
    }
}
