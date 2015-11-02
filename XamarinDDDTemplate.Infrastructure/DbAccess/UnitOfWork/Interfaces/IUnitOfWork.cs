using System;
using SQLite.Net;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        SQLiteConnection Connection { get; }
        void Commit();
        void Rollback();
    }
}
