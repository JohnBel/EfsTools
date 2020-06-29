using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5020)]
    [Attributes(9)]
    public sealed class Bc11TxPwrComp3
    {
        [FieldCount(32)]
        public sbyte[] Value
        {
            get;
        }
    }
}