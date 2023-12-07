﻿using StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        // Student Signatures

        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(Guid studentId);
        Task<Student> UpdateStudentAsync(Guid studentId, Student std);

        Task<bool> isStudentExsists(Guid studentId);

        Task<Student> DeleteStudentAsync(Guid studentId);




        //Gender Signatures
        Task<List<Gender>> GetGendersAsync();

    }
}
