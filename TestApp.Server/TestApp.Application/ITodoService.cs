using TestApp.DataAccess.Dto;

namespace TestApp.Application;

public interface ITodoService
{
    Task<NoteDto[]?> GetDataAsync();
}
