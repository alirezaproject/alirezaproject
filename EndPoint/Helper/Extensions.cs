﻿using System;

namespace EndPoint.Helper
{
    public static class Extensions
    {
        public static string ToFileName(this DateTime date)
        {
            return $"{date.Year:0000}-{date.Month:00}-{date.Day:00}-{date.Hour:00}-{date.Minute:00}-{date.Second:00}";
        }
    }
}