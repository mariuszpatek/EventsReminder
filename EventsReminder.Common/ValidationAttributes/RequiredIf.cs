using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EventsReminder.Common.ValidationAttributes
{
    public class RequiredIfAttribute : RequiredAttribute
    {
        private string _propertyName;
        private object[] _values;

        public RequiredIfAttribute(string propertyName, params object[] values)
        {
            _propertyName = propertyName;
            _values = values;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            object instance = validationContext.ObjectInstance;
            var propertyNameValue = instance
                                        .GetType()
                                        .GetProperty(_propertyName)
                                        .GetValue(instance)
                                        .ToString();

            if (_values.Any(v => v.ToString() == propertyNameValue))
                return base.IsValid(value, validationContext);

            return ValidationResult.Success;
        }
    }
}
