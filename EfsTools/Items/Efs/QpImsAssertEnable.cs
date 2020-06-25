using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(72609)]
    [EfsFile("/nv/item_files/ims/ims_assert_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsAssertEnable
    {
        public byte Value { get; set; }
    }
}