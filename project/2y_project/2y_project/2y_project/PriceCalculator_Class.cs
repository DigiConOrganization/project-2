using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbuilds
{
    public class PriceCalculator_Class
    {
        private double dPricePerKm;
        private double dPricePerKg;
        private double dPricePerSqaureMeter;
        private double dOvernightP;
        private double dShortNoticeP;
        private double dDistance;
        private double dWeight;
        private double dHight;
        private double dWidth;
        private double dLengthe;
        private double dTruckPrice;
        private double dTotalPrice;
        private Boolean bShortNotice;
        private Boolean bOverNight;

        private PriceCalculator_Class()
        {
            dTotalPrice = (dPricePerKm * dDistance) + (dPricePerKg * dWeight) + (dPricePerSqaureMeter * dLengthe * dWidth * dHight);
            if (bShortNotice == true)
            {
                dTotalPrice = dTotalPrice + (dTotalPrice * (dShortNoticeP/100));
            }
            if (bOverNight == true)
            {
                dTotalPrice = dTotalPrice + (dTotalPrice * (dOvernightP / 100));
            }
        }
        
    }
}
