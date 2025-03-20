using System;
using System.ComponentModel;

namespace Assignment4
{
    public enum FoodCategory
    {
        [Description("Meat 🥩")]
        Meat,

        [Description("Pasta 🍝")]
        Pasta,

        [Description("Pizza 🍕")]
        Pizza,

        [Description("Fish 🐟")]
        Fish,

        [Description("Seafood 🦞")]
        Seafood,

        [Description("Soups 🍜")]
        Soups,

        [Description("Stew 🍲")]
        Stew,

        [Description("Vegan 🥗")]
        Vegan,

        [Description("Vegetarian 🥦")]
        Vegetarian,

        [Description("Salads 🥬")]
        Salads,

        [Description("Snacks 🍿")]
        Snacks,

        [Description("Desserts 🍰")]
        Desserts,

        [Description("Beverages 🥤")]
        Beverages,

        [Description("Other 🍽️")]
        Other
    }
}
