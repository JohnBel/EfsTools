using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3272)]
    [Attributes(9)]
    public sealed class C0Bc1LnaSwitchpointsLpm1
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}