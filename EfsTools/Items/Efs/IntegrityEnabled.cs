using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/tdscdma/rrc/integrity_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class IntegrityEnabled
    {
        public byte Value { get; set; }
    }
}