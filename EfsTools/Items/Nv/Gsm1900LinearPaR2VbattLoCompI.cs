using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6386)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR2VbattLoComp
    {
        public short Value { get; set; }
    }
}