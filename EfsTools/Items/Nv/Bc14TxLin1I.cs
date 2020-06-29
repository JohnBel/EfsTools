using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4860)]
    [Attributes(9)]
    public sealed class Bc14TxLin1
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}