using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/full_jcdma_feature", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FullJcdmaFeature
    {
        public byte Value { get; set; }
    }
}