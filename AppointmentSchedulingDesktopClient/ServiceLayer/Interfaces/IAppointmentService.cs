using AppointmentSchedulerUILibrary.AppointmentDTOs;
using AppointmentSchedulerUILibrary.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace AppointmentSchedulerUI.Repositories.Interfaces
{
    public interface IAppointmentService : ICrudService<CreateAppointmentDTO, GetAppointmentDTO, DeleteAppointmentDTO, long>
    {
        public Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAndAvailableTimeSlots(DateTime date);

        public Task<IEnumerable<GetAppointmentDTO>> GetAppointmentsByAccountId(long accountId);
    }
}
