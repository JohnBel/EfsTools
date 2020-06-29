using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3541)]
    [Attributes(9)]
    public sealed class Bc14TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}