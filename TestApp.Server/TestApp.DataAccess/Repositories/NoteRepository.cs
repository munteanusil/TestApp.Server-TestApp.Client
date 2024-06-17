using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess.Repositories;

public class NoteRepository : INoteRepository
{
    private readonly IDataAccess dataAccess;

    public NoteRepository(IDataAccess dataAccess)
    {
        this.dataAccess = dataAccess;
    }

    public void Add(NoteDto dto)
    {
        dataAccess.InsertAsync($"INSERT INTO Notes (Title, Text) VALUES (@title, @text);", 
            new { name = dto.Title, surname = dto.Text });
    }

    public NoteDto Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<DataAccessReponse<NoteDto>> GetAllAsync()
    {
        return await dataAccess.SelectAsync<NoteDto>("SELECT id, title, text FROM Notes;");
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }
}
