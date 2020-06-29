using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1303)]
    [Attributes(9)]
    public sealed class GsmPaTempCompInt8Index14
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}