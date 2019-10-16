using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbuilds
{
    class truck_service_Class
    {
        private int service_ID;
        private string service_discription;
        private int service_mileage;
        private int next_service_mileage;
        private int service_time;
        private DateTime service_date;
        private int truck_ID;
        
        public truck_service_Class(int service_ID, string service_discription, int service_mileage, int next_service_mileage, int service_time, DateTime service_date, int truck_ID)
        {
            this.Service_ID = service_ID;
            this.Service_discription = service_discription;
            this.Service_mileage = service_mileage;
            this.Next_service_mileage = next_service_mileage;
            this.Service_time = service_time;
            this.Service_date = service_date;
            this.Truck_ID = truck_ID;
        }

        public int Service_ID { get => service_ID; set => service_ID = value; }
        public string Service_discription { get => service_discription; set => service_discription = value; }
        public int Service_mileage { get => service_mileage; set => service_mileage = value; }
        public int Next_service_mileage { get => next_service_mileage; set => next_service_mileage = value; }
        public int Service_time { get => service_time; set => service_time = value; }
        public DateTime Service_date { get => service_date; set => service_date = value; }
        public int Truck_ID { get => truck_ID; set => truck_ID = value; }
    }
}
