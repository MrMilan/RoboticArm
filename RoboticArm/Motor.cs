using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobixLib;

namespace RoboticArms
{
    class Motor : IMotor
    {
        #region GlobalVariebles

        private int nexusHandle = 0;
        private int usborHandle = 0;
        private int podHandle = 0;

        #endregion

        public int AktualPosition
        {
            get
            {
                throw new NotImplementedException();
            }

        }

        public void SetMaximum(int numberOfMotor, int position)
        {
            CommandToUsbor("maxpos " + numberOfMotor.ToString() + " " + position.ToString());
        }

        public void SetMinimum(int numberOfMotor, int position)
        {
            CommandToUsbor("minpos " + numberOfMotor.ToString() + " " + position.ToString());
        }

        public void SetAcceleration(int numberOfMotor, int valueAcceleration)
        {
            if (valueAcceleration > 1 && valueAcceleration < 10001)
            {
                CommandToUsbor("accel " + numberOfMotor.ToString() + " " + valueAcceleration.ToString());
            }
            else
            {
                throw new ArgumentException("Value must be between 1 and 10000");
            }

        }

        public void SetDeceleration(int numberOfMotor, int valueAcceleration)
        {

            if (valueAcceleration > 1 && valueAcceleration < 10001)
            {
                CommandToUsbor("decel " + numberOfMotor.ToString() + " " + valueAcceleration.ToString());
            }
            else
            {
                throw new ArgumentException("Value must be between 1 and 10000");
            }
        }

        public void SetHomePosition(int numberOfMotor, int position)
        {
            CommandToUsbor("maxpos " + numberOfMotor.ToString() + " " + position.ToString());
        }


        public void MoveToPosition(int numberOfMotor, int position)
        {
            CommandToUsbor("move " + numberOfMotor.ToString() + " to " + position.ToString());

        }

        public void MoveByVelocity(int numberOfMotor, int valueVelocity, int time)
        {
            throw new NotImplementedException();
        }

        public void MoveByMoment(int numberOfMotor, int valueMoment, int time)
        {
            throw new NotImplementedException();
        }

        public void MoveToHomePosition()
        {
            CommandToUsbor("restart");
        }

        public double [] ReadInputs()
        {
            throw new NotImplementedException();
        }

        public void RobixConnection()
        {

            RbxNexwayLib.rbxInitNexwayLib("RobixTest");
            string hostName = "localhost";

            int errorNumber;
            int lengthErrorString = 255;
            string errorMsg = GetStringOfWhiteSpace(lengthErrorString);
            int maxlen = 0;

            errorNumber = RbxNexwayLib.rbxNexway_createNexusConnection(ref hostName, ref nexusHandle);

            if (errorNumber != 0)
            {
                int helpNumber = RbxNexwayLib.rbxLib_getErrMsg(errorNumber, ref errorMsg, lengthErrorString, ref maxlen);
                throw new Exception("Error in creation connection.\nOriginal error:\n" + errorMsg);
                errorMsg = GetStringOfWhiteSpace(lengthErrorString);
                errorNumber = 0;
            }
            errorNumber = RbxNexwayLib.rbxNexusConnection_connect(nexusHandle);
            if (errorNumber != 0)
            {
                int helpNumber = RbxNexwayLib.rbxLib_getErrMsg(errorNumber, ref errorMsg, lengthErrorString, ref maxlen);
                throw new Exception("Error in connection\nOriginal error:\n" + errorMsg);
                errorMsg = GetStringOfWhiteSpace(lengthErrorString);
                errorNumber = 0;
            }
            errorNumber = RbxNexwayLib.rbxNexusConnection_getUsborByIndex(nexusHandle, 0, ref usborHandle);
            if (errorNumber != 0)
            {
                int helpNumber = RbxNexwayLib.rbxLib_getErrMsg(errorNumber, ref errorMsg, lengthErrorString, ref maxlen);
                throw new Exception("Error in getUsbor\nOriginal error:\n" + errorMsg);
                errorMsg = GetStringOfWhiteSpace(lengthErrorString);
                errorNumber = 0;
            }
            errorNumber = RbxNexwayLib.rbxUsbor_getPod(usborHandle, 1, ref podHandle);
            if (errorNumber != 0)
            {
                int helpNumber = RbxNexwayLib.rbxLib_getErrMsg(errorNumber, ref errorMsg, lengthErrorString, ref maxlen);
                throw new Exception("Error in getPod.\nOriginal error:\n" + errorMsg);
                errorMsg = GetStringOfWhiteSpace(lengthErrorString);
                errorNumber = 0;
            }

        }

        private void CommandToUsbor(string command)
        {
            int seq = 1;
            RbxNexwayLib.rbxPod_runQuickScript(podHandle, ref command, ref seq);
        }

        private string GetStringOfWhiteSpace(int length)
        {
            string spaceString = " ";
            for (int i = 0; i < length - 1; i++)
            {
                spaceString += " ";
            }
            return spaceString;
        }

    }
}
