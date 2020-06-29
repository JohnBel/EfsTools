using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(588)]
    [Attributes(9)]
    public sealed class AgcValue4Min
    {
        public sbyte Value { get; set; }
    }
}