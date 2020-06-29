using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2509)]
    [Attributes(9)]
    public sealed class EdgeMultislotClass
    {
        public byte Value { get; set; }
    }
}