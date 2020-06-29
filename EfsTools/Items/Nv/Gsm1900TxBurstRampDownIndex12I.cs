using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1090)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampDownIndex12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}