using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAPI.Models;
using StudentAdminPortalAPI.Repositories.Interfaces;

namespace StudentAdminPortalAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;

        public StudentRepository(StudentAdminContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.Include(nameof(Gender))
                                     .Include(nameof(Address))
                                     .ToListAsync();
        }
    }
}
