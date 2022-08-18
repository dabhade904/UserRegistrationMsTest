using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserPattern
    {
        public static string F_L_Name_Pattern = "^[A-Z]{1}[a-z]{3,20}$";

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

    }
}