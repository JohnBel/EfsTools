using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/3gpp/lteps/attach_profile", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AttachProfile
    {
        public ushort Value { get; set; }
    }
}