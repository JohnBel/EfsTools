using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    internal class EfsDeviceInfo
    {
        public EfsDeviceInfo(
            int totalNumberOfBlocks,
            int pagesPerBlock,
            int pageSize,
            int totalPageSize,
            int makerId,
            int deviceId,
            byte deviceType,
            string name
        )
        {
            TotalNumberOfBlocks = totalNumberOfBlocks;
            PagesPerBlock = pagesPerBlock;
            PageSize = pageSize;
            TotalPageSize = totalPageSize;
            MakerId = makerId;
            DeviceId = deviceId;
            DeviceType = deviceType;
            Name = name;
        }

        public int TotalNumberOfBlocks { get; private set; }
        public int PagesPerBlock { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPageSize { get; private set; }
        public int MakerId { get; private set; }
        public int DeviceId { get; private set; }
        public byte DeviceType { get; private set; }
        public string Name { get; private set; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.DevInfo)]
    [QcdmMinResponseLength(41)]
    internal class EfsDeviceInfoResponse : BaseSubSystemCommandResponse
    {
        private EfsDeviceInfoResponse()
        {
        }

        public static EfsDeviceInfoResponse Parse(byte[] data)
        {
            var result = new EfsDeviceInfoResponse();
            result.CheckResponse(data);

            var error = (QcdmEfsErrors)BitConverter.ToInt32(data, 4);
            result.Error = error;
            var totalNumberOfBlocks = BitConverter.ToInt32(data, 8);
            var pagesPerBlock = BitConverter.ToInt32(data, 16);
            var pageSize = BitConverter.ToInt32(data, 24);
            var totalPageSize = BitConverter.ToInt32(data, 28);
            var makerId = BitConverter.ToInt32(data, 32);
            var deviceId = BitConverter.ToInt32(data, 36);
            var deviceType = data[40];
            var nameLength = data.Length - 42;
            if (nameLength < 0)
            {
                nameLength = 0;
            }
            var name = Encoding.ASCII.GetString(data, 41, nameLength);


            result.DeviceInfo = new EfsDeviceInfo(totalNumberOfBlocks, pagesPerBlock, pageSize, totalPageSize,
                makerId, deviceId, deviceType, name);
            return result;
        }

        public QcdmEfsErrors Error { get; private set; }
        public EfsDeviceInfo DeviceInfo { get; private set; }
    }
}