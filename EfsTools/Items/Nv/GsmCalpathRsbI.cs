using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2750)]
    [Attributes(9)]
    public sealed class GsmCalpathRsb
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}