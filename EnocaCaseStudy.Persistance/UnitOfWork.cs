using EnocaCaseStudy.Domain;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly EnocaCaseStudyContext _context;

    public UnitOfWork(EnocaCaseStudyContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
