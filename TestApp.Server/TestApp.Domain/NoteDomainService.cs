using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain;

public class NoteDomainService : INoteDomainService
{
    public ErrorOr<string> SaveNote(string text)
    {
        int varsta = 5;
        string anunt = "varsta mea este " + varsta;

        // save note        
        if (string.IsNullOrEmpty(text))
            return Error.Failure("Nota nu poate fi goala!");

        return "salvat!";
    }
}
