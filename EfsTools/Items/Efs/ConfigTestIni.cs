using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/therm_monitor/config_test.ini", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ConfigTestIn
    {
    }
}