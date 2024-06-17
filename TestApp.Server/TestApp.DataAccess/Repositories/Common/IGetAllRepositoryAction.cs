using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories.Common;

public interface IGetAllRepositoryAction<TDto> where TDto : IStorageDto
{
    DataAccessReponse<TDto> GetAll();
}
