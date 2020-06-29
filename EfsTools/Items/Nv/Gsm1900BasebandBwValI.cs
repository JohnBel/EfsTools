using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2781)]
    [Attributes(9)]
    public sealed class Gsm1900BasebandBwVal
    {
        public byte Value { get; set; }
    }
}