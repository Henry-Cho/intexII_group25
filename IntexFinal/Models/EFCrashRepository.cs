using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IntexFinal.Models
{
    public class EFCrashRepository : ICrashRepository
    {
        private CrashDBContext _context { get; set; }
        public EFCrashRepository(CrashDBContext temp)
        {
            _context = temp;
        }
        public IQueryable<crash_data> Crash_Data => _context.Crash_Data;

        //public IQueryable<crash_severity> Crash_Severity => _context.Crash_Severity;

        public void CreateCrashData(crash_data cd)
        {
            _context.Add(cd);
            _context.SaveChanges();
        }

        public void DeleteCrashData(crash_data cd)
        {
            _context.Remove(cd);
            _context.SaveChanges();
        }

        public void SaveCrashData(crash_data cd)
        {
            _context.Update(cd);
            _context.SaveChanges();
        }
    }
}
