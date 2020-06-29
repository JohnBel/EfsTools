using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6146)]
    [Attributes(9)]
    public sealed class C0BcxBlockLnaSwitchpointsLpm1
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}