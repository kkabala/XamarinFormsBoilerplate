using SQLite.Net;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Interfaces
{
    public interface ISQLiteConnectionFactory
    {
        SQLiteConnection GetConnection();
    }
}
