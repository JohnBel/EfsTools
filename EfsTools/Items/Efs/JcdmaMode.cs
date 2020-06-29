using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/jcdma/jcdma_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class JcdmaMode
    {
        public byte Value { get; set; }
    }
}