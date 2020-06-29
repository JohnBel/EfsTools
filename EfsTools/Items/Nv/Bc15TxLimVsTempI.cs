using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4273)]
    [Attributes(9)]
    public sealed class Bc15TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}