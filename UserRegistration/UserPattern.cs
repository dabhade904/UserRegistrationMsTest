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
            try
            {
                Regex pattern = new Regex(F_L_Name_Pattern);
                if (firstName.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "Name should not be empty");
                }
                var result = firstName.Select(str => pattern.Match(str).Value).ToList();
                return result;
            }
            catch (Exception)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Name is null");
            }
        }

        public static List<string> ValidateEmailId(List<string> email)
        {
            try
            {
                Regex pattern = new Regex(Email_ID_Pattern);
                if (email.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "Email should not be empty");
                }
                var result = email.Select(str => pattern.Match(str).Value).ToList();
                return result;
            }
            catch (Exception)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "EMail is null");
            }

        }

        public static List<string> ValidateMobileNumber(List<string> mobile)
        {
            try
            {
                Regex pattern = new Regex(Mobile_Pattern);
                if (mobile.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "mobile number should not be empty");
                }
                var result = mobile.Select(str => pattern.Match(str).Value).ToList();
                return result;
            }
            catch (Exception)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Mobile number is null");
            }
        }

        public static List<string> ValidatePassword(List<string> password)
        {
            try
            {
                Regex pattern = new Regex(Mobile_Pattern);
                if (password.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "password should not be empty");
                }
                var result = password.Select(str => pattern.Match(str).Value).ToList();
                return result;
            }
            catch (Exception)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Passoword is null");
            }
        }
    }
}