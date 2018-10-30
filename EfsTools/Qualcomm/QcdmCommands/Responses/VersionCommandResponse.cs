using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    internal class QcdmVersion
    {
        public QcdmVersion(
            string cDate, string cTime, string rDate, string rTime,
            string verDir, byte scm, byte caiRev, byte model,
            byte firmwareRev, byte slotCycleIndex,
            byte hwVersionMajor, byte hwVersionMinor
        )
        {
            CompilationDate = cDate;
            CompilationTime = cTime;
            ReleaseDate = rDate;
            ReleaseTime = rTime;
            VersionDirectory = verDir;
            StationClassMask = scm;
            MobileCaiRevision = caiRev;
            MobileModel = model;
            MobileFirmwareRevision = firmwareRev;
            SlotCycleIndex = slotCycleIndex;
            HwVersionMajor = hwVersionMajor;
            HwVersionMinor = hwVersionMinor;
        }

        public string CompilationDate { get; }
        public string CompilationTime { get; }
        public string ReleaseDate { get; }
        public string ReleaseTime { get; }
        public string VersionDirectory { get; }
        public byte StationClassMask { get; }
        public byte MobileCaiRevision { get; }
        public byte MobileModel { get; }
        public byte MobileFirmwareRevision { get; }
        public byte SlotCycleIndex { get; }
        public byte HwVersionMajor { get; }
        public byte HwVersionMinor { get; }
    }

    [QcdmCommand(QcdmCommand.Version)]
    [QcdmMinResponseLength(55)]
    internal class VersionCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private VersionCommandResponse()
        {
        }

        public QcdmVersion Version { get; private set; }

        public static VersionCommandResponse Parse(byte[] data)
        {
            var result = new VersionCommandResponse();
            result.CheckResponse(data);
            var encoding = Encoding.ASCII;
            var cDate = encoding.GetString(data, 1, 11);
            var cTime = encoding.GetString(data, 12, 8);
            var rDate = encoding.GetString(data, 20, 11);
            var rTime = encoding.GetString(data, 32, 8);
            var verDir = encoding.GetString(data, 40, 8);
            var scm = data[48];
            var caiRev = data[49];
            var model = data[50];
            var firmwareRev = data[51];
            var slotCycleIndex = data[52];
            var hwVersionMajor = data[53];
            var hwVersionMinor = data[54];
            result.Version = new QcdmVersion(cDate, cTime, rDate, rTime, verDir, scm, caiRev, model, firmwareRev,
                slotCycleIndex, hwVersionMajor, hwVersionMinor);
            return result;
        }
    }
}