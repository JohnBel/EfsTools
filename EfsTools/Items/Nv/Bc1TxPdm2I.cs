using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4801)]
    [Attributes(9)]
    public sealed class Bc1TxPdm2
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}