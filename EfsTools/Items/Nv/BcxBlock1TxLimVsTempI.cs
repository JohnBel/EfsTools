using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6056)]
    [Attributes(9)]
    public sealed class BcxBlock1TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}