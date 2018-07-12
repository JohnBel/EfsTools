using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmRuimConfigType : byte
    {
        Ruim = 0x00,
        Nv = 0x01,
        Pref = 0x02,
        Gsm1x = 0x03
    };
}