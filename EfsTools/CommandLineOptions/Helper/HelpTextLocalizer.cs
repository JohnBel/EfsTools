using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using EfsTools.Resourses;

namespace EfsTools.CommandLineOptions.Helper
{
    internal static class HelpTextLocalizer
    {
        static HelpTextLocalizer()
        {
            Localize();
        }

        public static void Localize()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                foreach (var type in assembly.GetTypes())
                {
                    if (!type.IsAbstract && !type.IsEnum)
                    {
                        if (type.GetCustomAttributes(typeof(VerbAttribute), true).FirstOrDefault() is VerbAttribute attribute1)
                        {
                            var helpText = GetLocalizedString(attribute1.HelpText);
                            attribute1.HelpText = helpText;
                        }
                        if (type.GetCustomAttributes(typeof(OptionAttribute), true).FirstOrDefault() is OptionAttribute attribute2)
                        {
                            var helpText = GetLocalizedString(attribute2.HelpText);
                            attribute2.HelpText = helpText;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private static string GetLocalizedString(string str)
        {
            string res;
            switch (str)
            {
                case "Create EFS directory":
                    res = Strings.CreateEFSDirectory;
                    break;
                case "Directory path":
                    res = Strings.DirectoryPath;
                    break;
                case "Don't create all parent directories":
                    res = Strings.DontCreateAllParentDirectories;
                    break;

                default:
                    res = str;
                    break;
            }
            return res;
        }
    }
}
