using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2407)]
    [Attributes(9)]
    public sealed class GsmVmTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}