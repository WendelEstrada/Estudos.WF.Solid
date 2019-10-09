using Estudos.WF.Solid.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly TorneioContext _database;
        private readonly DbSet<TEntity> _table;

        public Repository(TorneioContext database)
        {
            _database = database;
            _table = _database.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll() => _table;

        public TEntity GetById(object id) => _table.Find(id);

        public TEntity Insert(TEntity entity) => _table.Add(entity);

        public void Update(TEntity entity)
        {
            _table.Attach(entity);
            _database.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            TEntity entityFound = GetById(id);
            _table.Remove(entityFound);
        }

        public int Save() => _database.SaveChanges();
    }
}
