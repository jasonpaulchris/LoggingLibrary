using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class NullLogStrategy : LogStrategy
    {
        protected override bool DoLog(string logitem)
        {
            Console.WriteLine(logitem + "\r\n");
            return true;
        }
    }
}
