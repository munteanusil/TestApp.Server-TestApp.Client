using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain;

public interface INoteDomainService
{
    ErrorOr<string> SaveNote(string text);
}
