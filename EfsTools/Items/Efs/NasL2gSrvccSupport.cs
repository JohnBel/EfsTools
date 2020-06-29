using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/nas_l2g_srvcc_support", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class NasL2gSrvccSupport
    {
        public byte Value { get; set; }
    }
}