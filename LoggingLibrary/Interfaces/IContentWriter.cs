using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLibrary.Interfaces
{
    public interface IContentWriter
    {
        Task<bool> Write(string content);
    }
}
