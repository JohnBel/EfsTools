using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qipcall_signal_strength_threshold", true, 0xE1FF)]
    [Attributes(9)]
    public class QipcallSignalStrengthThreshold
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value { get; set; }
    }
}