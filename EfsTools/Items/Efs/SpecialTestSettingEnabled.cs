using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/rrc/special_test_setting_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SpecialTestSettingEnabled
    {
        public byte Value { get; set; }
    }
}