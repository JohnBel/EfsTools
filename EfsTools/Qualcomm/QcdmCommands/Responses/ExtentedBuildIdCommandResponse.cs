using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    internal class ExtentedBuildId
    {
        public ExtentedBuildId(
            uint msm,
            uint model,
            string softwareId,
            ushort modelName
        )
        {
            Msm = msm;
            MobileModelId = model;
            MobileSoftwareId = softwareId;
            MobileModelName = modelName;
        }

        public uint Msm { get; }
        public uint MobileModelId { get; }
        public string MobileSoftwareId { get; }
        public ushort MobileModelName { get; }
    }

    [QcdmCommand(QcdmCommand.ExtBuildId)]
    [QcdmMinResponseLength(71)]
    internal class ExtentedBuildIdCommandResponse : BaseCommandResponse
    {
        private ExtentedBuildIdCommandResponse()
        {
        }

        public ExtentedBuildId BuildId { get; private set; }

        public static ExtentedBuildIdCommandResponse Parse(byte[] data)
        {
            var result = new ExtentedBuildIdCommandResponse();
            result.CheckResponse(data);

            var msm = BitConverter.ToUInt32(data, 4);
            var model = BitConverter.ToUInt32(data, 8);
            var softwareId = Encoding.ASCII.GetString(data, 12, 57);
            var modelName = BitConverter.ToUInt16(data, 69);
            result.BuildId = new ExtentedBuildId(msm, model, softwareId, modelName);
            return result;
        }
    }
}