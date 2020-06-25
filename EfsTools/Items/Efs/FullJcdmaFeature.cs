using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp2/full_jcdma_feature", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FullJcdmaFeature
    {
        public byte Value { get; set; }
    }
}