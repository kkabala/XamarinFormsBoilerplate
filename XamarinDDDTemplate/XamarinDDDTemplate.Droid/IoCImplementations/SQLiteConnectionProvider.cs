using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using System;
using System.IO;
using XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Abstract;

namespace XamarinDDDTemplate.Droid.IoCImplementations
{
    public class SQLiteConnectionProvider : BaseSQLiteConnectionProvider
    {
        public override string GetDatabaseFilePath()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DB_NAME);
            return dbPath;
        }

        public override ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformAndroid();
        }
    }
}