using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;
using System;
using System.IO;
using XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Abstract;

namespace XamarinDDDTemplate.WinPhone.IoCImplementations
{
    public class SQLiteConnectionProvider : BaseSQLiteConnectionProvider
    {
        public override string GetDatabaseFilePath()
        {
            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            const string libraryFolderName = "Library";
            var libraryPath = Path.Combine(documentsFolder, "..", libraryFolderName);
            return Path.Combine(libraryPath, DB_NAME);
        }

        public override ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformIOS();
        }
    }
}