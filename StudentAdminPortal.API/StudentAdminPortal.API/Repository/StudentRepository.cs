using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public StudentAdminContext _context { get; }
        public StudentRepository(StudentAdminContext context)
        {
            _context = context;
        }

     

        public async Task<List<Student>> GetStudentAsync()
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
