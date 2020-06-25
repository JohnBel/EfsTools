using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/ser_req_throttle_behavior", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SerReqThrottleBehavior
    {
        public uint Value { get; set; }
    }
}