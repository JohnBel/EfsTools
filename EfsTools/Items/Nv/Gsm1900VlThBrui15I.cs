using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2277)]
    [Attributes(9)]
    public sealed class Gsm1900VlThBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}