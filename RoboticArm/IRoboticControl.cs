using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArm
{
    interface IRoboticControl
    {
        int TransformationMatrix { get; set; }
        int InertialMatrix { get; set; }
        List<Joint> JointList { get; set; }
        double Units { get; set; }
        double Distance { get; set; }
        string AxisOfRotation { get; set; }

        void Initioalization();
        void Calibration();
        void MoveToPosition();
        void MoveByVelocity();
        void MoveByMoment();
        void SetAcceleration();
        void SetDeceleration();
        void SetBordesInitializationPosition();

    }
}
