using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1285)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex12
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}