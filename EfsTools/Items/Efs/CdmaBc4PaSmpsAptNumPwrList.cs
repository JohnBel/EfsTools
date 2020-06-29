using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021034", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc4PaSmpsAptNumPwrList
    {
        [FieldCount(4)]
        public byte[] Value
        {
            get;
        }
    }
}