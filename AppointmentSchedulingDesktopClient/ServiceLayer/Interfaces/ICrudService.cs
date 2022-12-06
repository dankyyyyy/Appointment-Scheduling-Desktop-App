using RestSharp;

namespace AppointmentSchedulerUI.Repositories.Interfaces
{
    public interface ICrudService<CREATE, READ, DELETE, ID>
    {
        public Task<RestResponse> Save(CREATE entity);
        public Task<int> SaveAll(IEnumerable<CREATE> entities);
        public Task<READ> FindById(ID id);
        public Task<bool> ExistsById(ID id);
        public Task<IEnumerable<READ>> FindAll();
        public Task<IEnumerable<READ>> FindAllById(IEnumerable<ID> Ids);
        public Task DeleteById(ID id);
        public Task Delete(DELETE entity);
        public Task DeleteAll(IEnumerable<DELETE> entities);
    }
}
