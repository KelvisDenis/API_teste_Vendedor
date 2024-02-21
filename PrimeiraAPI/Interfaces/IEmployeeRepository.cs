using PrimeiraAPI.Model;

namespace PrimeiraAPI.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task Add(Employee employe);
        public Task<List<Employee>> Get();
        public Task<Employee>? Get(int id);


    }
}
