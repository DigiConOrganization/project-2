using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbuilds
{
    class Fuel_Type_Class
    {
        private int fuel_type_ID;
        private string feul_type_name;
        private double fuel_type_price;
        private string price_updated_date;

        public Fuel_Type_Class(int fuel_type_ID, string feul_type_name, double fuel_type_price, string price_updated_date)
        {
            this.Fuel_type_ID = fuel_type_ID;
            this.Feul_type_name = feul_type_name;
            this.Fuel_type_price = fuel_type_price;
            this.Price_updated_date = price_updated_date;
        }

        public int Fuel_type_ID { get => fuel_type_ID; set => fuel_type_ID = value; }
        public string Feul_type_name { get => feul_type_name; set => feul_type_name = value; }
        public double Fuel_type_price { get => fuel_type_price; set => fuel_type_price = value; }
        public string Price_updated_date { get => price_updated_date; set => price_updated_date = value; }
    }
}
