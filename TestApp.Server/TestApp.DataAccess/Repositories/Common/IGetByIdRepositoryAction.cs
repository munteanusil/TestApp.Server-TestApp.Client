using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories.Common;

public interface IGetByIdRepositoryAction<TDto> where TDto : IStorageDto
{
    Task<DataAccessReponse<TDto>> GetByIdAsync(int id);
}
