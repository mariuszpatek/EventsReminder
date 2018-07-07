using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace EventsReminder.Common
{
    public static class EnumExtensions
    {
        public static string GetEnumDisplayName(this Enum enumType) => enumType
            .GetType()
            .GetMember(enumType.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            .Name;

        public static string GetEnumDisplayDescription(this Enum enumType) => enumType
            .GetType()
            .GetMember(enumType.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            .Description;
    }
}
