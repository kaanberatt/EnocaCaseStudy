using EnocaCaseStudy.Domain.Utilities;
using Microsoft.EntityFrameworkCore;

namespace EnocaCaseStudy.Domain.Repositories;
public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Entity { get; set; }
}
