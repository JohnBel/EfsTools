using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(506)]
    [Attributes(9)]
    public sealed class Ant2PcsRxLinSlp
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}