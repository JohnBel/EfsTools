using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/qmi/cat/qmi_cat_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QmiCatMode
    {
        public byte Value { get; set; }
    }
}