using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5002)]
    [Attributes(9)]
    public sealed class Bc1TxPwrComp1
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}