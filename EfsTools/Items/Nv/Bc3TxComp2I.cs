using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1554)]
    [Attributes(9)]
    public sealed class Bc3TxComp2
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}