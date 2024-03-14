using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using StarFitApi.Services.FileServices;

namespace StarFitApi.Controllers.V1;

[ApiController]
[Route("files")]
public class FilesController : ControllerBase
{
    #region Fields

    private readonly IFileService _fileService;

    #endregion

    #region Constructor

    public FilesController(IFileService fileService)
    {
        _fileService = fileService;
    }

    #endregion

    #region Methods

    [HttpGet]
    public IActionResult GetDocumentFile(string fileName)
    {
        var filePath = _fileService.GetDocumentByLink(fileName);
        var fullPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

        var contentDisposition = new ContentDisposition
        {
            Inline = true,
            FileName = fileName
        };
        Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
        HttpContext.Response.Headers["Title"] = fileName;
        var contentType = _fileService.GetContentType(fileName);
        return PhysicalFile(fullPath, contentType);
    }

    #endregion
}