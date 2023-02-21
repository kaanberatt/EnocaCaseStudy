using EnocaCaseStudy.Application.Repositories;
using EnocaCaseStudy.Domain.Utilities;
using EnocaCaseStudy.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EnocaCaseStudy.Persistance.Repositories;

public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity
{
    private readonly EnocaCaseStudyContext _context;

    public QueryRepository(EnocaCaseStudyContext context)
    {
        _context = context;
        Entity = context.Set<T>();
    }

    public DbSet<T> Entity { get ; set ; }

    public IQueryable<T> GetAll()
    {
        return Entity.AsQueryable();
    }

    public async Task<T> GetById(int id)
    {
        return await Entity.FirstOrDefaultAsync( x=>x.Id == id);
    }
  
    public async Task<T> GetFirstByExpiression(Expression<Func<T, bool>> expression)
    {
        return await Entity.FirstOrDefaultAsync(expression);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        return Entity.Where(expression);
    }
}
