using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DataAccess.Dto;

public class ProductDto : IStorageDto
{
    public int Id { get; set; }
    public string? Nume { get; set; }
    public string? NumarArticol { get; set; }
}
