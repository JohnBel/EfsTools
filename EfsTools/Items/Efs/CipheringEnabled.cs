using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/tdscdma/rrc/ciphering_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CipheringEnabled
    {
        public byte Value { get; set; }
    }
}