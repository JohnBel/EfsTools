using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

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

        public int TotalNumberOfBlocks { get; }
        public int PagesPerBlock { get; }
        public int PageSize { get; }
        public int TotalPageSize { get; }
        public int MakerId { get; }
        public int DeviceId { get; }
        public byte DeviceType { get; }
        public string Name { get; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsDevInfo)]
    [QcdmMinResponseLength(41)]
    internal class EfsDeviceInfoResponse : BaseSubSystemCommandResponse
    {
        private EfsDeviceInfoResponse()
        {
        }

        public QcdmEfsErrors Error { get; private set; }
        public EfsDeviceInfo DeviceInfo { get; private set; }

        public static EfsDeviceInfoResponse Parse(byte[] data)
        {
            var result = new EfsDeviceInfoResponse();
            result.CheckResponse(data);

            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
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
    }
}