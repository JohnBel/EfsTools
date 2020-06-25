using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp2/ds_ppp_ctl_packet_on_dos", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DsPppCtlPacketOnDos
    {
        public byte Value { get; set; }
    }
}