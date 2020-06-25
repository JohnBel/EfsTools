using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/ims/qipcall_precondition_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallPreconditionEnable
    {
        public byte Value { get; set; }
    }
}