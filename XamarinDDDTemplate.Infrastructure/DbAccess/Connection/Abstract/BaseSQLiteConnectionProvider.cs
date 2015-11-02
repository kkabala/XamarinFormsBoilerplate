using SQLite.Net.Interop;
using XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Interfaces;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Abstract
{
    public abstract class BaseSQLiteConnectionProvider : ISQLiteConnectionProvider
    {
        public const string DB_NAME = "app_db.sqlite";
        public abstract string GetDatabaseFilePath();
        public abstract ISQLitePlatform GetPlatform();
    }
}