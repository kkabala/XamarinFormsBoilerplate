namespace XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork.Interfaces
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
