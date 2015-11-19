using SQLite.Net.Interop;
using SQLite.Net.Platform.WindowsPhone8;
using System.IO;
using Windows.Storage;
using XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Abstract;

namespace XamarinDDDTemplate.WinPhone.IoCImplementations
{
    public class SQLiteConnectionProvider : BaseSQLiteConnectionProvider
    {
        public override string GetDatabaseFilePath()
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, DB_NAME);
        }

        public override ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformWP8();
        }
    }
}