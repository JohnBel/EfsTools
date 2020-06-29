using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2765)]
    [Attributes(9)]
    public sealed class Gsm1900AmamArfcnF2
    {
        public ushort Value { get; set; }
    }
}