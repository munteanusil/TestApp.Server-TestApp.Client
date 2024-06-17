using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IDataAccess dataAccess;

    public ProductRepository(IDataAccess dataAccess)
    {
        this.dataAccess = dataAccess;
    }
    public async Task<DataAccessReponse<ProductDto>> GetByIdAsync(int id)
    {
        return await dataAccess.SelectAsync<ProductDto>("SELECT * FROM Products WHERE id = @id", new { id });
    }

    public DataAccessReponse<ProductDto> Insert(ProductDto data)
    {
        throw new NotImplementedException();
    }
}
