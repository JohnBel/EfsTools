using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020686", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6ExpLpmHdetVsAgcV2
    {
        [FieldCount(17)]
        public ushort[] Value
        {
            get;
        }
    }
}