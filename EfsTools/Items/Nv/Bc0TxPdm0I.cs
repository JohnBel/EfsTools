using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4795)]
    [Attributes(9)]
    public sealed class Bc0TxPdm0
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}