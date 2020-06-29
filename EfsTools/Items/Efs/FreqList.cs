using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/policyman/freq_list", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FreqList

    {
        public byte Value { get; set; }
    }
}