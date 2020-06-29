using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6193)]
    [Attributes(9)]
    public sealed class BcxBlock1TxPdm3
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}