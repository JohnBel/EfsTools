using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1261)]
    [Attributes(9)]
    public sealed class Bc6P1RiseFallOff
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}