using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess;

public interface IDataAccess
{
    Task<DataAccessReponse> InsertAsync(string query, dynamic data);
    Task<DataAccessReponse<TDto>> SelectAsync<TDto>(string query, dynamic? data = null) where TDto : IStorageDto;
    Task<DataAccessReponse> UpdateAsync(string query, dynamic? data = null);
    Task<DataAccessReponse> DeleteAsync(string query, dynamic? data = null);
}