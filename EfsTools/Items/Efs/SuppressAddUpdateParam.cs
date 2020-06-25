using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/suppress_add_update_param", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SuppressAddUpdateParam
    {
        public byte Value { get; set; }
    }
}