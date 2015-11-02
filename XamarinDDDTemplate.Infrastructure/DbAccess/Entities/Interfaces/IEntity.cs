using System.Collections.Generic;
using System.Reflection;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Entities.Base
{
    public interface IEntity
    {
        int Id { get; set; }
        string GetTableName();

        
        IEnumerable<PropertyInfo> GetPrimaryKeys();
    }
}
