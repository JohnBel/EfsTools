using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022631", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB34TxRotAnglePaState
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}