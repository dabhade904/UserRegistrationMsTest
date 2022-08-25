using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using UserRegistration;

namespace UserRegistrationProblem
{
    public class UserPattern
    {
        public static string F_L_Name_Pattern = "^[A-Z]{1}[a-z]{3,20}$";
        public static string Email_ID_Pattern = "^[a-zA-Z0-9]([._+-]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public static string Mobile_Pattern = "^[0-9]{2,2}[ ][7,8,9]{1,1}[0-9]{9}$";
        public static string Password = "(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[+@#$%^&*!.()-]).{8,}";

        public static List<string> ValidateFirstAndLastName(List<string> firstName)
        {
            Regex pattern = new Regex(F_L_Name_Pattern);
            var result = firstName.Select(str => pattern.Match(str).Value).ToList();
            return result;
        }

        public static List<string> ValidateEmailId(List<string> email)
        {
            Regex pattern = new Regex(Email_ID_Pattern);
            var result = email.Select(str => pattern.Match(str).Value).ToList();
            return result;
        }

        public static List<string> ValidateMobileNumber(List<string> mobile)
        {
            Regex pattern = new Regex(Mobile_Pattern);
            var result = mobile.Select(str => pattern.Match(str).Value).ToList();
            return result;
        }

        public static List<string> ValidatePassword(List<string> password)
        {
            Regex pattern = new Regex(Mobile_Pattern);
            var result = password.Select(str => pattern.Match(str).Value).ToList();
            return result;
        }
    }
}