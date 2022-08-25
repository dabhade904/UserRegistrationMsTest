using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationProblem;

namespace UserRegistration
{
    public class UserRegistrationFactory
    {
        public static string? InvokedUserRegistration(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("UserRegistrationProblem.UserPattern");
                object userRegistrationObject = UserRegistrationFactory.CreateUserRegistration("UserRegistrationProblem.UserPattern", "UserPattern", message);
                MethodInfo userInfo = type.GetMethod(methodName);
                object user = userInfo.Invoke(userRegistrationObject, null);
                return user.ToString();
            }
            catch (Exception)
            {
                UserCustomException exp = new UserCustomException(UserCustomException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
                return exp.Message;
            }
        }
        public static object CreateUserRegistration(string className, string constructorName, string message)
        {
            Type type = typeof(UserPattern);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "" });

                    return instance;
                }
                else
                {

                    throw new UserCustomException(UserCustomException.ExceptionType.NO_SUCH_METHOD, "Contructor is Not Found");
                }
            }
            else
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}