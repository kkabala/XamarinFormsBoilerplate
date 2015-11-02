using SQLite.Net.Interop;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Interfaces
{
    public interface ISQLiteConnectionProvider
    {
        string GetDatabaseFilePath();
        ISQLitePlatform GetPlatform();
    }
}
