using XamarinDDDTemplate.Infrastructure.DbAccess.Connection.Interfaces;
using XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork.Interfaces;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly ISQLiteConnectionFactory _sqLiteConnectionFactory;

        public UnitOfWorkFactory(ISQLiteConnectionFactory sqLiteConnectionFactory)
        {
            _sqLiteConnectionFactory = sqLiteConnectionFactory;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(_sqLiteConnectionFactory.GetConnection());
        }
    }
}
