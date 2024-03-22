using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        public static IWebHostEnvironment Environment;

        public ImageUploadController(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        [HttpPost]
        public async Task<string> Post(FileUploadApi objFile)
        {
            try
            {
                if (objFile.Files.Length > 0)
                {
                    if (!Directory.Exists(Environment.WebRootPath + "\\Upload\\"))
                        Directory.CreateDirectory(Environment.WebRootPath + "\\Upload\\");
                    using (FileStream fileStream =
                           System.IO.File.Create(Environment.WebRootPath + "\\Upload\\" + objFile.Files.FileName))
                    {
                        objFile.Files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + objFile.Files.FileName;
                    }
                }

                return "Failed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public class FileUploadApi
        {
            public IFormFile Files { get; set; }
        }
    }
}