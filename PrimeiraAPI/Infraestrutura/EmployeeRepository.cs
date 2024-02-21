using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Interfaces;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public async Task Add(Employee employe)
        {
            await _context.Employees.AddAsync(employe);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> Get()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
