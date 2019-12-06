using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_Repository_Pattern.DAL.ORM.Entity;
using Example_Repository_Pattern.DAL.ORM.Entity.Abstract;
using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using Example_Repository_Pattern.DAL.ORM.Context;
using System.Data.Entity;
using System;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;

namespace Example_Repository_Pattern.BLL.Repository
{
  public  class BaseRepository<T> where T:BaseEntity
    {
        private ProjectContext db;
        protected DbSet<T> table;

        public BaseRepository()
        {
            db = new ProjectContext();
            table = db.Set<T>();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public void Add(T item)
        {
            table.Add(item);
            Save();
        }

        public void Add(List<T> items)
        {
            table.AddRange(items);
            Save();
        }
        public int Save()
        {
            return db.SaveChanges();
        }

        public List<T>GetActive()
        {
            return table.Where(x => x.Status == Status.Active).ToList();
        }
        public T GetByID(Guid id)
        {
            return table.Find(id);
        }
       public T GetByDefualt(Expression <Func<T,bool>>exp)
        {
            return table.Where(exp).FirstOrDefault();
        }
        public List<T> GetDefualt(Expression<Func<T,bool>>exp)
        {
            return table.Where(exp).ToList();
        }

        public void Remove (Guid id)
        {
            T item = GetByID(id);
            item.Status = Status.Passive;
            Update(item);
        }

        public void RemoveAll(Expression<Func<T,bool>>exp)
        {
            foreach (var item in GetDefualt(exp))
            {
                item.Status = Status.Passive;
                Update(item);
            }
        }
        public void Update (T item)
        {
            T updated = GetByID(item.ID);
            DbEntityEntry entry=db.Entry(updated);
            entry.CurrentValues.SetValues(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp) => table.Any(exp);
    }
}
