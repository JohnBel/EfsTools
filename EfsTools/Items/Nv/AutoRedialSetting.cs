using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(75)]
    [Attributes(9)]
    public sealed class AutoRedialSetting
    {
        public byte Enable { get; set; }


        public byte Rings { get; set; }
    }
}