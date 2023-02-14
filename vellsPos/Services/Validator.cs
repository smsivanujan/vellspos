using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class Validator
    {
        public static ReturnResult validateText(string value, string label)
        {
            ReturnResult result = new ReturnResult(false, label + " cannot be empty");

            if (!value.Trim().Equals(""))
                result = new ReturnResult(true, "Validated");

            return result;
        }

        public static ReturnResult validateInteger(Int32 value, string label, bool canBeZero, Int32 min = -1, Int32 max = -1)
        {
            ReturnResult result = new ReturnResult(false, label + " cannot be empty");

            if (!canBeZero && value == -1)//if (!canBeZero && value == 0)
                result = new ReturnResult(false, label + " cannot be zero");
            else if (min != -1 && value < min)
                result = new ReturnResult(false, label + " cannot be lesser than " + min);
            else if (max != -1 && value > max)
                result = new ReturnResult(false, label + " cannot be larger than " + max);
            else
                result = new ReturnResult(true, "Validated");

            return result;
        }

        public static ReturnResult validateDecimal(Decimal value, string label, bool canBeZero, Int32 min = -1, Int32 max = -1)
        {
            ReturnResult result = new ReturnResult(false, label + " cannot be empty");

            if (!canBeZero && value == -1)//if (!canBeZero && value == 0)
                result = new ReturnResult(false, label + " cannot be zero");
            else if (min != -1 && value < min)
                result = new ReturnResult(false, label + " cannot be lesser than " + min);
            else if (max != -1 && value > max)
                result = new ReturnResult(false, label + " cannot be larger than " + max);
            else
                result = new ReturnResult(true, "Validated");

            return result;
        }

        public static ReturnResult validateMobile(String mobile, String label)
        {
            ReturnResult result = new ReturnResult(false, label + " Please enter valid mobile number");
            String strRegex = @"^\d{10}$";

            Regex re = new Regex(strRegex);
            if (!re.IsMatch(mobile))
            {
                result = new ReturnResult(true, "Validated");
            }
            return result;
        }

        public static ReturnResult validateEmail(String email, String label)
        {

            ReturnResult result = new ReturnResult(false, label + " Please enter valid email address");
            String strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
            {
                result = new ReturnResult(true, "Validated");
            }
            else
            {
                result = new ReturnResult(false, "Please enter valid email address");

            }
            return result;
        }
    }
}
