using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2314)]
    [Attributes(9)]
    public sealed class Gsm1900VhThBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}