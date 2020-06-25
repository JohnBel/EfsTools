using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/apn_reject/apn_reject_name.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ApnRejectNameTxt
    {
    }
}