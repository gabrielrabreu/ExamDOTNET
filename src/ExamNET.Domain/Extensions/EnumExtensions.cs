using System.ComponentModel.DataAnnotations;

namespace ExamNET.Domain.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumType)
        {
            var name = enumType.GetAttribute<DisplayAttribute>()?.GetName();

            if (name == null) throw new ArgumentNullException(name);

            return name;
        }

        public static string GetDisplayDescription(this Enum enumType)
        {
            var description = enumType.GetAttribute<DisplayAttribute>()?.GetDescription();

            if (description == null) throw new ArgumentNullException(description);

            return description;
        }

        public static TAttribute? GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);

            if (name == null) throw new ArgumentNullException(name);

            return enumType.GetField(name)?.GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
        }
    }
}
