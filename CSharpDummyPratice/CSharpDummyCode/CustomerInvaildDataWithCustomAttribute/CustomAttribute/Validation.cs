using System;

namespace CustomerInvaildDataWithCustomAttribute.CustomAttribute
{
    public static class Validation
    {
        public static bool PropertyValueIsValid(Type t, string enteredValue, string elementName, out string errorMessage)
        {
            errorMessage = "";
            return false;
        }

    }
}
