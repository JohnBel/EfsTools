using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [NvItemId(73763)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/features_status_list", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FeaturesStatusList
    {
        [Required]
        public byte Version { get; set; }

        [FieldCount(63)]
        public byte[] Value { get; set; }
    }
}