using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/policyman/svc_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SvcMode
    {
        public byte Value { get; set; }
    }
}