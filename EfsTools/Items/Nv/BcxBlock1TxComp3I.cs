using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6064)]
    [Attributes(9)]
    public sealed class BcxBlock1TxComp3
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}