using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4192)]
    [Attributes(9)]
    public sealed class CdmaSO70Enable
    {
        public byte Value { get; set; }
    }
}