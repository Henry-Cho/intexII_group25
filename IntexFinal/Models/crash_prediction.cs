using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public class crash_prediction
    {
        public float  pedestrian_involved { get; set; }
        public float  bicyclist_involved { get; set; }
        public float  motorcycle_involved { get; set; }
        public float  improper_restraint { get; set; }
        public float  unrestrained { get; set; }
        public float  dui { get; set; }
        public float  intersection_related { get; set; }
        public float  wild_animal_related { get; set; }
        public float  domestic_animal_related { get; set; }
        public float  overturn_rollover { get; set; }
        public float  commercial_motor_veh_involved { get; set; }
        public float  teenage_driver_involved { get; set; }
        public float  older_driver_involved { get; set; }
        public float  night_dark_condition { get; set; }
        public float  single_vehicle { get; set; }
        public float  distracted_driving { get; set; }
        public float  drowsy_driving { get; set; }
        public float  roadway_departure { get; set; }
        public float  route_89 { get; set; }
        public float  route_Other { get; set; }
        public float  milepoint_Other { get; set; }
        public float  main_road_name_Other { get; set; }
        public float  city_OUTSIDE_CITY_LIMITS { get; set; }
        public float  city_Other { get; set; }
        public float  city_SALT_LAKE_CITY { get; set; }
        public float  city_SANDY { get; set; }
        public float  city_WEST_VALLEY_CITY { get; set; }
        public float  county_name_Other { get; set; }
        public float  county_name_SALT_LAKE { get; set; }
        public float  county_name_UTAH { get; set; }
        public float  county_name_WEBER { get; set; }
        public float  work_zone_related_Other { get; set; }


        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                pedestrian_involved,
                bicyclist_involved,
                motorcycle_involved,
                improper_restraint,
                unrestrained,
                dui,
                intersection_related,
                wild_animal_related,
                domestic_animal_related,
                overturn_rollover,
                commercial_motor_veh_involved,
                teenage_driver_involved,
                older_driver_involved,
                night_dark_condition,
                single_vehicle,
                distracted_driving,
                drowsy_driving,
                roadway_departure,
                route_89,
                route_Other,
                milepoint_Other,
                main_road_name_Other,
                city_OUTSIDE_CITY_LIMITS,
                city_Other,
                city_SALT_LAKE_CITY,
                city_SANDY,
                city_WEST_VALLEY_CITY,
                county_name_Other,
                county_name_SALT_LAKE,
                county_name_UTAH,
                county_name_WEBER,
                work_zone_related_Other
            };
            int[] dimensions = new int[] { 1, 32 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}

