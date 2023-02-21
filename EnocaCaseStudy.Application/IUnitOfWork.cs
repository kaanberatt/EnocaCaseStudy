namespace EnocaCaseStudy.Application;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
