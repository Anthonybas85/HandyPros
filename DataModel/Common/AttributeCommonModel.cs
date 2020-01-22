using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataModel.Common
{
    public class LocalizedDisplayname1 : DisplayNameAttribute
    {
        public LocalizedDisplayname1(string resourceId) : base(GetMessageFromResource(resourceId)) { }

        private static string GetMessageFromResource(string resourceId)
        {
            return CommonResource.GetResource(resourceId);
        }
    }


    public class EmailValidationAttribute1 : RegularExpressionAttribute
    {
        public EmailValidationAttribute1() : base(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$") { }
    }

    public class CustomRegularExpression1 : RegularExpressionAttribute
    {
        public CustomRegularExpression1(string regularExpression, string errorMessageResourceName)
            : base(regularExpression)
        {
            ErrorMessageResourceName = errorMessageResourceName;
        }

        public override string FormatErrorMessage(string name)
        {
            var errorMessage = CommonResource.GetResource(ErrorMessageResourceName);
            return errorMessage;
        }
    }
}
