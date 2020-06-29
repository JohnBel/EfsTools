using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5003)]
    [Attributes(9)]
    public sealed class Bc1TxPwrComp2
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}