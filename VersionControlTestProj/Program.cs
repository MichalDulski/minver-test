using System;
using System.Diagnostics;
using System.Reflection;

namespace VersionControlTestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init");
            Console.WriteLine("___________________");
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.FileVersion;
            Console.WriteLine(version);
        }
    }
}
