using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms.Helpers
{
    class UnitLenght:Unit
    {

        public enum ELenghtUnits { mm, cm, dm, m, inch, ft }

        public double GetValue(ELenghtUnits unit)
        {
            switch (unit)
            {
                case ELenghtUnits.mm:
                    return 1;
                case ELenghtUnits.cm:
                    return 10;
                case ELenghtUnits.dm:
                    return 100;
                case ELenghtUnits.m:
                    return 1000;
                case ELenghtUnits.inch:
                    return 25.4;
                case ELenghtUnits.ft:
                    return 304.8;
                default:
                    throw new NotSupportedException("Not supported enum value");
            }

        }
    }
}
