using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms
{
    interface IRoboticControl
    {
        int TransformationMatrix { get; set; }
        int InertialMatrix { get; set; }
        List<Joint> JointList { get; set; }
        string TimeUnits { get; set; }
        string VelocityUnits { get; set; }
        string LenghtUnits { get; set; }
        double Distance { get; set; }
        string AxisOfRotation { get; set; }
        int AktualPosition { get; }

        void Initioalization();
        void Calibration();
        void MoveToPositionR(int x, int y, int z);
        void MoveByVelocityR(int x, int y, int z);
        void MoveByMomentR(int x, int y, int z);
        void MoveToPosition(int numberOfMotor, int position);
        void MoveByVelocity(int numberOfMotor, int valueVelocity, int time);
        void MoveByMoment(int numberOfMotor, int valueMoment, int time);
        void SetAcceleration(int numberOfMotor, int valueAcceleration);
        void SetDeceleration(int numberOfMotor, int valueAcceleration);
        void SetAcceleration(int valueAcceleration);
        void SetDeceleration(int valueAcceleration);
        void SetMaxSpeed(int numberOfMotor, int valueSpeed);
        void SetMaxSpeed(int valueSpeed);
        void SetBordesInitializationPosition(int numberOfMotor, int minPosition, int maxPosition, int initialPosition);
        double[] ReadInputs();
        void Connection();

    }
}
