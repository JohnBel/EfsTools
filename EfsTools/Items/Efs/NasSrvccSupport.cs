using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/nas_srvcc_support", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class NasSrvccSupport
    {
        public byte Value { get; set; }
    }
}