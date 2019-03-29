using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/therm_monitor/config_test.ini", false, 0x81FF)]
    [Attributes(9)]
    public class ConfigTestIn
    {
    }
}