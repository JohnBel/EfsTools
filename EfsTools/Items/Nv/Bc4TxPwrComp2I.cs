using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5032)]
    [Attributes(9)]
    public sealed class Bc4TxPwrComp2
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}