using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;

namespace EfsTools.Utils
{
    internal static class PathUtils
    {
        private static readonly Regex PhoneFileNameParser = new Regex(
            "^.*__(?<mode>[0-9, A-F]+)_(?<entryType>[0-9, A-F]+)",
            RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);

        public static string GetDirectoryName(string path)
        {
            if (string.IsNullOrEmpty(path)) return string.Empty;
            var index = path.LastIndexOf('/');
            return path.Substring(0, index);
        }

        public static string FixUnixPath(string path)
        {
            return path.LastOrDefault() == '/' ? path : $"{path}/";
        }

        public static string FixPath(string path)
        {
            return path.LastOrDefault() == '/' || path.LastOrDefault() == '\\'
                ? path
                : $"{path}\\";
        }

        public static FileInfo ParsePath(string path)
        {
            var match = PhoneFileNameParser.Match(path);
            if (match.Success)
            {
                var entryTypeStr = match.Groups["entryType"].Value;
                var modeStr = match.Groups["mode"].Value;
                var permission = int.Parse(modeStr, NumberStyles.HexNumber);
                var entryType = (DirectoryEntryType) int.Parse(entryTypeStr, NumberStyles.HexNumber);
                var isItemFile = entryType == DirectoryEntryType.ItemFile;
                return new FileInfo
                {
                    Permission = permission,
                    IsItemFile = isItemFile
                };
            }

            return null;
        }

        public static string BuildPath(string computerPath, string entryName, int permission,
            DirectoryEntryType entryType, bool noExtraData)
        {
            return noExtraData
                ? $"{computerPath}{entryName}"
                : $"{computerPath}{entryName}__{permission:X}_{(int) entryType:X}";
        }

        public static string RemoveExtraData(string fileName, string directoryPath)
        {
            var ind = fileName.IndexOf("__", StringComparison.Ordinal);
            var path = ind > 0 ? $"{directoryPath}{fileName.Substring(0, ind)}" : $"{directoryPath}{fileName}";
            return path;
        }

        public static string GetNvItemFileName(ushort nvItemId)
        {
            return $"NvItem__{nvItemId:00000000}";
        }

        public static bool IsNvItemFileName(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            return fileName != null && fileName.StartsWith("NvItem__");
        }

        public static string FindFile(string path)
        {
            try
            {
                var directoryPath = Path.GetDirectoryName(path);
                if (Directory.Exists(directoryPath))
                {
                    var fileName = Path.GetFileName(path);
                    var fileNameMask = $"{fileName}*";
                    var result = Directory.GetFiles(directoryPath, fileNameMask, SearchOption.TopDirectoryOnly);
                    if (result.Length > 0) return result[0];
                }
            }
            catch
            {
            }

            return path;
        }
    }

    internal sealed class FileInfo
    {
        public bool IsItemFile { get; set; }
        public int Permission { get; set; }
    }
}