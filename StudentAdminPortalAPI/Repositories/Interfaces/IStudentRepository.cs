using StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        // Student Signatures

        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(Guid studentId);







    }
}
