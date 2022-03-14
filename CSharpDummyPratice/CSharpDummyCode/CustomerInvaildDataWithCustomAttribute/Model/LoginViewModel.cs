using CustomerInvaildDataWithCustomAttribute.CustomAttribute;

namespace CustomerInvaildDataWithCustomAttribute.Model
{
    public class LoginViewModel
    {
        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Feature { get; set; }
    }
}
