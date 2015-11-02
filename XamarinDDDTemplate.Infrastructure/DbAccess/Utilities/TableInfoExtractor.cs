using System;
using System.Linq;
using System.Reflection;
using SQLite.Net.Attributes;

namespace XamarinDDDTemplate.Infrastructure.DbAccess.Utilities
{
    public static class TableInfoExtractor
    {
        public static string GetTableName(Type type)
        {
            var attributes = type.GetTypeInfo().GetCustomAttributes(false);
            var columnMapping = attributes.FirstOrDefault(m => m.GetType() == typeof (TableAttribute));

            var mapsTo = (TableAttribute) columnMapping;
            return mapsTo.Name;
        }

        public static string GetFirstPrimaryKeyTableName(Type type)
        {
            var primaryKeyProperty =
                type.GetTypeInfo()
                    .DeclaredProperties.First(
                        m => m.GetCustomAttributes(false).Any(at => at.GetType() == typeof (PrimaryKeyAttribute)));

            return primaryKeyProperty.Name;
        }
    }
}
