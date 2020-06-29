using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(132)]
    [Attributes(9)]
    public sealed class CdmaTxLinMasterOff0
    {
        public ushort Value { get; set; }
    }
}