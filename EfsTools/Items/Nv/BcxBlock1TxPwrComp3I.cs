using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6202)]
    [Attributes(9)]
    public sealed class BcxBlock1TxPwrComp3
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}