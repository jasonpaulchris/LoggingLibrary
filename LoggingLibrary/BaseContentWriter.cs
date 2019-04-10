using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggingLibrary.Interfaces;
using System.Collections.Concurrent;

namespace LoggingLibrary
{
    public abstract class BaseContentWriter : IContentWriter
    {
        private ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        private object _lock = new object();

        public BaseContentWriter() { }

        public abstract bool WriteToMedia(string logcontent);

        async Task Flush()
        {
            string content;
            int count = 0;
            while (queue.TryDequeue(out content) && count <= 10)
            {
                WriteToMedia(content);
                count++;
            }
        }

        public async Task<bool> Write(string content)
        {
            queue.Enqueue(content);
            if (queue.Count <= 10)
                return true;
            lock (_lock)
            {
                Task temp = Task.Run(() => Flush());
                Task.WaitAll(new Task[] { temp });
            }
            return true;
        }
    }
}
