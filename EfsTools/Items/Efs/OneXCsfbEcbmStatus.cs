using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/mmode/sd/1xcsfb_ecbm_status", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OneXCsfbEcbmStatus
    {
        public byte Value { get; set; }
    }
}