using Microsoft.AspNetCore.Http;

namespace FileUpload.Models
{
    public class FileUploadViewModel
    {
        public IFormFile File { get; set; }

        public long Size { get; set; }
    }
}