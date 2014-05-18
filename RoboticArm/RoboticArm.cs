using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboticArms
{
    class RoboticArm:IRoboticControl
    {
        #region GlobalInternalVariables
        private List<Joint> jointList;
        private Units units;
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
                throw new NotImplementedException();
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

        public void Initioalization()
        {
            throw new NotImplementedException();
        }

        public void Calibration()
        {
            throw new NotImplementedException();
        }

        public void MoveToPosition(int numberOfMotor, int position)
        {
            throw new NotImplementedException();
        }

        public void MoveToPosition(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public void MoveByVelocity(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public void MoveByMoment(int x, int y, int z)
        {
            throw new NotImplementedException();
        }


        public void MoveByVelocity(int numberOfMotor, int valueVelocity, int time)
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
                joint.SetAcceleration(JointList.IndexOf(joint), valueAcceleration);
            }
        }

        public void SetDeceleration(int valueAcceleration)
        {
            foreach (var joint in jointList)
            {
                joint.SetDeceleration(JointList.IndexOf(joint), valueAcceleration);
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
              
    }
}
