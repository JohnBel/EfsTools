using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6381)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR3VbattHiComp
    {
        public short Value { get; set; }
    }
}