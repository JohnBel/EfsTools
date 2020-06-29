using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte/rrc/cap/disable_cap_ies", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DisableCapIes
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}