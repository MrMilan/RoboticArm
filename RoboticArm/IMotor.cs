using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArm
{
    interface IMotor
    {
        int AktualPosition { get; set; }

        void SetMaximum();
        void SetMinimum();
        void SetAcceleration();
        void SetDeceleration();
        void SetHomePosition();
        void MoveToPosition();
        void MoveByVelocity();
        void MoveByMoment();
        void MoveToHomePosition();
        void ReadInputs();
    }
}
