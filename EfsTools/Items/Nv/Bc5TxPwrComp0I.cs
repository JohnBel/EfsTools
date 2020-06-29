using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5009)]
    [Attributes(9)]
    public sealed class Bc5TxPwrComp0
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}