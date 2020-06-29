using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/mmode/n_maxSIB8", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class NMaxSIB8
    {
        public byte Value { get; set; }
    }
}