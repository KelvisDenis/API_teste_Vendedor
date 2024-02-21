using Microsoft.AspNetCore.Http.Metadata;

namespace PrimeiraAPI.ViewModel
{
    public class EmployeeViewModel
    {
        public string name { get; set; }
        public int age { get; set; }
        public IFormFile Photo { get; set; }
    }
}
