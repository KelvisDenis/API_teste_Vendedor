using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraAPI.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set;}
        public string? Photo { get; set;}

        public Employee()
        {
        }

        public Employee( string name, int age, string photo)
        {
            this.Name = name;
            this.Age = age;
            this.Photo = photo;
        }
    }
}
