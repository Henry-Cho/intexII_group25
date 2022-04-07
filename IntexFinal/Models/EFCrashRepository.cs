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

        public IQueryable<crash_data> GetFiltered(string? city, string? county_name, DateTime crash_datetime, int route, double milepoint, string main_road_name, double lat_utm_y, double long_utm_x, int crash_severity_id, bool work_zone_related, bool pedestrian_involved, bool bicyclist_involved, bool motorcycle_involved, bool improper_restraint,
            bool unrestrained, bool dui, bool intersection_related, bool wild_animal_related, bool domestic_animal_related, bool overturn_rollover, bool commercial_motor_veh_involved,
            bool teenage_driver_involved, bool older_driver_involved, bool night_dark_condition, bool single_vehicle, bool distracted_driving, bool drowsy_driving, bool roadway_departure)
        {
                var record = _context.Crash_Data.Where(x => x.bicyclist_involved == bicyclist_involved)
                .Where(x => x.city == city || city == null)
                .Where(x => x.commercial_motor_veh_involved == commercial_motor_veh_involved)
                .Where(x => x.county_name == county_name || county_name == null)
                .Where(x => x.crash_datetime == crash_datetime || crash_datetime == null)
                .Where(x => x.crash_severity_id == crash_severity_id)
                .Where(x => x.distracted_driving == distracted_driving)
                .Where(x => x.domestic_animal_related == domestic_animal_related)
                .Where(x => x.drowsy_driving == drowsy_driving)
                .Where(x => x.dui == dui)
                .Where(x => x.improper_restraint == improper_restraint)
                .Where(x => x.intersection_related == intersection_related)
                .Where(x => x.lat_utm_y == lat_utm_y)
                .Where(x => x.long_utm_x == long_utm_x)
                .Where(x => x.main_road_name == main_road_name || main_road_name == null)
                .Where(x => x.milepoint == milepoint)
                .Where(x => x.motorcycle_involved == motorcycle_involved)
                .Where(x => x.night_dark_condition == night_dark_condition)
                .Where(x => x.older_driver_involved == older_driver_involved)
                .Where(x => x.overturn_rollover == overturn_rollover)
                .Where(x => x.pedestrian_involved == pedestrian_involved)
                .Where(x => x.roadway_departure == roadway_departure)
                .Where(x => x.route == route)
                .Where(x => x.single_vehicle == single_vehicle)
                .Where(x => x.teenage_driver_involved == teenage_driver_involved)
                .Where(x => x.unrestrained == unrestrained)
                .Where(x => x.wild_animal_related == wild_animal_related)
                .Where(x => x.work_zone_related == work_zone_related);

            return record;
        }
    }
}
