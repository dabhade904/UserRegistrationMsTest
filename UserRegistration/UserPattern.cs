using System.Reflection;
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

        public static bool ValidateFirstAndLastName(string pattern)
        {
            try
            {
                var match = Regex.IsMatch(pattern, F_L_Name_Pattern);
                if (pattern.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "Message should not be empty");
                }
                if (match)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)

            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Message should not be null ");
            }

        }

        public static bool ValidateEmailId(string email)
        {
            try
            {
                var match = Regex.IsMatch(email, Email_ID_Pattern);
                if (email.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "Email should not be empty");
                }
                if (match)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Email should not be null ");
            }
        }
        public static bool ValidateMobileNumber(string mobile)
        {
            try
            {
                var match = Regex.IsMatch(mobile, Mobile_Pattern);
                if (mobile.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "Email should not be empty");
                }
                if (match)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Email should not be null ");
            }
        }

        public static bool ValidatePassword(string password)
        {
            try
            {
                var match = Regex.IsMatch(password, Password);
                if (password.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_MESSAGE, "Email should not be empty");
                }
                if (match)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_MESSAGE, "Email should not be null ");
            }
        }
    }
}