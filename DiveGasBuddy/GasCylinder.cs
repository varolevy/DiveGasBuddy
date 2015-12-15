using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveGasBuddy
{
    public class GasCylinder
    {
        //fields
        public int GasCylinderSizeLitres=0;
        public int GasCylinderMaxPressure=0;
        public int GasCylinderCurrentPressure=0;
        public int O2Percentage=0;
        public int O2FillingResult=0;
        public int O2WantedPercentage=0;
        public int Doubles = 1;
        //public int GasCylinderTotalVolume=0;
        //public int GasCylinderSizeLitres { get; set; }
        //public int GasCylinderMaxPressure { get; set; }
        //public int GasCylinderCurrenPressure { get; set; }
        //public int O2Percentage { get; set; }
        //public int O2FillingResult { get; set; }
        //public int O2WantedPercentage { get; set; }
        //public int Doubles { get; set;} 

        //no argument constructor
        public GasCylinder()
        {
        }

        //Constructor with arguments
        public GasCylinder(int size, int pressureCurrent, int pressureMax, int doubles, int o2Current, int o2Wanted)
        {
            GasCylinderSizeLitres = size;
            GasCylinderMaxPressure = pressureMax;
            GasCylinderCurrentPressure = pressureCurrent;
            Doubles = doubles;
            O2Percentage = o2Current;
            O2WantedPercentage = o2Wanted;
            GasCylinderTotalVolume = GasCylinderMaxPressure * GasCylinderSizeLitres * Doubles;
        }


        
        //methods
        public int GasCylinderTotalVolume
        {
            get { return GasCylinderTotalVolume; }
            set { GasCylinderTotalVolume = GasCylinderMaxPressure * GasCylinderSizeLitres * Doubles; }
        }


        //todo need rethingkin of this system and how to actually cal
        private int CalculateCurrentO2Amount(int pressure, int o2, int doub, int size)
        {
            int o2Amount = (pressure * doub * size * o2) / 100;
            return o2Amount;
        }

        private int CalculateNeededO2Amount(int wO2, int delta)
        {
            return 5;
        }

        public void CalculateOutputO2Percentage()
        {
            int maxVolume = GasCylinderTotalVolume;
            //calculate delta between max and current volumes

            //current volume
            int currentVolume = GasCylinderSizeLitres * GasCylinderCurrentPressure * Doubles;

            int deltaVolumes = maxVolume - currentVolume;

            //if error return 
            if (deltaVolumes <= 0)
            {
              return; 
            }

            //int result =  CalculateNeededO2Amount(int maxVolume, int deltaVolumes);

        }
         
        
         
    }
}

