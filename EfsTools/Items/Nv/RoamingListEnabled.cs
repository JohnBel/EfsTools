using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(256)]
    [Attributes(41)]
    public sealed class RoamingListEnabled
    {
        public byte Name { get; set; }


        public byte Enabled { get; set; }
    }
}