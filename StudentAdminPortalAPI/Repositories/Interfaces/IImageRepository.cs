namespace StudentAdminPortalAPI.Repositories.Interfaces
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file, string fileName);
    }
}
