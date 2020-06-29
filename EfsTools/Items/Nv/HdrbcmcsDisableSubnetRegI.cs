using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3514)]
    [Attributes(9)]
    public sealed class HdrbcmcsDisableSubnetReg
    {
        public byte Value { get; set; }
    }
}