using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4459)]
    [Attributes(9)]
    public sealed class C1Wcdma1800BypassTimer
    {
        public ushort Value { get; set; }
    }
}