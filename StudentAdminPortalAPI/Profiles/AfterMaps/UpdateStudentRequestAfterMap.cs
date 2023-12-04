using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentDTO, Student>
    {
        public void Process(UpdateStudentDTO source, Student destination, ResolutionContext context)
        {
            destination.Address = new Address
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}
