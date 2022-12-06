using AppointmentSchedulerUI.Repositories.Interfaces;
using AppointmentSchedulerUI.Views;
using AppointmentSchedulerUILibrary.AppointmentDTOs;
using AppointmentSchedulerUILibrary.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using AppointmentSchedulerUI.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using System.Linq;
using System.Net;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Net.NetworkInformation;

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace AppointmentSchedulerUI.Repositories.Implementations
{
    public class AppointmentService : IAppointmentService
    {

        public string BaseUri { get; private set; }

        private RestClient AppointmentRest { get; set; }

        public AppointmentService(string baseUri)
        {
            BaseUri = baseUri;
            AppointmentRest = new RestClient(baseUri);
        }

        public Task Delete(DeleteAppointmentDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAll(IEnumerable<DeleteAppointmentDTO> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetAppointmentDTO>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetAppointmentDTO>> FindAllById(IEnumerable<long> Ids)
        {
            throw new NotImplementedException();
        }

        public async Task<GetAppointmentDTO> FindById(long id)
        {
            using var client = new RestClient(ServerUrl.AppointmentUrl + "/" + id);
            var request = new RestRequest("", Method.Get);
            HttpContextAccessor httpContextAccessor = new();

            var response = await client.ExecuteAsync(request);

            var appointment = JsonConvert.DeserializeObject<GetAppointmentDTO>(response.Content);

            return appointment;
        }

        public Task<int> SaveAll(IEnumerable<CreateAppointmentDTO> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<RestResponse> Save(CreateAppointmentDTO entity)
        {
            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();

            if (!httpContextAccessor.HttpContext.User.IsInRole("Admin") 
                || !httpContextAccessor.HttpContext.User.IsInRole("User"))
            {
                return null;
            }

            using var client = new RestClient(ServerUrl.EmployoeeUrl);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var claim = httpContextAccessor.HttpContext.User.Claims.First(c => c.Type == "Bearer");
            request.AddHeader("Authorization", claim.Value);
            var body = JsonSerializer.Serialize(entity);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            return await client.ExecuteAsync(request);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAndAvailableTimeSlots(DateTime date)
        {
            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();

            /*            if (!httpContextAccessor.HttpContext.User.IsInRole("Admin")
                            || !httpContextAccessor.HttpContext.User.IsInRole("User"))
                        {
                            return null;
                        }*/
            string UrlWithDate = "https://localhost:7052/api/Appointment?dateOfAppointment=2022-12-01";
            using var client = new RestClient(UrlWithDate);
            var request = new RestRequest("GetAllEmployeesAndAvailableTimeSlots", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            var claim = httpContextAccessor.HttpContext.User.Claims.First(c => c.Type == "Bearer");
            request.AddHeader("Authorization", claim.Value);
            var body = JsonSerializer.Serialize(date);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            //todo, throws not found
            var response= await client.ExecuteAsync(request);
            Console.WriteLine(response);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetAppointmentDTO>> GetAppointmentsByAccountId(long id)
        {
            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            string role = "Admin";

            //IF ITS EMPLOYEE ACCOUNT THEN YOU WILL GET IT BY EMPLOYEEID
            //if (httpContextAccessor.HttpContext.User.IsInRole("Employee") || httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            //{
            //    role = "employee";
            //}

            using var client = new RestClient(ServerUrl.AppointmentUrl + $"/{role}/{id}");
            var request = new RestRequest(id.ToString());

            var response = await client.ExecuteAsync<GetAppointmentDTO>(request);

            var appointmentList = JsonConvert.DeserializeObject<IEnumerable<GetAppointmentDTO>>(response.Content);

            return appointmentList;
        }
    }
}
