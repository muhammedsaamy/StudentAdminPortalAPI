using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Repositories.Interfaces;

namespace StudentAdminPortalAPI.Controllers
{
    public class StudentsController : BaseApiController
    {
        private readonly IStudentRepository ManageStudents;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepository manageStudents, IMapper mapper)
        {
            ManageStudents = manageStudents;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await ManageStudents.GetAllStudentsAsync();

            return Ok(_mapper.Map<List<StudentDTO>>(students));
        }




    }
}
