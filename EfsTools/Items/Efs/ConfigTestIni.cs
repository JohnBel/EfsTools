using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/therm_monitor/config_test.ini", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ConfigTestIn
    {
    }
}