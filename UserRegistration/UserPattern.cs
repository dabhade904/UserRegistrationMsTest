using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserPattern
    {
        public static string F_L_Name_Pattern = "^[A-Z]{1}[a-z]{3,20}$";
        public static string Email_ID_Pattern = "^[a-zA-Z0-9]([._+-]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public static string Mobile_Pattern = "^[0-9]{2,2}[ ][7,8,9]{1,1}[0-9]{9}$";
        public static bool ValidateFirstAndLastName(string pattern)
        {
            var match = Regex.IsMatch(pattern, F_L_Name_Pattern);
            if (match)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateEmailId(string email)
        {
            var match = Regex.IsMatch(email, Email_ID_Pattern);
            if (match)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateMobileNumber(string mobile)
        {
            var match = Regex.IsMatch(mobile, Mobile_Pattern);
            if (match)
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