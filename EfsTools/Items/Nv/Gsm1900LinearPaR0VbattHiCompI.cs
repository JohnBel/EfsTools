using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6383)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR0VbattHiComp
    {
        public short Value { get; set; }
    }
}