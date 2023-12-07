using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Profiles.AfterMaps
{
    public class AddNewStudentAfterMap : IMappingAction<AddStudentDTO, Student>
    {
        public void Process(AddStudentDTO source, Student destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
            destination.Address = new Address()
            {
                Id = source.Id,
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress,
            };
        }
    }
}
