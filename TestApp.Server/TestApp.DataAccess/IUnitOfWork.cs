namespace TestApp.DataAccess;

public interface IUnitOfWork
{
    TRepository GetRepository<TRepository>();
}