using AppointmentSchedulerUI.Exceptions;
using AppointmentSchedulerUI.Repositories.Interfaces;
using AppointmentSchedulerUI.Views;
using AppointmentSchedulerUILibrary;
using AppointmentSchedulerUILibrary.Credentials;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Security.Claims;
using System.Text.Json;
using System.Web.Mvc;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace AppointmentSchedulerUI.Repositories.Implementations
{
    public class AccountService : IAccountService
    {
        public string BaseUri { get; private set; }

        private RestClient AccountRest { get; set; }

        public AccountService(string baseUri)
        {
            BaseUri = baseUri;
            AccountRest = new RestClient(baseUri);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<RestResponse> Save(SignupCredential credentials)
        {
            using var client = new RestClient(ServerUrl.AccountUrl);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonSerializer.Serialize(credentials);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            return await client.ExecuteAsync(request);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<RestResponse> SaveEmployee(EmployeeSignupCredential credentials)
        {
            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();

            if (!httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            {
                return null;
            }

            using var client = new RestClient(ServerUrl.EmployoeeUrl);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var claim = httpContextAccessor.HttpContext.User.Claims.First(c => c.Type == "Bearer");
            request.AddHeader("Authorization", claim.Value);
            var body = JsonSerializer.Serialize(credentials);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            return await client.ExecuteAsync(request);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<AccountDetails> Authenticate(LoginCredential credentials)
        {
            using var client = new RestClient(ServerUrl.AccountUrl);
            var request = new RestRequest("authenticate", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonSerializer.Serialize(credentials);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode && response.Content != null)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                return JsonSerializer.Deserialize<AccountDetails>(response.Content, options);
            }
            else
            {
                //this could have wrapper exception class in case we wanted some special logic in there
                throw new Exception(UIErrorMessages.IncorrectCredentials);
            }
        }

        public Task Delete(SignupCredential entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAll(IEnumerable<SignupCredential> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IEnumerable<SignupCredential>> FindAll()
        {
            using var client = new RestClient(ServerUrl.AccountUrl);
            var request = new RestRequest("", Method.Get);
            HttpContextAccessor httpContextAccessor = new();
            var claim = httpContextAccessor.HttpContext.User.Claims.First(c => c.Type == "Bearer");
            request.AddHeader("Authorization", claim.Value);

            var response = await client.ExecuteAsync(request);

            //check on backend if array has any objs otherwise send notfound
            if (response.IsSuccessStatusCode && response.Content != null)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                return JsonSerializer.Deserialize<IEnumerable<SignupCredential>>(response.Content, options) ??
                    Array.Empty<SignupCredential>();
            }
            return Array.Empty<SignupCredential>();
        }

        public Task<IEnumerable<SignupCredential>> FindAllById(IEnumerable<int> Ids)
        {
            throw new NotImplementedException();
        }

        public async Task<SignupCredential> FindById(int id)
        {
            using var client = new RestClient(ServerUrl.AccountUrl + "/" + id);
            var request = new RestRequest("", Method.Get);
            HttpContextAccessor httpContextAccessor = new();
            var claim = httpContextAccessor.HttpContext.User.Claims.First(c => c.Type == "Bearer");
            request.AddHeader("Authorization", claim.Value);

            var response = await client.ExecuteAsync(request);

            //todo finish

            throw new NotImplementedException();
        }

        public Task<int> SaveAll(IEnumerable<SignupCredential> entities)
        {
            throw new NotImplementedException();
        }
    }
}
