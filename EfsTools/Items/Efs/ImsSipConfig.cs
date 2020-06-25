using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/ims/ims_sip_config", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ImsSipConfig
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        public byte[] Value { get; set; }
    }
}