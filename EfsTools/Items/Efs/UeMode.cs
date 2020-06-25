using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/policyman/ue_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class UeMode
    {
        public byte Value { get; set; }
    }
}