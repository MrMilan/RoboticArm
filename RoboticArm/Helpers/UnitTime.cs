using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms.Helpers
{
    class UnitTime
    {
        private string time;

        public enum ETimeUnits { milisec, sec, min }

        public double GetTimeValue(ETimeUnits unit)
        {
            switch (unit)
            {
                case ETimeUnits.milisec:
                    return 0.001;
                case ETimeUnits.sec:
                    return 1;
                case ETimeUnits.min:
                    return 60;
                default:
                    throw new NotSupportedException("Not supported enum value");
            }

        }

        public string GetTime
        {
            get
            { return this.time; }
        } 
    }
}
