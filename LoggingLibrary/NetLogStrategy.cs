using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class NetLogStrategy : LogStrategy
    {
        BaseContentWriter nc = new NetworkContentWriter();
        protected override bool DoLog(string logitem)
        {
            nc.Write(logitem);
            return true;
        }
    }
}
