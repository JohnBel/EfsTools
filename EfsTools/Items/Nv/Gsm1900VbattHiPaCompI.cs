using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1096)]
    [Attributes(9)]
    public sealed class Gsm1900VbattHiPaComp
    {
        public byte Value { get; set; }
    }
}