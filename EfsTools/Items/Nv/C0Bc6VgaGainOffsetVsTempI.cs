using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1259)]
    [Attributes(9)]
    public sealed class C0Bc6VgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public short[] Value
        {
            get;
        }
    }
}