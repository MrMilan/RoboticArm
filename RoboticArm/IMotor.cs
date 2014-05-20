using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms
{
    interface IMotor
    {
        int AktualPosition { get; }

        void SetMaximum(int numberOfMotor, int position);
        void SetMinimum(int numberOfMotor, int position);
        void SetAcceleration(int numberOfMotor, int valueAcceleration);
        void SetDeceleration(int numberOfMotor, int valueAcceleration);
        void SetMaxSpeed(int numberOfMotor, int valueSpeed);
        void SetHomePosition(int numberOfMotor, int position);
        void MoveToPosition(int numberOfMotor, int position);
        void MoveByVelocity(int numberOfMotor, int valueVelocity,int time);
        void MoveByMoment(int numberOfMotor, int valueMoment, int time);
        void MoveToHomePosition();
        void Connection();
        double [] ReadInputs();
    }
}
