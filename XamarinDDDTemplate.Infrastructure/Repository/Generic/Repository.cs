using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using XamarinDDDTemplate.Infrastructure.DbAccess.Repositories.Interfaces;
using XamarinDDDTemplate.Infrastructure.DbAccess.UnitOfWork.Interfaces;
using XamarinDDDTemplate.Infrastructure.DbAccess.Utilities;

namespace XamarinDDDTemplate.Infrastructure.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        protected readonly SQLiteConnection Connection;

        public Repository(IUnitOfWork unitOfWork)
        {
            Connection = unitOfWork.Connection;
        }

        public int Count()
        {
            string query = $"SELECT COUNT(*) AS Count FROM '{TableInfoExtractor.GetTableName(typeof(T))}'";
            var result = Connection.Query<TableCountMap>(query);
            var firstItem = result.First();
            return firstItem.NumberOfItems;
        }

        public IEnumerable<T> GetAll()
        {
            return Connection.Table<T>().AsEnumerable();
        }

        public int Insert(T item)
        {
            return Connection.Insert(item);
        }

        public T GetById(string idValue)
        {
            var query =
                $"SELECT * FROM {TableInfoExtractor.GetTableName(typeof(T))} " +
                $"WHERE {TableInfoExtractor.GetFirstPrimaryKeyTableName(typeof(T))} = '{idValue}'";

            return Connection.Query<T>(query).Single();
        }

        public void InsertOrReplace(T item)
        {
            Connection.InsertOrReplace(item);
        }

        public void Delete(T item)
        {
            Connection.Delete(item);
        }

        public void InsertAll(IEnumerable<T> items)
        {
            Connection.InsertAll(items);
        }

        public void InsertOrReplaceAll(IEnumerable<T> items)
        {
            Connection.InsertOrReplaceAll(items);
        }

        public void ClearTable()
        {
            var query = $"DELETE FROM {TableInfoExtractor.GetTableName(typeof(T))}";
            Connection.Execute(query);
        }

        public void Update(T item)
        {
            Connection.Update(item);
        }

        public void UpdateAll(IEnumerable<T> items)
        {
            Connection.UpdateAll(items);
        }

        internal class TableCountMap
        {
            public int NumberOfItems { get; set; }
        }
    }
}