namespace EnocaCaseStudy.Domain;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
