using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public abstract class LogStrategy
    {
        protected abstract bool DoLog(String logitem);
        public bool Log(String app, String key, String cause)
        {
            return DoLog(app + " " + key + " " + cause);
        }
    }
}
