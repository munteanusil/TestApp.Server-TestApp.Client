using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories.Common;

public interface IDeleteByIdRepositoryAction
{
    DataAccessReponse DeleteById(int id);
}
