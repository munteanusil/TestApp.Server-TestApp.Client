using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DataAccess.Dto.Common;

public class DataAccessReponse
{
    public string? Error { get; set; }
}

public class DataAccessReponse<TDto> where TDto : IStorageDto
{
    public TDto[]? Data { get; set; }
    public string? Error { get; set; }
}