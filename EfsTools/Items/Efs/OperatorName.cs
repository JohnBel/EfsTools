using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/mmode/operator_name", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OperatorName
    {
        public byte Value { get; set; }
    }
}