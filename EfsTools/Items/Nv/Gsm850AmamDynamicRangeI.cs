using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2747)]
    [Attributes(9)]
    public sealed class Gsm850AmamDynamicRange
    {
        [FieldCount(2)]
        public int[] Value { get; set; }
    }
}