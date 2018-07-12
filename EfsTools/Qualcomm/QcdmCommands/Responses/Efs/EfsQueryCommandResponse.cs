using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    internal class QueryInfo
    {
        public QueryInfo(
            int maxFilenameLength,
            int mapPathnameLength,
            int maxSymlinkDepth,
            int maxFileSize,
            int maxDirectories,
            int maxMounts
        )
        {
            MaxFilenameLength = maxFilenameLength;
            MapPathnameLength = mapPathnameLength;
            MaxSymlinkDepth = maxSymlinkDepth;
            MaxFileSize = maxFileSize;
            MaxDirectories = maxDirectories;
            MaxMounts = maxMounts;
        }

        public int MaxFilenameLength { get; private set; }
        public int MapPathnameLength { get; private set; }
        public int MaxSymlinkDepth { get; private set; }
        public int MaxFileSize { get; private set; }
        public int MaxDirectories { get; private set; }
        public int MaxMounts { get; private set; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Query)]
    [QcdmMinResponseLength(28)]
    internal class EfsQueryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsQueryCommandResponse()
        {
        }

        public static EfsQueryCommandResponse Parse(byte[] data)
        {
            var result = new EfsQueryCommandResponse();
            result.CheckResponse(data);

            var maxFilenameLength = BitConverter.ToInt32(data, 4);
            var mapPathnameLength = BitConverter.ToInt32(data, 8);
            var maxSymlinkDepth = BitConverter.ToInt32(data, 12);
            var maxFileSize = BitConverter.ToInt32(data, 16);
            var maxDirectories = BitConverter.ToInt32(data, 20);
            var maxMounts = BitConverter.ToInt32(data, 24);
            result.Info = new QueryInfo(maxFilenameLength, mapPathnameLength, maxSymlinkDepth, maxFileSize,
                maxDirectories, maxMounts);
            return result;
        }

        public QueryInfo Info { get; private set; }
    }
}