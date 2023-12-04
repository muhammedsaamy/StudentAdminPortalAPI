using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Models;
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

        [HttpGet]
        [Route("[controller]/{studentId:guid}"), ActionName("GetStudentAsync")]
        public async Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
        {
            var student = await ManageStudents.GetStudentByIdAsync(studentId);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<StudentDTO>(student));
        }

        [HttpPut]
        [Route("[controller]/{studentId:guid}")]

        public async Task<IActionResult> UpdateStudentAsync([FromRoute] Guid studentId, [FromBody] UpdateStudentDTO updateStudentRequest)
        {

            if (await ManageStudents.isStudentExsists(studentId))
            {
                var updateStudent = await ManageStudents.UpdateStudentAsync(studentId, _mapper.Map<Student>(updateStudentRequest));

                if (updateStudent != null)
                {
                    return Ok(_mapper.Map<Student>(updateStudent));
                }
            }
            return NotFound();

        }


    }
}
