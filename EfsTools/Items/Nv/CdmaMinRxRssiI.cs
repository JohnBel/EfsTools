using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(879)]
    [Attributes(9)]
    public sealed class CdmaMinRxRssi
    {
        public short Value { get; set; }
    }
}