using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [NvItemId(70287)]
    [EfsFile("/nv/item_files/ims/ims_hybrid_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsHybridEnable
    {
        public byte Value { get; set; }
    }
}