using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;
using TestApp.DataAccess.Repositories.Common;

namespace TestApp.DataAccess.Repositories;

public interface INoteRepository : IRepository<NoteDto>
{
    void Add(NoteDto dto);
    NoteDto? Get(int id);
    Task<DataAccessReponse<NoteDto>> GetAllAsync();
    void Remove(int id);
}