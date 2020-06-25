using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(73763)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/features_status_list", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FeaturesStatusList
    {
        [Required]
        public byte Version { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
        public byte[] Value { get; set; }
    }
}