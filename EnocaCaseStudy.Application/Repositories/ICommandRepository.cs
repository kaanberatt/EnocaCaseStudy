
using EnocaCaseStudy.Domain.Utilities;

namespace EnocaCaseStudy.Application.Repositories;

public interface ICommandRepository<T> : IRepository<T> where T : BaseEntity
{
    Task AddAsync(T entity);
    void Update(T entity);
    Task DeleteByIdAsync(int id);
    void Delete(T entity);
}
