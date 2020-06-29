using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1275)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex2
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}