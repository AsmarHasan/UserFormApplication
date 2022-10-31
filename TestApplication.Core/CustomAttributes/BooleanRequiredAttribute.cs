using System.ComponentModel.DataAnnotations;

namespace TestApplication.Core.CustomAttributes
{
    public class BooleanRequiredAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value != null && (bool)value == true;
        }
    }
}
