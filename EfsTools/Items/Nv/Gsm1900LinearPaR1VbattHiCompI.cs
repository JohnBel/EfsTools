using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6385)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR1VbattHiComp
    {
        public short Value { get; set; }
    }
}