using EnocaCaseStudy.Domain.Utilities;
using System.Linq.Expressions;

namespace EnocaCaseStudy.Application.Repositories;

public interface IQueryRepository<T> : IRepository<T>  where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
    Task<T> GetFirstByExpiression(Expression<Func<T,bool>> expression);
    Task<T> GetById(int id);
}
