using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(334)]
    [Attributes(9)]
    public sealed class PcsExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}