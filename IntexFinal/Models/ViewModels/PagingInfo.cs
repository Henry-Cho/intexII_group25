﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models.ViewModels
{
    public class PagingInfo
    {
        //used to set up Paging in Blazor
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems /
                    ItemsPerPage);
            }
        }

    }
}
