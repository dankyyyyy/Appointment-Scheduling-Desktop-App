using AppointmentSchedulerUILibrary;
using AppointmentSchedulerUILibrary.Credentials;
using RestSharp;

namespace AppointmentSchedulerUI.Repositories.Interfaces
{
    //todo change ID type to long
    //todo refactor this so it uses a better DTO / or just rename it to DTO
    public interface IAccountService : ICrudService<SignupCredential, SignupCredential, SignupCredential, int>
    {
        public Task<AccountDetails> Authenticate(LoginCredential credential);
        public Task<RestResponse> SaveEmployee(EmployeeSignupCredential credential);
    }
}
