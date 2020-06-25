using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/nas/max_validate_sim_counter", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MaxValidateSimCounter
    {
        public byte Value { get; set; }
    }
}