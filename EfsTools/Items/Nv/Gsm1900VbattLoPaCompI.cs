using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1097)]
    [Attributes(9)]
    public sealed class Gsm1900VbattLoPaComp
    {
        public byte Value { get; set; }
    }
}