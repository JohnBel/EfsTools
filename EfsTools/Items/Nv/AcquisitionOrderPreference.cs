using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(848)]
    [Attributes(41)]
    public sealed class AcquisitionOrderPreference
    {
        public byte Nam { get; set; }


        public ushort Value { get; set; }
    }
}