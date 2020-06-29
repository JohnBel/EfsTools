using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2761)]
    [Attributes(9)]
    public sealed class Gsm1900AmamArfcnF1
    {
        public ushort Value { get; set; }
    }
}