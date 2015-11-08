using SQLite.Net;
using XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork.Interfaces;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(SQLiteConnection connection)
        {
            Connection = connection;
            BeginTransaction();
        }

        public SQLiteConnection Connection { get; }

        public void Dispose()
        {
            Connection.Dispose();
        }

        public void Commit()
        {
            Connection.Commit();
        }

        public void Rollback()
        {
            Connection.Rollback();
        }

        private void BeginTransaction()
        {
            Connection.BeginTransaction();
        }
    }
}