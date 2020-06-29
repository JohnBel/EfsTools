using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6380)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR3VbattLoComp
    {
        public short Value { get; set; }
    }
}