using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbuilds
{
    class trip_Class
    {
        private int trip_ID;
        private int order_trip_ID;
        private int truck_ID;
        private int driver_ID;
        private string truck_size;
        private int trip_hours;

        public trip_Class(int trip_ID, int order_trip_ID, int truck_ID, int driver_ID, string truck_size, int trip_hours)
        {
            this.Trip_ID = trip_ID;
            this.Order_trip_ID = order_trip_ID;
            this.Truck_ID = truck_ID;
            this.Driver_ID = driver_ID;
            this.Truck_size = truck_size;
            this.Trip_hours = trip_hours;
        }

        public int Trip_ID { get => trip_ID; set => trip_ID = value; }
        public int Order_trip_ID { get => order_trip_ID; set => order_trip_ID = value; }
        public int Truck_ID { get => truck_ID; set => truck_ID = value; }
        public int Driver_ID { get => driver_ID; set => driver_ID = value; }
        public string Truck_size { get => truck_size; set => truck_size = value; }
        public int Trip_hours { get => trip_hours; set => trip_hours = value; }
    }
}
