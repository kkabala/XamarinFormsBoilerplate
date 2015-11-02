using System;
using SQLite.Net;
using XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork.Interfaces;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public SQLiteConnection Connection { get; private set; }

        public UnitOfWork(SQLiteConnection connection)
        {
            Connection = connection;
            BeginTransaction();
        }

        public void Dispose()
        {
            //TODO:
            //Connection.Rollback();
            Connection.Dispose();
            GC.SuppressFinalize(this);
        }

        private void BeginTransaction()
        {
            Connection.BeginTransaction();
        }

        public void Commit()
        {
            Connection.Commit();
        }

        public void Rollback()
        {
            Connection.Rollback();
        }
    }
}
