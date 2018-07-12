using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmPhoneMode : byte
    {
        OfflineA = 0x00,
        OfflineD = 0x01,
        Reset = 0x02,
        Ftm = 0x03,
        Online = 0x04,
        Lpm = 0x05,
        PowerOff = 0x06
    };
}