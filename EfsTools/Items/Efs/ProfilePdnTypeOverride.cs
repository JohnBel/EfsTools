using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/3gpp/lteps/profile_pdn_type_override", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ProfilePdnTypeOverride
    {
        public byte Value { get; set; }
    }
}