using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classbuilds
{
    class truck_Class
    {
        private int truck_ID;
        private string truck_make;
        private string truck_model;
        private DateTime truck_date_of_acquisition; // Fancy words my dude. had to google it.
        private string truck_regestration;
        private string truck_VIN;
        private int truck_odometer; // we could have just said truck_mileage
        private double truck_operation_cost;
        private string service_status; // so we are ignoring naming conventions just for this one hey? :)
        private int fuel_type_ID;
        private string truck_size;

        public truck_Class(int truck_ID, string truck_make, string truck_model, DateTime truck_date_of_acquisition, string truck_regestration, string truck_VIN, int truck_odometer, double truck_operation_cost, string service_status, int fuel_type_ID, string truck_size)
        {
            this.Truck_ID = truck_ID;
            this.Truck_make = truck_make;
            this.Truck_model = truck_model;
            this.Truck_date_of_acquisition = truck_date_of_acquisition;
            this.Truck_regestration = truck_regestration;
            this.Truck_VIN = truck_VIN;
            this.Truck_odometer = truck_odometer;
            this.Truck_operation_cost = truck_operation_cost;
            this.Service_status = service_status;
            this.Fuel_type_ID = fuel_type_ID;
            this.Truck_size = truck_size;
        }

        public int Truck_ID { get => truck_ID; set => truck_ID = value; }
        public string Truck_make { get => truck_make; set => truck_make = value; }
        public string Truck_model { get => truck_model; set => truck_model = value; }
        public DateTime Truck_date_of_acquisition { get => truck_date_of_acquisition; set => truck_date_of_acquisition = value; }
        public string Truck_regestration { get => truck_regestration; set => truck_regestration = value; }
        public string Truck_VIN { get => truck_VIN; set => truck_VIN = value; }
        public int Truck_odometer { get => truck_odometer; set => truck_odometer = value; }
        public double Truck_operation_cost { get => truck_operation_cost; set => truck_operation_cost = value; }
        public string Service_status { get => service_status; set => service_status = value; }
        public int Fuel_type_ID { get => fuel_type_ID; set => fuel_type_ID = value; }
        public string Truck_size { get => truck_size; set => truck_size = value; }
    }   
}
