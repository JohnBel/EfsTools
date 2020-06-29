using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6387)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR2VbattHiComp
    {
        public short Value { get; set; }
    }
}