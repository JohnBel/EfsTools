using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3145)]
    [Attributes(9)]
    public sealed class Gsm1900AmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}