using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/eHRPD/mandatory_apn_list.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class MandatoryApnListTxt
    {
    }
}