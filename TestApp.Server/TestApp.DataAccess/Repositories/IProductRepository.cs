using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Repositories.Common;

namespace TestApp.DataAccess.Repositories;

public interface IProductRepository : IRepository<ProductDto>,
                                      IGetByIdRepositoryAction<ProductDto>,
                                      IInsertRepositoryAction<ProductDto>
{
    
}