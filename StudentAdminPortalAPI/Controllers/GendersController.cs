using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Models;
using StudentAdminPortalAPI.Repositories.Interfaces;

namespace StudentAdminPortalAPI.Controllers
{
    public class GendersController : BaseApiController
    {
        private readonly IStudentRepository ManageStudents;
        private readonly IMapper _mapper;

        public GendersController(IStudentRepository manageStudents, IMapper mapper)
        {
            ManageStudents = manageStudents;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("[controller]")]
        // controller/action -- gender/GetAllGenders
        public async Task<IActionResult> GetAllGenders()
        {
            List<Gender> genders = await ManageStudents.GetGendersAsync();

            if (genders == null || !genders.Any())
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<GenderDTO>>(genders));

        }
    }

}

