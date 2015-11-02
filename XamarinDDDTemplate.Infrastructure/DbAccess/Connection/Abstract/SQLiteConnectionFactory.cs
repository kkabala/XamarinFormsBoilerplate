using SQLite.Net;
using XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Interfaces;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Abstract
{
    public class SQLiteConnectionFactory : ISQLiteConnectionFactory
    {
        private readonly ISQLiteConnectionProvider sqliteConnectionProvider;

        public SQLiteConnectionFactory(ISQLiteConnectionProvider sqliteConnectionProvider)
        {
            this.sqliteConnectionProvider = sqliteConnectionProvider;
        }

        public SQLiteConnection GetConnection()
        {
            string dbPath = sqliteConnectionProvider.GetDatabaseFilePath();
            SQLiteConnection connection = new SQLiteConnection(sqliteConnectionProvider.GetPlatform(), dbPath);
            return connection;
        }
    }
}