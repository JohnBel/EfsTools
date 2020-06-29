using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2316)]
    [Attributes(9)]
    public sealed class Gsm1900VhThBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}