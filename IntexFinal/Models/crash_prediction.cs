using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public class crash_prediction
    {

        public float milepoint { get; set; }
        public float lat_utm_y { get; set; }
        public float long_utm_x { get; set; }
        public float route_2172 { get; set; }
        public float route_15 { get; set; }
        public float route_154 { get; set; }
        public float route_171 { get; set; }
        public float route_173 { get; set; }
        public float route_201 { get; set; }
        public float route_209 { get; set; }
        public float route_215 { get; set; }
        public float route_40 { get; set; }
        public float route_68 { get; set; }
        public float route_71 { get; set; }
        public float route_80 { get; set; }
        public float route_89 { get; set; }
        public float route_91 { get; set; }
        public float route_Other { get; set; }
        public float city_LAYTON { get; set; }
        public float city_LEHI { get; set; }
        public float city_OGDEN { get; set; }
        public float city_OUTSIDE_CITY_LIMITS { get; set; }
        public float city_Other { get; set; }
        public float city_PROVO { get; set; }
        public float city_SALT_LAKE_CITY { get; set; }
        public float city_SANDY { get; set; }
        public float city_SOUTH_SALT_LAKE { get; set; }
        public float city_ST_GEORGE { get; set; }
        public float city_TAYLORSVILLE { get; set; }
        public float city_WEST_JORDAN { get; set; }
        public float city_WEST_VALLEY_CITY { get; set; }
        public float county_name_CACHE { get; set; }
        public float county_name_CARBON { get; set; }
        public float county_name_DAVIS { get; set; }
        public float county_name_IRON { get; set; }
        public float county_name_MILLARD { get; set; }
        public float county_name_Other { get; set; }
        public float county_name_SALT_LAKE { get; set; }
        public float county_name_SANPETE { get; set; }
        public float county_name_SUMMIT { get; set; }
        public float county_name_UINTAH { get; set; }
        public float county_name_WASHINGTON { get; set; }
        public float county_name_WEBER { get; set; }
        public float work_zone_related_True { get; set; }
        public float pedestrian_involved_True { get; set; }
        public float bicyclist_involved_True { get; set; }
        public float motorcycle_involved_True { get; set; }
        public float improper_restraint_True { get; set; }
        public float unrestrained_True { get; set; }
        public float dui_True { get; set; }
        public float intersection_related_True { get; set; }
        public float wild_animal_related_True { get; set; }
        public float overturn_rollover_True { get; set; }
        public float commercial_motor_veh_involved_True { get; set; }
        public float teenage_driver_involved_True { get; set; }
        public float older_driver_involved_True { get; set; }
        public float single_vehicle_True { get; set; }
        public float distracted_driving_True { get; set; }
        public float drowsy_driving_True { get; set; }
        public float roadway_departure_True { get; set; }
        public float day_name_Saturday { get; set; }
        public float day_name_Sunday { get; set; }


        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
            milepoint, lat_utm_y, long_utm_x, route_15, route_154,
       route_171, route_173, route_201, route_209, route_215,
       route_2172, route_40, route_68, route_71, route_80,
       route_89, route_91, route_Other, city_LAYTON, city_LEHI,
       city_OGDEN, city_OUTSIDE_CITY_LIMITS, city_Other, city_PROVO,
       city_SALT_LAKE_CITY, city_SANDY, city_SOUTH_SALT_LAKE,
       city_ST_GEORGE, city_TAYLORSVILLE, city_WEST_JORDAN,
       city_WEST_VALLEY_CITY, county_name_CACHE, county_name_CARBON,
       county_name_DAVIS, county_name_IRON, county_name_MILLARD,
       county_name_Other, county_name_SALT_LAKE, county_name_SANPETE,
       county_name_SUMMIT, county_name_UINTAH, county_name_WASHINGTON,
       county_name_WEBER, work_zone_related_True,
       pedestrian_involved_True, bicyclist_involved_True,
       motorcycle_involved_True, improper_restraint_True,
       unrestrained_True, dui_True, intersection_related_True,
       wild_animal_related_True, overturn_rollover_True,
       commercial_motor_veh_involved_True, teenage_driver_involved_True,
       older_driver_involved_True, single_vehicle_True,
       distracted_driving_True,drowsy_driving_True,
       roadway_departure_True, day_name_Saturday, day_name_Sunday
            };
            int[] dimensions = new int[] { 1, 62 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}

