using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DAL.Utilities
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (field == null) return enumValue.ToString();

            var displayAttribute = field.GetCustomAttribute<DisplayAttribute>();
            return displayAttribute?.GetName() ?? enumValue.ToString();
        }
    }
}
