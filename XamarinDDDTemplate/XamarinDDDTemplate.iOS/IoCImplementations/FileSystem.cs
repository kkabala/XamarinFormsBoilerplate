using System;
using System.IO;
using XamarinDDDTemplate.Infrastructure.Enums;
using XamarinDDDTemplate.Infrastructure.Utilities;
using FileMode = XamarinDDDTemplate.Infrastructure.Enums.FileMode;

namespace XamarinDDDTemplate.iOS.IoCImplementations
{
    public class FileSystem : IFileSystem
    {
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public Stream GetFile(string filePath, FileMode fileMode, AccessType accessType)
        {
            return File.Open(filePath,
                (System.IO.FileMode)Enum.Parse(typeof(System.IO.FileMode), fileMode.ToString()),
                (FileAccess)Enum.Parse(typeof(FileAccess), accessType.ToString()));
        }

        public Stream GetResourceFile(string filePath)
        {
            return GetFile(filePath, FileMode.Open, AccessType.Read);
        }

        public Stream CreateFile(string filePath)
        {
            return File.Create(filePath);
        }

        public void SaveFile(string filePath, byte[] fileContent)
        {
            using (var fs = File.Open(filePath, System.IO.FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(fileContent, 0, fileContent.Length);
            }
        }

        public void CopyFile(string sourcePath, string destinationPath, bool overwrite = false)
        {
            File.Copy(sourcePath, destinationPath, overwrite);
        }

        public void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        public void CreateDirectory(string directoryPath)
        {
            Directory.CreateDirectory(directoryPath);
        }

        public bool DirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }
    }
}