using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6619)]
    [Attributes(9)]
    public sealed class LteB17MprBasedPaSwitchpointsShift
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}