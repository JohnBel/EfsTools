using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(206)]
    [Attributes(9)]
    public sealed class FmExpHdetVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}