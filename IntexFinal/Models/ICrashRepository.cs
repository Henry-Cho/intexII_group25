using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public interface ICrashRepository
    {
        IQueryable<crash_data> crash_data { get; }
        void SaveCrashData(crash_data cd);
        void CreateCrashData(crash_data cd);
        void DeleteCrashData(crash_data cd);
        List<crash_data> GetFiltered(string? city, string? county_name, int? route, string? main_road_name, int? crash_severity_id, bool? work_zone_related, bool? pedestrian_involved, bool? bicyclist_involved, bool? motorcycle_involved, bool? improper_restraint,
            bool? unrestrained, bool? dui, bool? intersection_related, bool? wild_animal_related, bool? domestic_animal_related, bool? overturn_rollover, bool? commercial_motor_veh_involved,
            bool? teenage_driver_involved, bool? older_driver_involved, bool? night_dark_condition, bool? single_vehicle, bool? distracted_driving, bool? drowsy_driving, bool? roadway_departure);
        
        }
}
