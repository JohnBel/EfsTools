using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6389)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR3VbattHiComp
    {
        public short Value { get; set; }
    }
}