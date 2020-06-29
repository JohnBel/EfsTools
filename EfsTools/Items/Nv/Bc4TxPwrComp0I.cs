using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5030)]
    [Attributes(9)]
    public sealed class Bc4TxPwrComp0
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}