using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess;
using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Repositories;
using TestApp.Domain;

namespace TestApp.Application;

public class TodoService : ITodoService
{
    private readonly INoteDomainService noteDomainService;
    INoteRepository noteRepository;

    public TodoService(IUnitOfWork unitOfWork, INoteDomainService noteDomainService)
    {
        noteRepository = unitOfWork.GetRepository<INoteRepository>();
        this.noteDomainService = noteDomainService;
    }

    public async Task<NoteDto[]?> GetDataAsync()
    {
        ErrorOr<string> result = noteDomainService.SaveNote("bla bla");
        if (result.IsError)
        {
            await Console.Out.WriteLineAsync(result.FirstError.Description);
        }
        string rezult = result.Value;

        var result2 = await noteRepository.GetAllAsync();
        return result2.Data;
    }
}
