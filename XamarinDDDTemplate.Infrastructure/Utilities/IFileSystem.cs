using System.IO;
using XamarinDDDTemplate.Infrastructure.Enums;

namespace XamarinDDDTemplate.Infrastructure.Utilities
{
    public interface IFileSystem
    {
        bool FileExists(string filePath);

        Stream GetFile(string filePath, FileMode fileMode, AccessType accessType);

        Stream GetResourceFile(string filePath);

        Stream CreateFile(string filePath);

        void SaveFile(string filePath, byte[] fileContent);

        void CreateDirectory(string directoryPath);

        bool DirectoryExists(string directoryPath);

        void CopyFile(string sourcePath, string destinationPath, bool overwrite = false);

        void DeleteFile(string filePath);
    }
}