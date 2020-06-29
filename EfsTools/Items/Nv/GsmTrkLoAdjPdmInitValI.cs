using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(734)]
    [Attributes(9)]
    public sealed class GsmTrkLoAdjPdmInitVal
    {
        public ushort Value { get; set; }
    }
}