using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021056", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc11PaSmpsAptPdm1
    {
        [FieldCount(64)]
        public ushort[] Value
        {
            get;
        }
    }
}