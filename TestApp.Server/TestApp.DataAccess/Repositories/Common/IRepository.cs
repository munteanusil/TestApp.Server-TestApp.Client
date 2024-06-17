using TestApp.DataAccess.Dto;

namespace TestApp.DataAccess.Repositories.Common;

public interface IRepository<T> where T : IStorageDto
{
    
}