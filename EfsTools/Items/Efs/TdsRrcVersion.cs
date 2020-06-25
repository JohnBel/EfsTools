using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/rrc/tds_rrc_version", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdsRrcVersion
    {
        public uint Value { get; set; }
    }
}