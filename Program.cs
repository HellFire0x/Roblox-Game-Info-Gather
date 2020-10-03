using System;

namespace Roblox_Info
{
    public static class Data
    {
        public static string Ip { get; set; }
        public static string Jst { get; set; }
        public static string Is { get; set; }
    }

    internal static class Program
    {
        private static void InitializeData()
        {
            DataGather.GetIp();
            DataGather.Jst();
            DataGather.Is();
        }
        
        public static void Main()
        {
            InitializeData();
            Console.WriteLine($"Game IP: {Data.Ip}");
            Console.WriteLine($"Join snapshot timer: {Data.Jst}");
            Console.WriteLine($"initialize schema: {Data.Is}");
            Console.ReadKey();
        }
    }
}