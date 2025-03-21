// New EnumExtensions.cs to Handle Enum Descriptions

using System;
using System.ComponentModel;
using System.Reflection;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        DescriptionAttribute? attribute = field?.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? value.ToString();
    }

    public static T GetEnumFromDescription<T>(this string description) where T : Enum
    {
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException("Description cannot be null or empty");
            
        foreach (T value in Enum.GetValues(typeof(T)))
        {
            if (value.GetDescription() == description)
                return value;
        }
        throw new ArgumentException($"No matching enum found for description: {description}");
    }
}
