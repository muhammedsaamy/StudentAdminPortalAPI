using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Models;
using StudentAdminPortalAPI.Profiles.AfterMaps;

namespace StudentAdminPortalAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<Student, StudentDTO>().ReverseMap();

            CreateMap<Address, AddressDTO>().ReverseMap();

            CreateMap<Gender, GenderDTO>().ReverseMap();

            CreateMap<UpdateStudentDTO, Student>().AfterMap<UpdateStudentRequestAfterMap>();

            CreateMap<AddStudentDTO, Student>().AfterMap<AddNewStudentAfterMap>();


        }





    }
}
