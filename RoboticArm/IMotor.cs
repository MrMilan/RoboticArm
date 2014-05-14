using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArm
{
    interface IMotor
    {
        int AktualPosition { get; }

        void SetMaximum(int numberOfMotor, int position);
        void SetMinimum(int numberOfMotor, int position);
        void SetAcceleration(int numberOfMotor, int valueAcceleration);
        void SetDeceleration(int numberOfMotor, int valueAcceleration);
        void SetHomePosition(int numberOfMotor, int position);
        void MoveToPosition(int numberOfMotor, int position);
        void MoveByVelocity(int numberOfMotor, int valueVelocity,int time);
        void MoveByMoment(int numberOfMotor, int valueMoment, int time);
        void MoveToHomePosition();
        void ReadInputs();
    }
}
