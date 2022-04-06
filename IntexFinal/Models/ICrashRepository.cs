﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public interface ICrashRepository
    {
        IQueryable<crash_data> Crash_Data { get; }
        //IQueryable<crash_severity> Crash_Severity { get; }
        void SaveCrashData(crash_data cd);
        void CreateCrashData(crash_data cd);
        void DeleteCrashData(crash_data cd);
        IQueryable<crash_data> GetFiltered(string city, string county_name, DateTime crash_datetime, int route, double milepoint, string main_road_name, double lat_utm_y, double long_utm_x, int crash_severity_id, bool work_zone_related, bool pedestrian_involved, bool bicyclist_involved, bool motorcycle_involved, bool improper_restraint,
            bool unrestrained, bool dui, bool intersection_related, bool wild_animal_related, bool domestic_animal_related, bool overturn_rollover, bool commercial_motor_veh_involved,
            bool teenage_driver_involved, bool older_driver_involved, bool night_dark_condition, bool single_vehicle, bool distracted_driving, bool drowsy_driving, bool roadway_departure);
    }
}
