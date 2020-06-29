using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6378)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR2VbattLoComp
    {
        public short Value { get; set; }
    }
}