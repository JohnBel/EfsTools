using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(74)]
    [Attributes(9)]
    public sealed class AutoAnswerSetting
    {
        public byte Enable { get; set; }


        public byte Rings { get; set; }
    }
}