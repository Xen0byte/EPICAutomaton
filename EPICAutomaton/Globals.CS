﻿using System.Diagnostics;

namespace BOT
{
    public static class ENV
    {
        public static bool DebugMode { get; set; }
        public static string Host { get; set; }
        public static int RuntimeInHours { get; set; }
    }

    public static class Headers
    {
        public static string Authorization { get; set; }
    }

    public static class Utility
    {
        public static Stopwatch Runtime = new Stopwatch();
    }
}
