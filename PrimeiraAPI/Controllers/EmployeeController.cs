﻿using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Interfaces;
using PrimeiraAPI.Model;
using PrimeiraAPI.ViewModel;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }
        [HttpPost]
        public IActionResult Add([FromForm] EmployeeViewModel employeeView)
        {
            var filePath = Path.Combine("Storage", employeeView.Photo.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);
            var employee = new Employee(employeeView.name, employeeView.age, filePath);
            _employeeRepository.Add(employee);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get() { 
            var employees= _employeeRepository.Get();
            return Ok(employees);
        }
        [HttpPost]
        [Route("{id}/download")]
        public async Task<IActionResult> DownloadPhoto(int id) {
            
            var employee = _employeeRepository.Get(id);
            var dataBytes = await System.IO.File.ReadAllBytesAsync(employee.Result.Photo);
            return File(dataBytes, "image/jpg");
        }
    }
}
