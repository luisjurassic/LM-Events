using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ValidaData
    {
               // check date format dd/mm/yyyy. but not if year < 1 or > 2013.
        public static bool IsValidDOB(string dob)
        {
            DateTime temp;
            if (DateTime.TryParse(dob, out temp))
                return (true);
            else
                return (false);
        }
        // checks date format dd/mm/yyyy and year > 1900!.
        public static bool ValidateBirthday(String date)
        {
            DateTime Temp;
            if (DateTime.TryParse(date, out Temp) == true &&
                Temp.Year > 1800 &&
                // Temp.Hour == 0 && Temp.Minute == 0 &&
                //Temp.Second == 0 && Temp.Millisecond == 0 &&
                Temp > DateTime.MinValue)
                return (true);
            else
                return (false);
        }
    }
}

