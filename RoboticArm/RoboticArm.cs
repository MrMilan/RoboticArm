using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms
{
    class RoboticArm : IRoboticControl
    {
        #region GlobalInternalVariables
        private List<Joint> jointList = new List<Joint>();
        private string axisOfRotation;
        private double distance;
        #endregion

        public int TransformationMatrix
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int InertialMatrix
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Joint> JointList
        {
            get
            {
                return this.jointList;
            }
            set
            {
                value = this.jointList;
            }
        }

        public double Units
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double Distance
        {
            get
            {
                return this.distance;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string AxisOfRotation
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int AktualPosition
        {
            get { throw new NotImplementedException(); }
        }

        public void Initioalization()
        {
            foreach (var joint in jointList)
            {
                joint.Initioalization();
            }
        }

        public void Calibration()
        {
            throw new NotImplementedException();
        }



        public void MoveToPositionR(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public void MoveByVelocityR(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public void MoveByMomentR(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public void MoveToPosition(int numberOfMotor, int position)
        {
            throw new NotImplementedException();
        }

        public void MoveByVelocity(int numberOfMotor, int valueVelocity, int time)
        {
            throw new NotImplementedException();
        }
        public void MoveByMoment(int numberOfMotor, int valueMoment, int time)
        {
            throw new NotImplementedException();
        }

        public void SetAcceleration(int numberOfMotor, int valueAcceleration)
        {
            throw new NotImplementedException();
        }

        public void SetDeceleration(int numberOfMotor, int valueAcceleration)
        {
            throw new NotImplementedException();
        }

        public void SetAcceleration(int valueAcceleration)
        {
            foreach (var joint in jointList)
            {
                joint.SetAcceleration(JointList.IndexOf(joint) + 1, valueAcceleration);
            }
        }

        public void SetDeceleration(int valueAcceleration)
        {
            foreach (var joint in jointList)
            {
                joint.SetDeceleration(JointList.IndexOf(joint) + 1, valueAcceleration);
            }
        }

        public void SetMaxSpeed(int numberOfMotor, int valueSpeed)
        {
            throw new NotImplementedException();
        }

        public void SetMaxSpeed(int valueSpeed)
        {
            foreach (var joint in jointList)
            {
                joint.SetMaxSpeed(JointList.IndexOf(joint) + 1, valueSpeed);
            }
        }

        public void SetBordesInitializationPosition(int numberOfMotor, int minPosition, int maxPosition, int initialPosition)
        {
            throw new NotImplementedException();
        }

        public double[] ReadInputs()
        {
            throw new NotImplementedException();
        }



        public void Connection()
        {
            foreach (var joint in jointList)
            {
                joint.Connection();
            }
        }






    }
}
