namespace StarFitApi.Services.FileServices;

public interface IFileService
{
    public Task<string> AddDocument(IFormFile file);
    
    public Task<string> UpdateDocument(IFormFile file, string previous);
    public string DeleteDocument(string previous);

    public string GetDocumentByLink(string fileName);
}