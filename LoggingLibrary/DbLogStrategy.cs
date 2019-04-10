using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class DbLogStrategy : LogStrategy
    {
        BaseContentWriter wt = new DbContentWriter();
        protected override bool DoLog(String logitem)
        {
            wt.Write(logitem);
            return true;
        }
    }
}
