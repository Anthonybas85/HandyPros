using System.ComponentModel;
using System.Globalization;
using DataModel.Resources;

namespace Business.Comm
{
    public class CModel
    {
        public CModel()
        {

        }
        public class LocalizedDisplayname : DisplayNameAttribute
        {
            public LocalizedDisplayname(string resourceKey)
            {
                ResourceKey = resourceKey;
            }

            public override string DisplayName
            {
                get
                {
                    string displayName = Resources.Site.ResourceManager.GetString(ResourceKey);

                    return string.IsNullOrEmpty(displayName)
                        ? string.Format("[[{0}]]", ResourceKey)
                        : displayName;
                }
            }

            private string ResourceKey { get; set; }
        }

        public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
        {
            private string _displayName;
            private string _id;

            public RequiredAttribute(string id, string errorMessageResourceName)
            {
                ErrorMessageResourceName = errorMessageResourceName;
                _id = id;
            }

            protected override ValidationResult IsValid
            (object value, ValidationContext validationContext)
            {
                _displayName = validationContext.DisplayName;
                return base.IsValid(value, validationContext);
            }

            public override string FormatErrorMessage(string name)
            {
                string currentCultureString = CResource.GetCurrentLanguage();
                CultureInfo currentCulture = new CultureInfo(currentCultureString);
                var msg = string.Format(Resources.Site.ResourceManager.GetString(ErrorMessageResourceName, currentCulture), Resources.Site.ResourceManager.GetString(_id, currentCulture));
                return msg;
            }
        }


        public class EmailValidationAttribute : RegularExpressionAttribute
        {
            public EmailValidationAttribute() : base(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$") { }
        }
    }
}