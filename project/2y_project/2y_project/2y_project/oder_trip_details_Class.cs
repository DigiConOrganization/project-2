using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbuilds
{
    class oder_trip_details_Class
    {
        private int oder_trip_ID;
        private int customer_ID;
        private int oder_ID;
        private int emp_ID;
        private string oder_trip_request_date;
        private string oder_trip_location_start;
        private string oder_trip_location_end;
        private double oder_trip_distance;

        public oder_trip_details_Class(int oder_trip_ID, int customer_ID, int oder_ID, int emp_ID, string oder_trip_request_date, string oder_trip_location_start, string oder_trip_location_end, double oder_trip_distance)
        {
            this.Oder_trip_ID = oder_trip_ID;
            this.Customer_ID = customer_ID;
            this.Oder_ID = oder_ID;
            this.Emp_ID = emp_ID;
            this.Oder_trip_request_date = oder_trip_request_date;
            this.Oder_trip_location_start = oder_trip_location_start;
            this.Oder_trip_location_end = oder_trip_location_end;
            this.Oder_trip_distance = oder_trip_distance;
        }

        public int Oder_trip_ID { get => oder_trip_ID; set => oder_trip_ID = value; }
        public int Customer_ID { get => customer_ID; set => customer_ID = value; }
        public int Oder_ID { get => oder_ID; set => oder_ID = value; }
        public int Emp_ID { get => emp_ID; set => emp_ID = value; }
        public string Oder_trip_request_date { get => oder_trip_request_date; set => oder_trip_request_date = value; }
        public string Oder_trip_location_start { get => oder_trip_location_start; set => oder_trip_location_start = value; }
        public string Oder_trip_location_end { get => oder_trip_location_end; set => oder_trip_location_end = value; }
        public double Oder_trip_distance { get => oder_trip_distance; set => oder_trip_distance = value; }
    }
}
