using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(931)]
    [Attributes(9)]
    public sealed class VcoCoarseTuneTable
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}