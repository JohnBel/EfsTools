using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6182)]
    [Attributes(9)]
    public sealed class C0BcxBlock1LnaSwitchpointsLpm1
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}