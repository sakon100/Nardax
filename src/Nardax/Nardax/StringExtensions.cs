﻿using System;
using System.ComponentModel;

namespace Nardax
{
    public static class StringExtensions
    {

       //Klipper en sträng från vänster
        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            if (startIndex < 1)
            {
                return value;
            }

            return value.Substring(startIndex, maxLength);
        }

        //Klipper en sträng från höger
        public static string TruncateRight(this string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                return value;
            }

            return value.Substring(0, maxLength);
        }
    }
}
