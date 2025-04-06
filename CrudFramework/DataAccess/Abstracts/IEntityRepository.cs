using System.Linq.Expressions;
using CrudFramework.Entities.Abstracts;

namespace CrudFramework.DataAccess.Abstracts;

public interface IEntityRepository<T> where T : IEntity, new()
{
    T Get(Expression<Func<T, bool>> filter);
    List<T> GetAll(Expression<Func<T, bool>> filter = null);

    public void Delete(T entity);
    void Add(T entity);
    void Update(T entity);
}