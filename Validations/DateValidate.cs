using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
   public class DateValidate : ValidationAttribute
    {
        public bool IsJoiningDateValid(string joiningDate)
        {

            Regex regex = new Regex(@"[0-9]{4}/[0-9]{2}/[0-9]{2}");
            Match match = regex.Match(joiningDate);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
