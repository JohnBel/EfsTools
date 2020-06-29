using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/exclude_ptmsi_type_field", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ExcludePtmsiTypeField
    {
        public byte Value { get; set; }
    }
}