using System.Net.Mime;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace StarFitApi.Services.FileServices;

public class FileService : IFileService
{
    // Add a document
    public async Task<string> AddDocument(IFormFile file)
    {
        file = ReduceImageWeight(file);
        var uniqueFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "files" , uniqueFileName);

        Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

        var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);
        
        return Path.Combine("files", uniqueFileName);
    }
    
    // Update a document
    public async Task<string> UpdateDocument(IFormFile file, string previous)
    {
        DeleteDocument(previous);
        return await AddDocument(file);
    }
    
    // Delete a document
    public string DeleteDocument(string previous)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), previous);
        File.Delete(path);
        if (Directory.GetFiles(Path.GetDirectoryName(path)!).Length == 0)
        {
            Directory.Delete(Path.GetDirectoryName(path)!);
        }
        
        return previous;
    }

    public string GetDocumentByLink(string fileName)
    {
        return Path.Combine("files", fileName);
    }
    
    private IFormFile ReduceImageWeight(IFormFile file)
    {
        using var image = SixLabors.ImageSharp.Image.Load(file.OpenReadStream());
        var height = (int) (100 * image.Height / (double) image.Width);
        image.Mutate(x => x.Resize(100, height));
        var memoryStream = new MemoryStream();
        image.Save(memoryStream, new PngEncoder());
        memoryStream.Position = 0;
        return new FormFile(memoryStream, 0, memoryStream.Length, file.Name, file.FileName.Split('.').First() + ".png");
    }
}