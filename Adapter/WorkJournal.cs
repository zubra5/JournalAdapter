
using System;
using System.Collections.Generic;
using System.Linq;


namespace JournalAdapter.Adapter
{
    class WorkJournal : Journal
    {
        List<Record> records = new List<Record>();  
        public override void Log(string text)
        {
            records.Add(new Record() { When=DateTime.Now, What=text});
        }

        public override string Read(DateTime startDate, DateTime endDate)
        {
            List<string> onlyStrings=records
                                    .Where(x => x.When >= startDate && x.When <= endDate)
                                    .Select(x=>x.What)
                                    .ToList();
            
            return String.Join(Environment.NewLine, onlyStrings); 
        }

        public override string Read(DateTime startDate)
        {
            return Read( startDate, DateTime.Now);
        }

        public override string Read()
        {
            DateTime startDate = records.Min(x => x.When);
            return Read(startDate, DateTime.Now);
        }
    }
}
