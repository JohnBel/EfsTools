using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    internal class ExtentedBuildId
    {
        public ExtentedBuildId(
            UInt32 msm,
            UInt32 model,
            string softwareId,
            UInt16 modelName
        )
        {
            Msm = msm;
            MobileModelId = model;
            MobileSoftwareId = softwareId;
            MobileModelName = modelName;
        }

        public UInt32 Msm { get; private set; }
        public UInt32 MobileModelId { get; private set; }
        public string MobileSoftwareId { get; private set; }
        public UInt16 MobileModelName { get; private set; }
    }

    [QcdmCommand(QcdmCommand.ExtBuildId)]
    [QcdmMinResponseLength(71)]
    internal class ExtentedBuildIdCommandResponse : BaseCommandResponse
    {
        private ExtentedBuildIdCommandResponse()
        {
        }

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

        public ExtentedBuildId BuildId { get; private set; }
    }
}