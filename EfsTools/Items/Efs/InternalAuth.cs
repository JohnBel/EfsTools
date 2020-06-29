using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/internal_auth", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class InternalAuth
    {
        public byte Value { get; set; }
    }
}