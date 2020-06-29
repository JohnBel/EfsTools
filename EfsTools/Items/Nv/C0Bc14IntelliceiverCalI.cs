using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3623)]
    [Attributes(9)]
    public sealed class C0Bc14IntelliceiverCal
    {
        [FieldCount(7)]
        public ushort[] Value
        {
            get;
        }
    }
}