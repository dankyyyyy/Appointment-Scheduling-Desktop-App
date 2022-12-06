using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using AppointmentSchedulerUILibrary.AppointmentDTOs;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.AspNetCore.Http;
using AppointmentSchedulerUI.Views;
using AppointmentSchedulerUI.Repositories.Implementations;
using AppointmentSchedulerUI.Repositories.Interfaces;

namespace Appointment_Scheduling_Desktop_App
{
    public partial class Appointments_Screen : Form
    {
        private IAppointmentService dataAccess;
        
        public Appointments_Screen()
        {
            InitializeComponent();
            dataAccess = new AppointmentService("https://localhost:7052/api/v1/Appointment");
        }

        private void Appointment_Screen_Load(object sender, EventArgs e)
        {
            //UpdateAppointmentsGrid();
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

        private void LoadData()
        {
            try
            {
                lstAppointments.Items.Clear();
                foreach(var appointment in dataAccess.GetAppointmentsByAccountId(16))
                {
                    lstAppointments.Items.Add(appointment);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data from the server. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            throw new NotImplementedException();
        }


        //private void UpdateAppointmentsGrid()
        //{
        //    var client = new HttpClient();
        //    //TODO add the URI
        //    client.BaseAddress = new Uri("https://localhost:7052/api/v1/Appointment");
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    var response = client.GetAsync(client.BaseAddress + "/16").Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var data = response.Content.ReadAsStringAsync().Result;
        //        var appointments = new List<GetAppointmentDTO>();
        //        Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), appointments);

        //        appointmentsGrid.DataSource = appointments;
        //    }
        //    else
        //    {
        //        Console.WriteLine("END ME");
        //    }
        //}
    }
    #endregion
}