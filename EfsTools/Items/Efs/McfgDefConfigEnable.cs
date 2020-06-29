using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/client-key/mcfg_def_config_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class McfgDefConfigEnable
    {
        public byte Value { get; set; }
    }
}