using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1223)]
    [Attributes(9)]
    public sealed class Bc6Lna1Rise
    {
        public sbyte Value { get; set; }
    }
}