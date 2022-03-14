using System;

namespace CustomerInvaildDataWithCustomAttribute.CustomAttribute
{
    // 可套用Targets : Field, Parameter, Property
    // AllowMultiple : False 不允許一個Field Parameter Property 重複套用
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter| AttributeTargets.Property, 
        AllowMultiple = false)]
    public class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }

        public RequiredAttribute()
        {
            ErrorMessage = "You cannot leave field, {0}, empty";
        }

        public RequiredAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
