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
        double Units { get; set; }
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
        void SetBordesInitializationPosition(int numberOfMotor, int minPosition, int maxPosition, int initialPosition);
        double[] ReadInputs();
        void Connection();

    }
}
