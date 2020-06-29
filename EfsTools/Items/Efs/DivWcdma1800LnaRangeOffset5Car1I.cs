using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023789", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DivWcdma1800LnaRangeOffset5Car1
    {
        public short Value { get; set; }
    }
}