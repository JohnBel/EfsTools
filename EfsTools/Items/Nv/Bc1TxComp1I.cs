using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1632)]
    [Attributes(9)]
    public sealed class Bc1TxComp1
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}