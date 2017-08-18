
using System;

namespace JournalAdapter.Adapter
{
    abstract class Journal
    {
        public abstract void Log(string text);

        public abstract string Read(DateTime startDate, DateTime endDate);

        public abstract string Read(DateTime startDate);

        public abstract string Read();
    }
}
