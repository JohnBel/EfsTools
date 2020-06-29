using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5235)]
    [Attributes(9)]
    public sealed class C0Bc10LnaSwitchpointsLpm1
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}