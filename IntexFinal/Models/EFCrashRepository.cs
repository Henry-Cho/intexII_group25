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

        //create

        public void CreateCrashData(crash_data cd)
        {
            _context.Add(cd);
            _context.SaveChanges();
        }

        //delete
        public void DeleteCrashData(crash_data cd)
        {
            _context.Remove(cd);
            _context.SaveChanges();
        }

        //edit
        public void SaveCrashData(crash_data cd)
        {
            _context.Update(cd);
            _context.SaveChanges();
        }

        //this method is for filtering/searching-- it is a HEFTY boy but works and ensures least amount of filtering work is done
        public List<crash_data> GetFiltered(string? city, string? county_name,  int? route, string? main_road_name, int? crash_severity_id, bool? work_zone_related, bool? pedestrian_involved, bool? bicyclist_involved, bool? motorcycle_involved, bool? improper_restraint,
            bool? unrestrained, bool? dui, bool? intersection_related, bool? wild_animal_related, bool? domestic_animal_related, bool? overturn_rollover, bool? commercial_motor_veh_involved,
            bool? teenage_driver_involved, bool? older_driver_involved, bool? night_dark_condition, bool? single_vehicle, bool? distracted_driving, bool? drowsy_driving, bool? roadway_departure)
        {
            IQueryable<crash_data> record = _context.Crash_Data;
            if (bicyclist_involved != null)
                record = record.Where(x => x.bicyclist_involved == bicyclist_involved);
            if (city != null)
                record = record.Where(x => x.city == city || city == null);
            if (commercial_motor_veh_involved != null)
                record = record.Where(x => x.commercial_motor_veh_involved == commercial_motor_veh_involved);
            if (county_name != null)
                record = record.Where(x => x.county_name == county_name);
            if (crash_severity_id != null)
                record = record.Where(x => x.crash_severity_id == crash_severity_id);
            if (distracted_driving != null)
                record = record.Where(x => x.distracted_driving == distracted_driving);
            if (domestic_animal_related != null)
                record = record.Where(x => x.domestic_animal_related == domestic_animal_related);
            if (drowsy_driving != null)
                record = record.Where(x => x.drowsy_driving == drowsy_driving);
            if (dui != null)
                record = record.Where(x => x.dui == dui);
            if (improper_restraint != null)
                record = record.Where(x => x.improper_restraint == improper_restraint);
            if (intersection_related != null)
                record = record.Where(x => x.intersection_related == intersection_related);
            if (main_road_name != null)
                record = record.Where(x => x.main_road_name == main_road_name);
            if (motorcycle_involved != null)
                record = record.Where(x => x.motorcycle_involved == motorcycle_involved);
            if (night_dark_condition != null)
                record = record.Where(x => x.night_dark_condition == night_dark_condition);
            if (older_driver_involved != null)
                record = record.Where(x => x.older_driver_involved == older_driver_involved);
            if (overturn_rollover != null)
                record = record.Where(x => x.overturn_rollover == overturn_rollover);
            if (pedestrian_involved != null)
                record = record.Where(x => x.pedestrian_involved == pedestrian_involved);
            if (roadway_departure != null)
                record = record.Where(x => x.roadway_departure == roadway_departure);
            if (route != null)
                record = record.Where(x => x.route == route);
            if (single_vehicle != null)
                record = record.Where(x => x.single_vehicle == single_vehicle);
            if (teenage_driver_involved != null)
                record = record.Where(x => x.teenage_driver_involved == teenage_driver_involved);
            if (unrestrained != null)
                record = record.Where(x => x.unrestrained == unrestrained);
            if (wild_animal_related != null)
                record = record.Where(x => x.wild_animal_related == wild_animal_related);
            if(work_zone_related != null)
                 record = record.Where(x => x.work_zone_related == work_zone_related);
            return record.ToList();
        }
    }
}
