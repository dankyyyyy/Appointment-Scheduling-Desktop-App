using AppointmentSchedulerUI.Repositories.Implementations;
using AppointmentSchedulerUI.Repositories.Interfaces;
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
    public partial class Employees_Screen : Form
    {
        private IAccountService _accountService;

        public Employees_Screen()
        {
            InitializeComponent();
            _accountService = new AccountService();
            LoadData();
        }

        #region Eventhandlers
        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Screen HomeScreen = new Home_Screen();
            HomeScreen.Show();
        }

        private void Appointments_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments_Screen AppointmentsScreen = new Appointments_Screen();
            AppointmentsScreen.Show();
        }

        private void Services_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services_Screen ServicesScreen = new Services_Screen();
            ServicesScreen.Show();
        }

        private void Customers_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers CustomersScreen = new Customers();
            CustomersScreen.Show();
        }
        #endregion

        #region Functionality

        private async Task LoadData()
        {
            try
            {
                lstEmployees.Items.Clear();
                var employeeList = await _accountService.GetAllEmployees();
                foreach(var employee in employeeList)
                {
                    lstEmployees.Items.Add(employee);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error retrieving data from the database. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lstEmployees.Items.Count > 0) { lstEmployees.SelectedIndex = 0; }
        }

        #endregion
    }
}
