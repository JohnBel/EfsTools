using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2318)]
    [Attributes(9)]
    public sealed class Gsm1900VhThBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}