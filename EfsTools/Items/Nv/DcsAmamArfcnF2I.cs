using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2763)]
    [Attributes(9)]
    public sealed class DcsAmamArfcnF2
    {
        public ushort Value { get; set; }
    }
}