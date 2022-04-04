﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public class crash_data
    {
        [Key]
        [Required]
        public int crash_ID { get; set; }
        public DateTime crash_datetime { get; set; }
        public int route { get; set; }
        public double lat_utm_y { get; set; }
        public double long_utm_x { get; set; }
        public string city { get; set; }
        public string country_name { get; set; }
        public int crash_severity_id { get; set; }
        public crash_severity crash_severity { get; set; }
        public bool work_zone_related { get; set; }
        public bool pedestrian_involved { get; set; }
        public bool bicyclist_involved { get; set; }
        public bool motorcycle_involved { get; set; }
        public bool improper_restraint { get; set; }
        public bool unrestrained { get; set; }
        public bool dui { get; set; }
        public bool intersection_related { get; set; }
        public bool wild_animal_related { get; set; }
        public bool domestic_animal_related { get; set; }
        public bool overturn_rollover { get; set; }
        public bool commercial_motor_veh_involved { get; set; }
        public bool teenage_driver_involved { get; set; }
        public bool older_driver_involved { get; set; }
        public bool night_dark_condition { get; set; }
        public bool single_vehicle { get; set; }
        public bool distracted_driving { get; set; }
        public bool drowsy_driving { get; set; }
        public bool roadway_departure { get; set; }
    }
}
