using System;
namespace IntexFinal.Models.ViewModels
{
    public class PageInfo
    {
        //used to set up paging in Views
        public int TotalNumIncidents { get; set; }
        public int IncidentsPerPage { get; set; }
        public int CurrentPage { get; set; }

        // figure out how many pages we need
        public int TotalPages => (int)Math.Ceiling(((double)TotalNumIncidents / IncidentsPerPage));
    }
}
