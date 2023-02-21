using EnocaCaseStudy.Application.Repositories;
using EnocaCaseStudy.Domain.Utilities;
using EnocaCaseStudy.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace EnocaCaseStudy.Persistance.Repositories;

public class CommandRepository<T> : ICommandRepository<T> where T : BaseEntity
{
    private readonly EnocaCaseStudyContext _context;

    public CommandRepository(EnocaCaseStudyContext context)
    {
        _context = context;
        Entity = _context.Set<T>();
    }

    public DbSet<T> Entity { get; set; }

    public async Task AddAsync(T entity)
    {
        await Entity.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        Entity.Remove(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var entity = Entity.FirstOrDefault(x => x.Id == id);
        Entity.Remove(entity);
    }

    public void Update(T entity)
    {
        Entity.Update(entity);
    }
}
