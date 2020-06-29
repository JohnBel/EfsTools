using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6379)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR2VbattHiComp
    {
        public short Value { get; set; }
    }
}