using AppointmentSchedulerUI.DAL.Implementations;
using AppointmentSchedulerUI.Repositories.Interfaces;

namespace Appointment_Scheduling_Desktop_App
{
    public partial class Appointments_Screen : Form
    {
        private IAppointmentService _appointmentService;

        public Appointments_Screen()
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();
            LoadData();
        }

        #region Eventhandlers
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
                lstAppointments.Items.Clear();
                var appointmentList = await _appointmentService.GetAppointmentsByAccountId(9);
                foreach (var appointment in appointmentList)
                {
                    lstAppointments.Items.Add(appointment);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data from the database. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lstAppointments.Items.Count > 0) { lstAppointments.SelectedIndex = 0; }
        }

        private void UpdateUi()
        {
            if(lstAppointments.SelectedIndex != -1)
            {
                UpdateSelectedAppointmentOnUI();
            }
            else
            {
                Console.WriteLine("hi");
            }
        }


        //TODO implement the methods
        private void EditSelectedAppointment()
        {

        }

        private void DeleteSelectedAppointment()
        {

        }

        private void ApproveSelectedAppointment()
        {

        }

        private void UpdateSelectedAppointmentOnUI()
        {
            if (lstAppointments.SelectedIndex == -1) { return; }
            AppointmentService appointmentService = (AppointmentService)lstAppointments.SelectedItem;
            //TypeLabel.Text = appointmentService.Name;
        }
    }
    #endregion
}