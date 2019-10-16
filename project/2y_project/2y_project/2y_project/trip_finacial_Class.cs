using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbuilds
{
    class trip_finacial_Class
    {
        private int trip_financial_ID;
        private double trip_financial_Total;
        private double truck_operation_cost;
        private int truck_ID;
        private double oder_trip_distance;
        private int emp_ID;
        private double emp_pay_cut;
        private double driver_pay_per_hour;
        private int driver_ID;

        public trip_finacial_Class(int trip_financial_ID, double trip_financial_Total, double truck_operation_cost, int truck_ID, double oder_trip_distance, int emp_ID, double emp_pay_cut, double driver_pay_per_hour, int driver_ID)
        {
            this.Trip_financial_ID = trip_financial_ID;
            this.Trip_financial_Total = trip_financial_Total;
            this.Truck_operation_cost = truck_operation_cost;
            this.Truck_ID = truck_ID;
            this.Oder_trip_distance = oder_trip_distance;
            this.Emp_ID = emp_ID;
            this.Emp_pay_cut = emp_pay_cut;
            this.Driver_pay_per_hour = driver_pay_per_hour;
            this.Driver_ID = driver_ID;
        }

        public int Trip_financial_ID { get => trip_financial_ID; set => trip_financial_ID = value; }
        public double Trip_financial_Total { get => trip_financial_Total; set => trip_financial_Total = value; }
        public double Truck_operation_cost { get => truck_operation_cost; set => truck_operation_cost = value; }
        public int Truck_ID { get => truck_ID; set => truck_ID = value; }
        public double Oder_trip_distance { get => oder_trip_distance; set => oder_trip_distance = value; }
        public int Emp_ID { get => emp_ID; set => emp_ID = value; }
        public double Emp_pay_cut { get => emp_pay_cut; set => emp_pay_cut = value; }
        public double Driver_pay_per_hour { get => driver_pay_per_hour; set => driver_pay_per_hour = value; }
        public int Driver_ID { get => driver_ID; set => driver_ID = value; }
    }
}
