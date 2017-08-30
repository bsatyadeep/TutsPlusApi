using System.Collections.Generic;
using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess.Repository
{
    public interface IRepository<T> where T :EntityBase
    {
        List<T> get();
        T Get(int id);
        T Update(T obj);
        T Inset(T obj);
        int Delete(T obj);
    }
}