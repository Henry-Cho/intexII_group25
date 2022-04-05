using System;
using System.Linq;

namespace IntexFinal.Models.ViewModels
{
    public class IncidentsViewModel
    {
        public IQueryable<crash_data> Incidents { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
