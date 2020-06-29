using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6382)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR0VbattLoComp
    {
        public short Value { get; set; }
    }
}