using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qipcall_dan_retry_timer_duration", true, 0xE1FF)]
    [Attributes(9)]
    public class QipcallDanRetryTimerDuration
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
    }
}