using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2317)]
    [Attributes(9)]
    public sealed class Gsm1900VhThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}