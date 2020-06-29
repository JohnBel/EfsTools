using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022048", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc14IntelliceiverCal
    {
        [FieldCount(7)]
        public ushort[] Value
        {
            get;
        }
    }
}