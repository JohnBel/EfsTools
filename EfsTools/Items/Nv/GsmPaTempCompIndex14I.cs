using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(934)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex14
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}