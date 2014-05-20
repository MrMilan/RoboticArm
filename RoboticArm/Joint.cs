using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RoboticArms
{
    class Joint:IRoboticControl
    {
        #region GlobalInternalVariables
        private List<Joint> jointList;
        private string axisOfRotation;
        private double distance;
        private IMotor motor = new Motor();

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
                throw new NotImplementedException();
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
                distance=value;
            }
        }

        public string AxisOfRotation
        {
            get
            {
                return axisOfRotation;
            }
            set
            {
                axisOfRotation=value;
            }
        }

        public int AktualPosition
        {
            get
            {
                return motor.AktualPosition;
            }

        }



        public void Initioalization()
        {
            motor.MoveToHomePosition();
        }

        public void Calibration()
        {
            throw new NotImplementedException();
        }

        public void MoveToPosition(int numberOfMotor, int position)
        {
            motor.MoveToPosition(numberOfMotor, position);
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
            motor.SetAcceleration(numberOfMotor, valueAcceleration);
        }

        public void SetDeceleration(int numberOfMotor, int valueAcceleration)
        {
            motor.SetDeceleration(numberOfMotor, valueAcceleration);
        }

        public void SetAcceleration(int valueAcceleration)
        {
            throw new NotImplementedException();
        }

        public void SetDeceleration(int valueAcceleration)
        {
            throw new NotImplementedException();
        }

        public void SetBordesInitializationPosition(int numberOfMotor, int minPosition, int maxPosition, int initialPosition)
        {
            motor.SetMinimum(numberOfMotor, minPosition);
            motor.SetMaximum(numberOfMotor, maxPosition);
            motor.SetHomePosition(numberOfMotor,initialPosition);
        }

        public double[] ReadInputs()
        {
            throw new NotImplementedException();
        }


        public void Connection()
        {
            motor.Connection();
        }
    }
}
