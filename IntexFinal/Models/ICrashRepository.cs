using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public interface ICrashRepository
    {
        IQueryable<crash_data> Crash_Data { get; }
        IQueryable<crash_severity> Crash_Severity { get; }
        void SaveCrashData(crash_data cd);
        void CreateCrashData(crash_data cd);
        void DeleteCrashData(crash_data cd);
    }
}
