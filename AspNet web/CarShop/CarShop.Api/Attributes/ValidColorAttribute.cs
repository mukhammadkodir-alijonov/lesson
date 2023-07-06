using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidColorAttribute : ValidationAttribute
    {
        private readonly List<string> existColor = new List<string>()
        {
            "black",
            "white",
            "gray"
        };
        public override bool IsValid(object? value)
        {
            string str = value!.ToString()!;
            return existColor.Contains(str.ToLower());
        }
    }
}
