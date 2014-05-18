using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms
{
    class Units
    {

        private string lenght;
        private string time;

        public enum ELenghtUnits { mm, cm, dm, m, inch, ft }
        public enum ETimeUnits { milisec, sec, min }


        public Units(string lenght, string time)
        {
            this.lenght = lenght;
            this.time = time;
        }


        public double GetLenghtValue(ELenghtUnits unit)
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

        public string GetLenght 
        {
            get 
            { return this.lenght; }
        }

    }
}
