using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/ser_req_throttle_behavior", true, 0xE1FF)]
    [Attributes(9)]
    public class SerReqThrottleBehavior
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
    }
}