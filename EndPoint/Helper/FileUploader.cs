using System;
using System.IO;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace EndPoint.Helper
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger _logger;
        public FileUploader(IWebHostEnvironment webHostEnvironment, ILogger<FileUploader> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public string Upload(IFormFile file, string path)
        {
            if (file == null) return "";
            var directoryPath = $"{_webHostEnvironment.WebRootPath}/{path}";

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            var fileName = $"{DateTime.Now.ToFileName()}-{file.FileName}";
            var filePath = $"{directoryPath}/{fileName}";
            using var output = File.Create(filePath);
            file.CopyTo(output);
            _logger.LogError("file uploaded successfully");
            return $"/{path}/{fileName}";
        }

      
    }
}