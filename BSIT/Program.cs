sing System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace JubuluFoodKiosk
{
    internal class Program
    {
        private const string RestaurantName = "JUBULU FOOD KIOSK";
        private const string PaidStatus = "PAID";

        private static readonly string[] MenuNames =
        {
            "Chicken Meal",
            "Burger",
            "Fries",
            "Soft Drink",
            "Sundae"
        };

        private static readonly decimal[] MenuPrices =
        {
            120.00m,
            60.00m,
            45.00m,
            30.00m,
            35.00m
        };

    }
}