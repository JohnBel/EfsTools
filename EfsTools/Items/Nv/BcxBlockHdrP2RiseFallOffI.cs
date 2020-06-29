using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5137)]
    [Attributes(9)]
    public sealed class BcxBlockHdrP2RiseFallOff
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}