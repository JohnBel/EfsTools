using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(947)]
    [Attributes(9)]
    public sealed class GprsEnableAniteGcf51010
    {
        public byte Value { get; set; }
    }
}