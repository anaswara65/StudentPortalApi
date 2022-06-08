using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentController(IStudentRepository studentRepository,IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var stud = await studentRepository.GetStudentAsync();
            //var domainStudents = new List<StudentDTO>();
            //foreach(var item in stud)
            //{
            //    domainStudents.Add(new StudentDTO()
            //    {
            //        Id = item.Id,
            //        FirstName = item.FirstName,
            //        LastName = item.LastName,
            //        DateOfBirth = item.DateOfBirth,
            //        Mobile = item.Mobile,
            //        Email=item.Email
            //    });
            //}
           // mapper.Map<List<Student>>(stud);
            return Ok(mapper.Map<List<Student>>(stud));
        }
    }
}
