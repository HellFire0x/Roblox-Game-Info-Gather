using System;
using System.IO;
using System.Linq;

namespace Roblox_Info
{
    internal static class DataGather
    {
        public static void GetIp()
        {
            Data.Ip = File.ReadLines(
                $@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs\{new DirectoryInfo($@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs")
                    .GetFiles("*.txt")
                    .OrderByDescending(f => f.LastWriteTime).First()}").Skip(47).Take(1).First().Substring(File
                .ReadLines(
                    $@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs\{new DirectoryInfo($@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs")
                        .GetFiles("*.txt")
                        .OrderByDescending(f => f.LastWriteTime).First()}").Skip(47).Take(1).First()
                .IndexOf("Connecting to ", StringComparison.Ordinal) + "Connecting to ".Length);
        }

        
        public static void Jst()
        {
            Data.Jst = File.ReadLines(
                $@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs\{new DirectoryInfo($@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs")
                    .GetFiles("*.txt")
                    .OrderByDescending(f => f.LastWriteTime).First()}").Skip(55).Take(1).First().Substring(File
                .ReadLines(
                    $@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs\{new DirectoryInfo($@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs")
                        .GetFiles("*.txt")
                        .OrderByDescending(f => f.LastWriteTime).First()}").Skip(55).Take(1).First()
                .IndexOf("Join snapshot timer: ", StringComparison.Ordinal) + "Join snapshot timer: ".Length);
        }

        public static void Is()
        {
            Data.Is = File.ReadLines(
                path: $@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs\{new DirectoryInfo($@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs")
                    .GetFiles("*.txt")
                    .OrderByDescending(f => f.LastWriteTime).First()}").Skip(53).Take(1).First().Substring(File
                    .ReadLines(
                        $@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs\{new DirectoryInfo($@"C:\Users\{Environment.UserName}\AppData\Local\Roblox\logs")
                            .GetFiles("*.txt")
                            .OrderByDescending(f => f.LastWriteTime).First()}").Skip(53).Take(1).First()
                    .IndexOf("Time taken to initialize schema = ", StringComparison.Ordinal) +
                "Time taken to initialize schema = ".Length);
        }
    }
}