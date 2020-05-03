using System;

namespace Num.Services
{
    public class NumType
    {
        public string numType(int value)
        {
            string result = null;
            if(isPos(value))
            {
                result = "positive";
            }

            if(isNeg(value))
            {
                result = "negative";
            }

            if(isZero(value))
            {
                result = "Zero";
            }

            return result;

        }

        public bool isPos(int value)
        {
            if(value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isNeg(int value)
        {
            if(value < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isZero(int value)
        {
            if(value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
