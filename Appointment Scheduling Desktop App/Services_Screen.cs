using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduling_Desktop_App
{
    public partial class Services_Screen : Form
    {
        public Services_Screen()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Screen HomeScreen = new Home_Screen();
            HomeScreen.Show();
        }

        private void Employees_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees_Screen EmployeesScreen = new Employees_Screen();
            EmployeesScreen.Show();

        }

        private void Appointments_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments_Screen AppointmentsScreen = new Appointments_Screen();
            AppointmentsScreen.Show();
        }

        private void Customers_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers CustomersScreen = new Customers();
            CustomersScreen.Show();
        }
    }
}
