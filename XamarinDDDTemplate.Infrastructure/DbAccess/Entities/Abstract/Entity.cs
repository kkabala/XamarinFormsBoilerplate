using XamarinDDDTemplate.Infrastructure.DbAccess.Entities.Interfaces;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Entities.Abstract
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
}