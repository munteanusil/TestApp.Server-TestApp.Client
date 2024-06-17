using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories.Common;

public interface IInsertRepositoryAction<TDto> where TDto : IStorageDto
{
    DataAccessReponse<TDto> Insert(TDto data);
}
