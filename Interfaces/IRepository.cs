using System.Collections.ObjectModel;
using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
         List<T> GetAll();
         T GetById(int id);
         void Insert(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();

    }
}