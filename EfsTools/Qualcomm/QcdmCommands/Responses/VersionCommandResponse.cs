using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

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

        public string CompilationDate { get; private set; }
        public string CompilationTime { get; private set; }
        public string ReleaseDate { get; private set; }
        public string ReleaseTime { get; private set; }
        public string VersionDirectory { get; private set; }
        public byte StationClassMask { get; private set; }
        public byte MobileCaiRevision { get; private set; }
        public byte MobileModel { get; private set; }
        public byte MobileFirmwareRevision { get; private set; }
        public byte SlotCycleIndex { get; private set; }
        public byte HwVersionMajor { get; private set; }
        public byte HwVersionMinor { get; private set; }
    }

    [QcdmCommand(QcdmCommand.Version)]
    [QcdmMinResponseLength(55)]
    internal class VersionCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private VersionCommandResponse()
        {
        }

        public static VersionCommandResponse Parse(byte[] data)
        {
            var result = new VersionCommandResponse();
            result.CheckResponse(data);
            var encoding = Encoding.ASCII;
            string cDate = encoding.GetString(data, 1, 11);
            string cTime = encoding.GetString(data, 12, 8);
            string rDate = encoding.GetString(data, 20, 11);
            string rTime = encoding.GetString(data, 32, 8);
            string verDir = encoding.GetString(data, 40, 8);
            byte scm = data[48];
            byte caiRev = data[49];
            byte model = data[50];
            byte firmwareRev = data[51];
            byte slotCycleIndex = data[52];
            byte hwVersionMajor = data[53];
            byte hwVersionMinor = data[54];
            result.Version = new QcdmVersion(cDate, cTime, rDate, rTime, verDir, scm, caiRev, model, firmwareRev,
                slotCycleIndex, hwVersionMajor, hwVersionMinor);
            return result;
        }

        public QcdmVersion Version { get; private set; }
    }
}