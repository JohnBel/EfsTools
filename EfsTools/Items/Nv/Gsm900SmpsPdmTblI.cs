using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5092)]
    [Attributes(9)]
    public sealed class Gsm900SmpsPdmTbl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}