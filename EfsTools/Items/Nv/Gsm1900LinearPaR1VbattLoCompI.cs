using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6384)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR1VbattLoComp
    {
        public short Value { get; set; }
    }
}