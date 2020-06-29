using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3624)]
    [Attributes(9)]
    public sealed class C0Bc14IntelliceiverDetThresh
    {
        [FieldCount(10)]
        public sbyte[] Value
        {
            get;
        }
    }
}