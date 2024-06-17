using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories.Common;

public interface IUpdateRepositoryAction<TDto> where TDto : IStorageDto
{
    DataAccessReponse Update(TDto dto);
}
