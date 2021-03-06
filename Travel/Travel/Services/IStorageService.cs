using Travel.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Services
{
    public interface IStorageService
    {
        string WebRoot { get; }
        string ContentRootPath { get; }
        string ImageUploadDirectory { get; }


        string GetFileExtension(string fileName);
        void CreateFolder(string path);
        void VerifyPath(string path);
        string TrimFilePath(string path);
        string GetFullPath(string path);
        string GetRandomFileName();
        Task<FileUpload> UploadFormFile(IFormFile file, string path = "");
    }
}
