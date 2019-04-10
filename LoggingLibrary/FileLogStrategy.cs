using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class FileLogStrategy : LogStrategy
    {
        BaseContentWriter wt = new FileContentWriter(@"log.txt");
        protected override bool DoLog(string logitem)
        {
            wt.Write(logitem);
            return true;
        }
    }
}
