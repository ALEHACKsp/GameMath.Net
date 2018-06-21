using System;
using System.Reflection;

namespace GameMath
{
    public static class Library
    {
        public static string Author
        {
            get
            {
                return "michel-pi";
            }
        }

        public static string Name
        {
            get
            {
                return "GameMath.Net";
            }
        }

        public static string URL
        {
            get
            {
                return "https://github.com/michel-pi/GameMath.Net";
            }
        }

        public static string Version
        {
            get
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    AssemblyName assemblyName = assembly.GetName();

                    return assemblyName.Version.ToString();
                }
                catch
                {
                    return "1.0.0.0";
                }
            }
        }
    }
}
