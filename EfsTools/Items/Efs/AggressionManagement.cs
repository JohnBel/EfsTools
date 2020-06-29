using System;
using System.Runtime.InteropServices;

using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/aggression_management", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AggressionManagement
    {
        public byte Value { get; set; }
    }
}