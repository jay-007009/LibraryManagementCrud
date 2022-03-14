using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Validations
{
    public class Validation: ValidationAttribute
    {
       

        public bool IsPhoneNumberValid(string phoneNumber)
        {

            Regex regex = new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$");
            Match match = regex.Match(phoneNumber);
            if (match.Success)
                return true;
            else
                return false;
        }

        public bool IsEmailIdValid(string email)
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

    }
}
