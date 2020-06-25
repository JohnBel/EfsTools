using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5927)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef1415
    {
        public uint Value { get; set; }
    }
}