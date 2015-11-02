using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SQLite.Net.Attributes;
using XamarinDDDTemplate.Infrastructure.DbAccess.Entities.Base;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Entities.Abstract
{
    public class Entity : IEntity
    {
        public int Id { get; set; }

        public string GetTableName()
        {
            var attributes = this.GetType().GetTypeInfo().GetCustomAttributes(false);
            var columnMapping = attributes.FirstOrDefault(m => m.GetType() == typeof(TableAttribute));

            var mapsTo = columnMapping as TableAttribute;
            return mapsTo.Name;
        }

        public IEnumerable<PropertyInfo> GetPrimaryKeys()
        {
            var primaryKeysProperty =
                this.GetType().GetTypeInfo()
                    .DeclaredProperties.Where(
                        m => m.GetCustomAttributes(false).Any(at => at.GetType() == typeof(PrimaryKeyAttribute)));

            return primaryKeysProperty;
        }
    }
}
